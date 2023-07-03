using JsonEditor_form.models;
using JsonEditor_form.Properties;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Windows.Forms;
using System.Xml.Linq;

namespace JsonEditor_form
{
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new()
            {
                Filter = "File JSON|*.json"
            };
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                jsonToTreeView(String.Join("", File.ReadAllLines(fileDialog.FileName).ToList()));
            }
        }

        private void treeViewJson_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeViewJson.Nodes[0].Nodes.Count == 0)
            {
                rdbProperty.Enabled = false;
                rdbRawValue.Enabled = false;
                rdbObject.Checked = true;
            }
            if (!treeViewJson.SelectedNode.Text.Equals("Root")
                && !treeViewJson.SelectedNode.Text.Equals("Object")
                && !treeViewJson.SelectedNode.Text.Equals("Raw Value"))
            {
                txtBoxFieldName.Text = treeViewJson.SelectedNode.Text;
            }
            txtBoxFieldValue.Text = treeViewJson.SelectedNode.Name;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = treeViewJson.SelectedNode;
            selectedNode.Text = txtBoxFieldName.Text.Equals(string.Empty) ? selectedNode.Text : txtBoxFieldName.Text;
            selectedNode.Name = txtBoxFieldValue.Text;

            txtBoxFieldName.Clear();
            txtBoxFieldValue.Clear();
            refresh();

        }

        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeViewJson.Nodes.Clear();
            treeViewJson.Nodes.Add(new TreeNode("Root"));
        }


        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new()
            {
                Filter = "File JSON|*.json"
            };

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(fileDialog.FileName, txtBoxJSON.Text);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (treeViewJson.SelectedNode != null)
            {
                if (rdbObject.Checked)
                {
                    TreeNode objectNode = new("Object");
                    objectNode.Nodes.Add(new TreeNode(txtBoxFieldName.Text)
                    {
                        Name = txtBoxFieldValue.Text
                    });
                    treeViewJson.SelectedNode.Nodes.Add(objectNode);
                }
                if (rdbRawValue.Checked)
                {
                    bool isChildSiblingsExist = findSiblings("Raw Value", treeViewJson.SelectedNode.Nodes).Count == 0;
                    bool isSiblingsExist = findSiblings("Raw Value", treeViewJson.SelectedNode.Parent.Nodes).Count == 0;
                    if (!isChildSiblingsExist)
                    {
                        treeViewJson.SelectedNode.Nodes.Add(new TreeNode("Raw Value")
                        {
                            Name = txtBoxFieldValue.Text
                        });
                    }
                    else if (isSiblingsExist)
                    {
                        TreeNode node = new(txtBoxFieldName.Text);
                        node.Nodes.Add(new TreeNode("Raw Value")
                        {
                            Name = txtBoxFieldValue.Text
                        });
                        treeViewJson.SelectedNode.Nodes.Add(node);
                    }

                }
                if (rdbProperty.Checked)
                {
                    treeViewJson.SelectedNode.Nodes.Add(new TreeNode { Text = txtBoxFieldName.Text, Name = txtBoxFieldValue.Text });
                }

                txtBoxFieldName.Clear();
                txtBoxFieldValue.Clear();
                treeViewJson.ExpandAll();

                rdbProperty.Enabled = true;
                rdbRawValue.Enabled = true;
                rdbObject.Checked = false;

                refresh();
            }


        }

        private void addToTreeNode(JsonObject json, TreeNode parent)
        {
            TreeNode clear = new("Object");
            foreach (KeyValuePair<string, JsonNode?> property in json)
            {
                TreeNode node = new(property.Key);
                JsonNode? value = property.Value;
                if (value != null
                    && value.GetType() == typeof(JsonArray))
                    browseJson(value.AsArray(), node);
                else if (value != null
                    && value.GetType() == typeof(JsonObject))
                    addToTreeNode(value.AsObject(), node);
                else if (value != null)
                    node.Name = value.ToString();


                clear.Nodes.Add(node);


            }
            parent.Nodes.Add(clear);
        }

        private void browseJson(JsonArray json, TreeNode node)
        {
            foreach (JsonNode? item in json.AsArray())
            {
                if (item != null)
                {

                    if (item.GetType() == typeof(JsonObject))
                        addToTreeNode(item.AsObject(), node);
                    else
                        node.Nodes.Add(new TreeNode("Raw Value")
                        {
                            Name = item.ToString()
                        });

                }

            }
        }

        private void jsonToTreeView(string jsonIn)
        {
            treeViewJson.Nodes.Clear();
            JsonNode json = JsonArray.Parse(jsonIn)!;

            if (json != null)
            {
                TreeNode node = new("Root");
                if (json.GetType() == typeof(JsonArray))
                {
                    browseJson(json.AsArray(), node);
                    treeViewJson.Nodes.Add(node);
                    txtBoxJSON.Text = treeViewToJson(new JsonArray(), treeViewJson.Nodes[0]).ToJsonString(new JsonSerializerOptions { WriteIndented = true });
                }
                else if (json.GetType() == typeof(JsonObject))
                {
                    addToTreeNode(json.AsObject(), node);
                    treeViewJson.Nodes.Add(node);
                    refresh();
                }
                treeViewJson.ExpandAll();

            }
        }

        private JsonNode treeViewToJson(JsonNode json, TreeNode parent)
        {
            foreach (TreeNode item in parent.Nodes)
            {
                if (item.Text.Equals("Object"))
                {
                    if (json.GetType() == typeof(JsonArray))
                        json.AsArray().Add(treeViewToJson(new JsonObject(), item));
                    else
                        json = treeViewToJson(new JsonObject(), item);
                }
                else if (item.Text.Equals("Raw Value"))
                {
                    findSiblings(item.Text, parent.Nodes).ForEach(e => json.AsArray().Add(e));
                    return json;

                }
                else if (item.Nodes.Count == 0)
                {
                    json.AsObject().Add(item.Text, item.Name);
                }
                else if (item.Nodes.Count > 1 || findSiblings("Raw Value", item.Nodes).Count > 0)
                {
                    JsonNode jsonNode = treeViewToJson(new JsonArray(), item);
                    json.AsObject().Add(item.Text, jsonNode);
                }
                else if (item.Nodes.Count == 1)
                {
                    JsonNode jsonNode = treeViewToJson(new JsonObject(), item);
                    json.AsObject().Add(item.Text, jsonNode);
                }

            }

            return json;

        }

        private List<string> findSiblings(string key, TreeNodeCollection nodes)
        {
            List<string> res = new();
            foreach (TreeNode node in nodes)
            {
                if (node.Text.Equals(key))
                    res.Add(node.Name);
            }
            return res;
        }

        private void refresh()
        {
            txtBoxJSON.Text = treeViewToJson((treeViewJson.Nodes[0].Nodes.Count == 1) ? new JsonObject() : new JsonArray(), treeViewJson.Nodes[0]).ToJsonString(new JsonSerializerOptions { WriteIndented = true });

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            refreshPattern();
        }

        private void btnAddPattern_Click(object sender, EventArgs e)
        {
            if (treeViewJson.Nodes[0] != null)
            {
                ClearValue(treeViewJson.Nodes[0]);
                refresh();
                Utils.AddPattern(new Pattern(txtBoxJSON.Text, txtBoxPatternName.Text));
                refreshPattern();
            }


        }

        private void ClearValue(TreeNode nodesIn)
        {
            foreach (TreeNode node in nodesIn.Nodes)
            {
                node.Name = string.Empty;
                ClearValue(node);
            }
        }

        private void btnDelPattern_Click(object sender, EventArgs e)
        {
            if (lstBoxPattern.SelectedIndex != -1)
            {
                Utils.RemovePattern(lstBoxPattern.SelectedIndex);
                refreshPattern();
            }
        }

        private void refreshPattern()
        {
            lstBoxPattern.Items.Clear();
            Utils.Patterns.ForEach(e => lstBoxPattern.Items.Add(e.Name));
        }

        private void btnLoadPattern_Click(object sender, EventArgs e)
        {
            if (lstBoxPattern.SelectedIndex != -1)
            {
                treeViewJson.Nodes.Clear();
                jsonToTreeView(Utils.GetPatternById(lstBoxPattern.SelectedIndex).Json);
            }
           
        }
    }
}
