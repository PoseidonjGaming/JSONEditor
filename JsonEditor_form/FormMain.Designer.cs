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
            menuStrip1.Items.AddRange(new ToolStripItem[] { nouveauToolStripMenuItem, ouvrirToolStripMenuItem, saveToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(866, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // nouveauToolStripMenuItem
            // 
            nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            nouveauToolStripMenuItem.Size = new Size(67, 20);
            nouveauToolStripMenuItem.Text = "Nouveau";
            nouveauToolStripMenuItem.Click += nouveauToolStripMenuItem_Click;
            // 
            // ouvrirToolStripMenuItem
            // 
            ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            ouvrirToolStripMenuItem.Size = new Size(52, 20);
            ouvrirToolStripMenuItem.Text = "Ouvrir";
            ouvrirToolStripMenuItem.Click += ouvrirToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(43, 20);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // treeViewJson
            // 
            treeViewJson.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            treeViewJson.HideSelection = false;
            treeViewJson.Location = new Point(12, 27);
            treeViewJson.Name = "treeViewJson";
            treeViewJson.Size = new Size(272, 411);
            treeViewJson.TabIndex = 1;
            treeViewJson.AfterSelect += treeViewJson_AfterSelect;
            // 
            // lblFieldName
            // 
            lblFieldName.AutoSize = true;
            lblFieldName.Location = new Point(6, 19);
            lblFieldName.Name = "lblFieldName";
            lblFieldName.Size = new Size(97, 15);
            lblFieldName.TabIndex = 2;
            lblFieldName.Text = "Nom du champ: ";
            // 
            // txtBoxFieldName
            // 
            txtBoxFieldName.Location = new Point(114, 16);
            txtBoxFieldName.Name = "txtBoxFieldName";
            txtBoxFieldName.Size = new Size(168, 23);
            txtBoxFieldName.TabIndex = 3;
            // 
            // txtBoxFieldValue
            // 
            txtBoxFieldValue.Location = new Point(114, 45);
            txtBoxFieldValue.Name = "txtBoxFieldValue";
            txtBoxFieldValue.Size = new Size(168, 23);
            txtBoxFieldValue.TabIndex = 5;
            // 
            // lblFieldValue
            // 
            lblFieldValue.AutoSize = true;
            lblFieldValue.Location = new Point(6, 48);
            lblFieldValue.Name = "lblFieldValue";
            lblFieldValue.Size = new Size(102, 15);
            lblFieldValue.TabIndex = 4;
            lblFieldValue.Text = "Valeur du champ: ";
            // 
            // txtBoxJSON
            // 
            txtBoxJSON.AcceptsReturn = true;
            txtBoxJSON.AcceptsTab = true;
            txtBoxJSON.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtBoxJSON.Location = new Point(584, 27);
            txtBoxJSON.Multiline = true;
            txtBoxJSON.Name = "txtBoxJSON";
            txtBoxJSON.ScrollBars = ScrollBars.Vertical;
            txtBoxJSON.Size = new Size(274, 411);
            txtBoxJSON.TabIndex = 6;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(207, 142);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
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
            gpBoxProperty.Location = new Point(290, 27);
            gpBoxProperty.Name = "gpBoxProperty";
            gpBoxProperty.Size = new Size(288, 171);
            gpBoxProperty.TabIndex = 8;
            gpBoxProperty.TabStop = false;
            gpBoxProperty.Text = "Propriété";
            // 
            // btnDelNode
            // 
            btnDelNode.Location = new Point(126, 142);
            btnDelNode.Name = "btnDelNode";
            btnDelNode.Size = new Size(75, 23);
            btnDelNode.TabIndex = 10;
            btnDelNode.Text = "Supprimer";
            btnDelNode.UseVisualStyleBackColor = true;
            // 
            // btnAddNode
            // 
            btnAddNode.Location = new Point(45, 142);
            btnAddNode.Name = "btnAddNode";
            btnAddNode.Size = new Size(75, 23);
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
            gpType.Location = new Point(6, 74);
            gpType.Name = "gpType";
            gpType.Size = new Size(276, 62);
            gpType.TabIndex = 8;
            gpType.TabStop = false;
            gpType.Text = "Type";
            // 
            // rdbProperty
            // 
            rdbProperty.AutoSize = true;
            rdbProperty.CheckAlign = ContentAlignment.MiddleRight;
            rdbProperty.Location = new Point(152, 22);
            rdbProperty.Name = "rdbProperty";
            rdbProperty.Size = new Size(73, 19);
            rdbProperty.TabIndex = 2;
            rdbProperty.TabStop = true;
            rdbProperty.Text = "Propriété";
            rdbProperty.UseVisualStyleBackColor = true;
            // 
            // rdbRawValue
            // 
            rdbRawValue.AutoSize = true;
            rdbRawValue.CheckAlign = ContentAlignment.MiddleRight;
            rdbRawValue.Location = new Point(68, 22);
            rdbRawValue.Name = "rdbRawValue";
            rdbRawValue.Size = new Size(78, 19);
            rdbRawValue.TabIndex = 1;
            rdbRawValue.TabStop = true;
            rdbRawValue.Text = "Raw Value";
            rdbRawValue.UseVisualStyleBackColor = true;
            // 
            // rdbObject
            // 
            rdbObject.AutoSize = true;
            rdbObject.CheckAlign = ContentAlignment.MiddleRight;
            rdbObject.Location = new Point(8, 22);
            rdbObject.Name = "rdbObject";
            rdbObject.Size = new Size(54, 19);
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
            gpbPattern.Location = new Point(290, 204);
            gpbPattern.Name = "gpbPattern";
            gpbPattern.Size = new Size(288, 234);
            gpbPattern.TabIndex = 9;
            gpbPattern.TabStop = false;
            gpbPattern.Text = "Pattern";
            // 
            // lblPatternName
            // 
            lblPatternName.AutoSize = true;
            lblPatternName.Location = new Point(8, 170);
            lblPatternName.Name = "lblPatternName";
            lblPatternName.Size = new Size(95, 15);
            lblPatternName.TabIndex = 10;
            lblPatternName.Text = "Nom du pattern:";
            // 
            // txtBoxPatternName
            // 
            txtBoxPatternName.Location = new Point(109, 167);
            txtBoxPatternName.Name = "txtBoxPatternName";
            txtBoxPatternName.Size = new Size(134, 23);
            txtBoxPatternName.TabIndex = 4;
            // 
            // lstBoxPattern
            // 
            lstBoxPattern.FormattingEnabled = true;
            lstBoxPattern.ItemHeight = 15;
            lstBoxPattern.Location = new Point(8, 22);
            lstBoxPattern.Name = "lstBoxPattern";
            lstBoxPattern.Size = new Size(276, 139);
            lstBoxPattern.TabIndex = 3;
            // 
            // btnLoadPattern
            // 
            btnLoadPattern.Location = new Point(168, 196);
            btnLoadPattern.Name = "btnLoadPattern";
            btnLoadPattern.Size = new Size(75, 23);
            btnLoadPattern.TabIndex = 2;
            btnLoadPattern.Text = "Charger";
            btnLoadPattern.UseVisualStyleBackColor = true;
            btnLoadPattern.Click += btnLoadPattern_Click;
            // 
            // btnDelPattern
            // 
            btnDelPattern.Location = new Point(87, 196);
            btnDelPattern.Name = "btnDelPattern";
            btnDelPattern.Size = new Size(75, 23);
            btnDelPattern.TabIndex = 1;
            btnDelPattern.Text = "Supprimer";
            btnDelPattern.UseVisualStyleBackColor = true;
            btnDelPattern.Click += btnDelPattern_Click;
            // 
            // btnAddPattern
            // 
            btnAddPattern.Location = new Point(6, 196);
            btnAddPattern.Name = "btnAddPattern";
            btnAddPattern.Size = new Size(75, 23);
            btnAddPattern.TabIndex = 0;
            btnAddPattern.Text = "Ajouter";
            btnAddPattern.UseVisualStyleBackColor = true;
            btnAddPattern.Click += btnAddPattern_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 450);
            Controls.Add(gpbPattern);
            Controls.Add(gpBoxProperty);
            Controls.Add(txtBoxJSON);
            Controls.Add(treeViewJson);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
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