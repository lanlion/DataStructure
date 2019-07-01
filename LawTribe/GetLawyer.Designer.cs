namespace LawTribe
{
    partial class GetLawyer
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Url = new System.Windows.Forms.TextBox();
            this.btn_HomePage = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.btn_District = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "66law网站：";
            // 
            // txt_Url
            // 
            this.txt_Url.Location = new System.Drawing.Point(108, 15);
            this.txt_Url.Name = "txt_Url";
            this.txt_Url.Size = new System.Drawing.Size(526, 21);
            this.txt_Url.TabIndex = 1;
            this.txt_Url.Text = "https://www.66law.cn/city/bj.aspx";
            // 
            // btn_HomePage
            // 
            this.btn_HomePage.Location = new System.Drawing.Point(823, 9);
            this.btn_HomePage.Name = "btn_HomePage";
            this.btn_HomePage.Size = new System.Drawing.Size(114, 52);
            this.btn_HomePage.TabIndex = 2;
            this.btn_HomePage.Text = "首页抓取";
            this.btn_HomePage.UseVisualStyleBackColor = true;
            this.btn_HomePage.Click += new System.EventHandler(this.btn_HomePage_Click);
            // 
            // btn_District
            // 
            this.btn_District.Location = new System.Drawing.Point(943, 9);
            this.btn_District.Name = "btn_District";
            this.btn_District.Size = new System.Drawing.Size(106, 52);
            this.btn_District.TabIndex = 3;
            this.btn_District.Text = "区域抓取";
            this.btn_District.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.btn_HomePage);
            this.splitContainer1.Panel1.Controls.Add(this.btn_District);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txt_Url);
            this.splitContainer1.Size = new System.Drawing.Size(1181, 698);
            this.splitContainer1.SplitterDistance = 65;
            this.splitContainer1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1055, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 52);
            this.button1.TabIndex = 4;
            this.button1.Text = "抓取当前页-手动";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // GetLawyer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 698);
            this.Controls.Add(this.splitContainer1);
            this.Name = "GetLawyer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "抓律师";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Url;
        private System.Windows.Forms.Button btn_HomePage;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Button btn_District;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button1;
    }
}