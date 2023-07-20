namespace JsonEditor_form
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            nouveauToolStripMenuItem = new ToolStripMenuItem();
            ouvrirToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            treeViewJson = new TreeView();
            lblFieldName = new Label();
            txtBoxFieldName = new TextBox();
            txtBoxFieldValue = new TextBox();
            lblFieldValue = new Label();
            txtBoxJSON = new TextBox();
            btnSubmit = new Button();
            gpBoxProperty = new GroupBox();
            btnDelNode = new Button();
            btnAddNode = new Button();
            gpType = new GroupBox();
            rdbProperty = new RadioButton();
            rdbRawValue = new RadioButton();
            rdbObject = new RadioButton();
            gpbPattern = new GroupBox();
            lblPatternName = new Label();
            txtBoxPatternName = new TextBox();
            lstBoxPattern = new ListBox();
            btnLoadPattern = new Button();
            btnDelPattern = new Button();
            btnAddPattern = new Button();
            menuStrip1.SuspendLayout();
            gpBoxProperty.SuspendLayout();
            gpType.SuspendLayout();
            gpbPattern.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { nouveauToolStripMenuItem, ouvrirToolStripMenuItem, saveToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(990, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // nouveauToolStripMenuItem
            // 
            nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            nouveauToolStripMenuItem.Size = new Size(82, 24);
            nouveauToolStripMenuItem.Text = "Nouveau";
            nouveauToolStripMenuItem.Click += nouveauToolStripMenuItem_Click;
            // 
            // ouvrirToolStripMenuItem
            // 
            ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            ouvrirToolStripMenuItem.Size = new Size(63, 24);
            ouvrirToolStripMenuItem.Text = "Ouvrir";
            ouvrirToolStripMenuItem.Click += ouvrirToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(54, 24);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // treeViewJson
            // 
            treeViewJson.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            treeViewJson.HideSelection = false;
            treeViewJson.Location = new Point(14, 36);
            treeViewJson.Margin = new Padding(3, 4, 3, 4);
            treeViewJson.Name = "treeViewJson";
            treeViewJson.Size = new Size(310, 547);
            treeViewJson.TabIndex = 1;
            treeViewJson.AfterSelect += treeViewJson_AfterSelect;
            // 
            // lblFieldName
            // 
            lblFieldName.AutoSize = true;
            lblFieldName.Location = new Point(7, 25);
            lblFieldName.Name = "lblFieldName";
            lblFieldName.Size = new Size(119, 20);
            lblFieldName.TabIndex = 2;
            lblFieldName.Text = "Nom du champ: ";
            // 
            // txtBoxFieldName
            // 
            txtBoxFieldName.Location = new Point(130, 21);
            txtBoxFieldName.Margin = new Padding(3, 4, 3, 4);
            txtBoxFieldName.Name = "txtBoxFieldName";
            txtBoxFieldName.Size = new Size(191, 27);
            txtBoxFieldName.TabIndex = 3;
            // 
            // txtBoxFieldValue
            // 
            txtBoxFieldValue.Location = new Point(130, 60);
            txtBoxFieldValue.Margin = new Padding(3, 4, 3, 4);
            txtBoxFieldValue.Name = "txtBoxFieldValue";
            txtBoxFieldValue.Size = new Size(191, 27);
            txtBoxFieldValue.TabIndex = 5;
            // 
            // lblFieldValue
            // 
            lblFieldValue.AutoSize = true;
            lblFieldValue.Location = new Point(7, 64);
            lblFieldValue.Name = "lblFieldValue";
            lblFieldValue.Size = new Size(127, 20);
            lblFieldValue.TabIndex = 4;
            lblFieldValue.Text = "Valeur du champ: ";
            // 
            // txtBoxJSON
            // 
            txtBoxJSON.AcceptsReturn = true;
            txtBoxJSON.AcceptsTab = true;
            txtBoxJSON.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtBoxJSON.Location = new Point(667, 36);
            txtBoxJSON.Margin = new Padding(3, 4, 3, 4);
            txtBoxJSON.Multiline = true;
            txtBoxJSON.Name = "txtBoxJSON";
            txtBoxJSON.ScrollBars = ScrollBars.Vertical;
            txtBoxJSON.Size = new Size(313, 547);
            txtBoxJSON.TabIndex = 6;
            txtBoxJSON.TextChanged += txtBoxJSON_TextChanged;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(237, 189);
            btnSubmit.Margin = new Padding(3, 4, 3, 4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(86, 31);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "Valider";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // gpBoxProperty
            // 
            gpBoxProperty.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            gpBoxProperty.Controls.Add(btnDelNode);
            gpBoxProperty.Controls.Add(btnAddNode);
            gpBoxProperty.Controls.Add(gpType);
            gpBoxProperty.Controls.Add(lblFieldName);
            gpBoxProperty.Controls.Add(btnSubmit);
            gpBoxProperty.Controls.Add(txtBoxFieldName);
            gpBoxProperty.Controls.Add(lblFieldValue);
            gpBoxProperty.Controls.Add(txtBoxFieldValue);
            gpBoxProperty.Location = new Point(331, 36);
            gpBoxProperty.Margin = new Padding(3, 4, 3, 4);
            gpBoxProperty.Name = "gpBoxProperty";
            gpBoxProperty.Padding = new Padding(3, 4, 3, 4);
            gpBoxProperty.Size = new Size(329, 228);
            gpBoxProperty.TabIndex = 8;
            gpBoxProperty.TabStop = false;
            gpBoxProperty.Text = "Propriété";
            // 
            // btnDelNode
            // 
            btnDelNode.Location = new Point(144, 189);
            btnDelNode.Margin = new Padding(3, 4, 3, 4);
            btnDelNode.Name = "btnDelNode";
            btnDelNode.Size = new Size(86, 31);
            btnDelNode.TabIndex = 10;
            btnDelNode.Text = "Supprimer";
            btnDelNode.UseVisualStyleBackColor = true;
            btnDelNode.Click += btnDelNode_Click;
            // 
            // btnAddNode
            // 
            btnAddNode.Location = new Point(51, 189);
            btnAddNode.Margin = new Padding(3, 4, 3, 4);
            btnAddNode.Name = "btnAddNode";
            btnAddNode.Size = new Size(86, 31);
            btnAddNode.TabIndex = 9;
            btnAddNode.Text = "Ajouter";
            btnAddNode.UseVisualStyleBackColor = true;
            btnAddNode.Click += btnAdd_Click;
            // 
            // gpType
            // 
            gpType.Controls.Add(rdbProperty);
            gpType.Controls.Add(rdbRawValue);
            gpType.Controls.Add(rdbObject);
            gpType.Location = new Point(7, 99);
            gpType.Margin = new Padding(3, 4, 3, 4);
            gpType.Name = "gpType";
            gpType.Padding = new Padding(3, 4, 3, 4);
            gpType.Size = new Size(315, 83);
            gpType.TabIndex = 8;
            gpType.TabStop = false;
            gpType.Text = "Type";
            // 
            // rdbProperty
            // 
            rdbProperty.AutoSize = true;
            rdbProperty.CheckAlign = ContentAlignment.MiddleRight;
            rdbProperty.Location = new Point(174, 29);
            rdbProperty.Margin = new Padding(3, 4, 3, 4);
            rdbProperty.Name = "rdbProperty";
            rdbProperty.Size = new Size(91, 24);
            rdbProperty.TabIndex = 2;
            rdbProperty.TabStop = true;
            rdbProperty.Text = "Propriété";
            rdbProperty.UseVisualStyleBackColor = true;
            // 
            // rdbRawValue
            // 
            rdbRawValue.AutoSize = true;
            rdbRawValue.CheckAlign = ContentAlignment.MiddleRight;
            rdbRawValue.Location = new Point(78, 29);
            rdbRawValue.Margin = new Padding(3, 4, 3, 4);
            rdbRawValue.Name = "rdbRawValue";
            rdbRawValue.Size = new Size(98, 24);
            rdbRawValue.TabIndex = 1;
            rdbRawValue.TabStop = true;
            rdbRawValue.Text = "Raw Value";
            rdbRawValue.UseVisualStyleBackColor = true;
            // 
            // rdbObject
            // 
            rdbObject.AutoSize = true;
            rdbObject.CheckAlign = ContentAlignment.MiddleRight;
            rdbObject.Location = new Point(9, 29);
            rdbObject.Margin = new Padding(3, 4, 3, 4);
            rdbObject.Name = "rdbObject";
            rdbObject.Size = new Size(67, 24);
            rdbObject.TabIndex = 0;
            rdbObject.TabStop = true;
            rdbObject.Text = "Objet";
            rdbObject.UseVisualStyleBackColor = true;
            // 
            // gpbPattern
            // 
            gpbPattern.Controls.Add(lblPatternName);
            gpbPattern.Controls.Add(txtBoxPatternName);
            gpbPattern.Controls.Add(lstBoxPattern);
            gpbPattern.Controls.Add(btnLoadPattern);
            gpbPattern.Controls.Add(btnDelPattern);
            gpbPattern.Controls.Add(btnAddPattern);
            gpbPattern.Location = new Point(331, 272);
            gpbPattern.Margin = new Padding(3, 4, 3, 4);
            gpbPattern.Name = "gpbPattern";
            gpbPattern.Padding = new Padding(3, 4, 3, 4);
            gpbPattern.Size = new Size(329, 312);
            gpbPattern.TabIndex = 9;
            gpbPattern.TabStop = false;
            gpbPattern.Text = "Pattern";
            // 
            // lblPatternName
            // 
            lblPatternName.AutoSize = true;
            lblPatternName.Location = new Point(9, 227);
            lblPatternName.Name = "lblPatternName";
            lblPatternName.Size = new Size(118, 20);
            lblPatternName.TabIndex = 10;
            lblPatternName.Text = "Nom du pattern:";
            // 
            // txtBoxPatternName
            // 
            txtBoxPatternName.Location = new Point(125, 223);
            txtBoxPatternName.Margin = new Padding(3, 4, 3, 4);
            txtBoxPatternName.Name = "txtBoxPatternName";
            txtBoxPatternName.Size = new Size(153, 27);
            txtBoxPatternName.TabIndex = 4;
            // 
            // lstBoxPattern
            // 
            lstBoxPattern.FormattingEnabled = true;
            lstBoxPattern.ItemHeight = 20;
            lstBoxPattern.Location = new Point(9, 29);
            lstBoxPattern.Margin = new Padding(3, 4, 3, 4);
            lstBoxPattern.Name = "lstBoxPattern";
            lstBoxPattern.Size = new Size(315, 184);
            lstBoxPattern.TabIndex = 3;
            // 
            // btnLoadPattern
            // 
            btnLoadPattern.Location = new Point(192, 261);
            btnLoadPattern.Margin = new Padding(3, 4, 3, 4);
            btnLoadPattern.Name = "btnLoadPattern";
            btnLoadPattern.Size = new Size(86, 31);
            btnLoadPattern.TabIndex = 2;
            btnLoadPattern.Text = "Charger";
            btnLoadPattern.UseVisualStyleBackColor = true;
            btnLoadPattern.Click += btnLoadPattern_Click;
            // 
            // btnDelPattern
            // 
            btnDelPattern.Location = new Point(99, 261);
            btnDelPattern.Margin = new Padding(3, 4, 3, 4);
            btnDelPattern.Name = "btnDelPattern";
            btnDelPattern.Size = new Size(86, 31);
            btnDelPattern.TabIndex = 1;
            btnDelPattern.Text = "Supprimer";
            btnDelPattern.UseVisualStyleBackColor = true;
            btnDelPattern.Click += btnDelPattern_Click;
            // 
            // btnAddPattern
            // 
            btnAddPattern.Location = new Point(7, 261);
            btnAddPattern.Margin = new Padding(3, 4, 3, 4);
            btnAddPattern.Name = "btnAddPattern";
            btnAddPattern.Size = new Size(86, 31);
            btnAddPattern.TabIndex = 0;
            btnAddPattern.Text = "Ajouter";
            btnAddPattern.UseVisualStyleBackColor = true;
            btnAddPattern.Click += btnAddPattern_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 600);
            Controls.Add(gpbPattern);
            Controls.Add(gpBoxProperty);
            Controls.Add(txtBoxJSON);
            Controls.Add(treeViewJson);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormMain";
            Text = "FormMain";
            Load += FormMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            gpBoxProperty.ResumeLayout(false);
            gpBoxProperty.PerformLayout();
            gpType.ResumeLayout(false);
            gpType.PerformLayout();
            gpbPattern.ResumeLayout(false);
            gpbPattern.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private TreeView treeViewJson;
        private Label lblFieldName;
        private TextBox txtBoxFieldName;
        private TextBox txtBoxFieldValue;
        private Label lblFieldValue;
        private TextBox txtBoxJSON;
        private Button btnSubmit;
        private GroupBox gpBoxProperty;
        private GroupBox gpType;
        private RadioButton rdbRawValue;
        private RadioButton rdbObject;
        private Button btnAddNode;
        private RadioButton rdbProperty;
        private ToolStripMenuItem nouveauToolStripMenuItem;
        private ToolStripMenuItem ouvrirToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private Button btnDelNode;
        private GroupBox gpbPattern;
        private Button btnAddPattern;
        private ListBox lstBoxPattern;
        private Button btnLoadPattern;
        private Button btnDelPattern;
        private Label lblPatternName;
        private TextBox txtBoxPatternName;
    }
}