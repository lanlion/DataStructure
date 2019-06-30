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
            this.btn_StartGet = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "网站地址：";
            // 
            // txt_Url
            // 
            this.txt_Url.Location = new System.Drawing.Point(107, 94);
            this.txt_Url.Name = "txt_Url";
            this.txt_Url.Size = new System.Drawing.Size(428, 21);
            this.txt_Url.TabIndex = 1;
            this.txt_Url.Text = "https://www.66law.cn/city/bj.aspx";
            // 
            // btn_StartGet
            // 
            this.btn_StartGet.Location = new System.Drawing.Point(555, 94);
            this.btn_StartGet.Name = "btn_StartGet";
            this.btn_StartGet.Size = new System.Drawing.Size(79, 24);
            this.btn_StartGet.TabIndex = 2;
            this.btn_StartGet.Text = "开抓";
            this.btn_StartGet.UseVisualStyleBackColor = true;
            this.btn_StartGet.Click += new System.EventHandler(this.btn_StartGet_Click);
            // 
            // GetLawyer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 335);
            this.Controls.Add(this.btn_StartGet);
            this.Controls.Add(this.txt_Url);
            this.Controls.Add(this.label1);
            this.Name = "GetLawyer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "抓律师";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Url;
        private System.Windows.Forms.Button btn_StartGet;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
    }
}