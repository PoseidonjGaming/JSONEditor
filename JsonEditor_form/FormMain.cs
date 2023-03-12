using JsonEditor_form.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace JsonEditor_form
{
    public partial class FormMain : Form
    {
        private string content;
        private List<string> lines;
        public FormMain()
        {
            InitializeComponent();
            content = string.Empty;
            lines = new List<string>();
        }




        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new()
            {
                Filter = "File JSON|*.json"
            };
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                lines = File.ReadAllLines(fileDialog.FileName).ToList();
                string[] tempLines = String.Concat(lines.ToArray()).Split("},");
                string tempValue = tempLines[2]
                    .Replace("{", string.Empty).Split(',')[0];
            }
        }

        private void treeViewJson_AfterSelect(object sender, TreeViewEventArgs e)
        {
            txtBoxFieldValue.Text = treeViewJson.SelectedNode.Name;
            txtBoxFieldName.Text = treeViewJson.SelectedNode.Text;
        }

        private TreeNode AddNode(string[] parts)
        {
            return new StringObject(parts[0].Replace("\"", string.Empty).Trim(),
                GetString(parts.Skip(1).ToArray())
                    .Replace(",", string.Empty)
                    .Replace("\"", string.Empty)).Node;
            
        }

        private string GetString(string[] parts)
        {
            return String.Concat(parts);

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void GetStringObject()
        {
            foreach(TreeNode node in treeViewJson.Nodes)
            {

            }
        }
    }
}
