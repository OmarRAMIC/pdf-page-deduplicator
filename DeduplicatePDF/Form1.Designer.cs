namespace DeduplicatePDF
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnDeDuplicate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSrc = new System.Windows.Forms.TextBox();
            this.txtDst = new System.Windows.Forms.TextBox();
            this.btnSrc = new System.Windows.Forms.Button();
            this.btnDst = new System.Windows.Forms.Button();
            this.DlgFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pgbFiles = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeDuplicate
            // 
            this.btnDeDuplicate.Location = new System.Drawing.Point(256, 126);
            this.btnDeDuplicate.Name = "btnDeDuplicate";
            this.btnDeDuplicate.Size = new System.Drawing.Size(141, 23);
            this.btnDeDuplicate.TabIndex = 0;
            this.btnDeDuplicate.Text = "DeDuplicate Pages";
            this.btnDeDuplicate.UseVisualStyleBackColor = true;
            this.btnDeDuplicate.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pgbFiles);
            this.groupBox1.Controls.Add(this.btnDst);
            this.groupBox1.Controls.Add(this.btnDeDuplicate);
            this.groupBox1.Controls.Add(this.btnSrc);
            this.groupBox1.Controls.Add(this.txtDst);
            this.groupBox1.Controls.Add(this.txtSrc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 200);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source Directory:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destination Directory:";
            // 
            // txtSrc
            // 
            this.txtSrc.Location = new System.Drawing.Point(129, 22);
            this.txtSrc.Name = "txtSrc";
            this.txtSrc.Size = new System.Drawing.Size(237, 20);
            this.txtSrc.TabIndex = 2;
            // 
            // txtDst
            // 
            this.txtDst.Location = new System.Drawing.Point(129, 61);
            this.txtDst.Name = "txtDst";
            this.txtDst.Size = new System.Drawing.Size(237, 20);
            this.txtDst.TabIndex = 3;
            // 
            // btnSrc
            // 
            this.btnSrc.Location = new System.Drawing.Point(368, 22);
            this.btnSrc.Name = "btnSrc";
            this.btnSrc.Size = new System.Drawing.Size(28, 21);
            this.btnSrc.TabIndex = 4;
            this.btnSrc.Text = "...";
            this.btnSrc.UseVisualStyleBackColor = true;
            this.btnSrc.Click += new System.EventHandler(this.btnSrc_Click);
            // 
            // btnDst
            // 
            this.btnDst.Location = new System.Drawing.Point(369, 61);
            this.btnDst.Name = "btnDst";
            this.btnDst.Size = new System.Drawing.Size(28, 21);
            this.btnDst.TabIndex = 5;
            this.btnDst.Text = "...";
            this.btnDst.UseVisualStyleBackColor = true;
            this.btnDst.Click += new System.EventHandler(this.btnDst_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 163);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(426, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // pgbFiles
            // 
            this.pgbFiles.Location = new System.Drawing.Point(6, 97);
            this.pgbFiles.Name = "pgbFiles";
            this.pgbFiles.Size = new System.Drawing.Size(390, 23);
            this.pgbFiles.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 185);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "PDF Page Deduplicator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeDuplicate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDst;
        private System.Windows.Forms.Button btnSrc;
        private System.Windows.Forms.TextBox txtDst;
        private System.Windows.Forms.TextBox txtSrc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog DlgFolder;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ProgressBar pgbFiles;
    }
}

