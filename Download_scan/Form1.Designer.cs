namespace Download_scan
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnDownloadAll = new System.Windows.Forms.Button();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.txtLien = new System.Windows.Forms.TextBox();
            this.btnDLChapter = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // BtnDownloadAll
            // 
            this.BtnDownloadAll.Enabled = false;
            this.BtnDownloadAll.Location = new System.Drawing.Point(12, 39);
            this.BtnDownloadAll.Name = "BtnDownloadAll";
            this.BtnDownloadAll.Size = new System.Drawing.Size(106, 23);
            this.BtnDownloadAll.TabIndex = 0;
            this.BtnDownloadAll.Text = "Download All";
            this.BtnDownloadAll.UseVisualStyleBackColor = true;
            this.BtnDownloadAll.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Location = new System.Drawing.Point(12, 97);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(106, 23);
            this.btnOpenFolder.TabIndex = 1;
            this.btnOpenFolder.Text = "Select a folder";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtLien
            // 
            this.txtLien.Location = new System.Drawing.Point(13, 13);
            this.txtLien.Name = "txtLien";
            this.txtLien.Size = new System.Drawing.Size(400, 20);
            this.txtLien.TabIndex = 2;
            // 
            // btnDLChapter
            // 
            this.btnDLChapter.Enabled = false;
            this.btnDLChapter.Location = new System.Drawing.Point(12, 68);
            this.btnDLChapter.Name = "btnDLChapter";
            this.btnDLChapter.Size = new System.Drawing.Size(106, 23);
            this.btnDLChapter.TabIndex = 3;
            this.btnDLChapter.Text = "Download Chapter";
            this.btnDLChapter.UseVisualStyleBackColor = true;
            this.btnDLChapter.Click += new System.EventHandler(this.btnDLChapter_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(216, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Begin at :";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(161, 68);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(251, 459);
            this.listBox1.TabIndex = 6;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 126);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(121, 97);
            this.treeView1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 548);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnDLChapter);
            this.Controls.Add(this.txtLien);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.BtnDownloadAll);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDownloadAll;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.TextBox txtLien;
        private System.Windows.Forms.Button btnDLChapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TreeView treeView1;
    }
}

