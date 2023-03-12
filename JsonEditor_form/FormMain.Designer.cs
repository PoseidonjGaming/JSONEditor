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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeViewJson = new System.Windows.Forms.TreeView();
            this.lblFieldName = new System.Windows.Forms.Label();
            this.txtBoxFieldName = new System.Windows.Forms.TextBox();
            this.txtBoxFieldValue = new System.Windows.Forms.TextBox();
            this.lblFieldValue = new System.Windows.Forms.Label();
            this.txtBoxJSON = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(866, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripMenuItem,
            this.ouvrirToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // nouveauToolStripMenuItem
            // 
            this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.nouveauToolStripMenuItem.Text = "Nouveau";
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.ouvrirToolStripMenuItem.Text = "Ouvrir";
            this.ouvrirToolStripMenuItem.Click += new System.EventHandler(this.ouvrirToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // treeViewJson
            // 
            this.treeViewJson.Location = new System.Drawing.Point(12, 27);
            this.treeViewJson.Name = "treeViewJson";
            this.treeViewJson.Size = new System.Drawing.Size(232, 411);
            this.treeViewJson.TabIndex = 1;
            this.treeViewJson.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewJson_AfterSelect);
            // 
            // lblFieldName
            // 
            this.lblFieldName.AutoSize = true;
            this.lblFieldName.Location = new System.Drawing.Point(250, 92);
            this.lblFieldName.Name = "lblFieldName";
            this.lblFieldName.Size = new System.Drawing.Size(97, 15);
            this.lblFieldName.TabIndex = 2;
            this.lblFieldName.Text = "Nom du champ: ";
            // 
            // txtBoxFieldName
            // 
            this.txtBoxFieldName.Location = new System.Drawing.Point(353, 89);
            this.txtBoxFieldName.Name = "txtBoxFieldName";
            this.txtBoxFieldName.Size = new System.Drawing.Size(185, 23);
            this.txtBoxFieldName.TabIndex = 3;
            // 
            // txtBoxFieldValue
            // 
            this.txtBoxFieldValue.Location = new System.Drawing.Point(353, 118);
            this.txtBoxFieldValue.Name = "txtBoxFieldValue";
            this.txtBoxFieldValue.Size = new System.Drawing.Size(185, 23);
            this.txtBoxFieldValue.TabIndex = 5;
            // 
            // lblFieldValue
            // 
            this.lblFieldValue.AutoSize = true;
            this.lblFieldValue.Location = new System.Drawing.Point(250, 121);
            this.lblFieldValue.Name = "lblFieldValue";
            this.lblFieldValue.Size = new System.Drawing.Size(102, 15);
            this.lblFieldValue.TabIndex = 4;
            this.lblFieldValue.Text = "Valeur du champ: ";
            // 
            // txtBoxJSON
            // 
            this.txtBoxJSON.AcceptsReturn = true;
            this.txtBoxJSON.AcceptsTab = true;
            this.txtBoxJSON.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxJSON.Location = new System.Drawing.Point(544, 27);
            this.txtBoxJSON.Multiline = true;
            this.txtBoxJSON.Name = "txtBoxJSON";
            this.txtBoxJSON.Size = new System.Drawing.Size(310, 411);
            this.txtBoxJSON.TabIndex = 6;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(463, 147);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Valider";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 450);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtBoxJSON);
            this.Controls.Add(this.txtBoxFieldValue);
            this.Controls.Add(this.lblFieldValue);
            this.Controls.Add(this.txtBoxFieldName);
            this.Controls.Add(this.lblFieldName);
            this.Controls.Add(this.treeViewJson);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fichierToolStripMenuItem;
        private ToolStripMenuItem nouveauToolStripMenuItem;
        private ToolStripMenuItem ouvrirToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private TreeView treeViewJson;
        private Label lblFieldName;
        private TextBox txtBoxFieldName;
        private TextBox txtBoxFieldValue;
        private Label lblFieldValue;
        private TextBox txtBoxJSON;
        private Button btnSubmit;
    }
}