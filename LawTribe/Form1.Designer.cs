namespace LawTribe
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Crm = new System.Windows.Forms.Button();
            this.btn_Catch = new System.Windows.Forms.Button();
            this.btn_SendMsg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Crm
            // 
            this.btn_Crm.Location = new System.Drawing.Point(106, 123);
            this.btn_Crm.Name = "btn_Crm";
            this.btn_Crm.Size = new System.Drawing.Size(102, 61);
            this.btn_Crm.TabIndex = 0;
            this.btn_Crm.Text = "自动一键接收";
            this.btn_Crm.UseVisualStyleBackColor = true;
            this.btn_Crm.Click += new System.EventHandler(this.btn_Crm_Click);
            // 
            // btn_Catch
            // 
            this.btn_Catch.Location = new System.Drawing.Point(260, 123);
            this.btn_Catch.Name = "btn_Catch";
            this.btn_Catch.Size = new System.Drawing.Size(102, 61);
            this.btn_Catch.TabIndex = 1;
            this.btn_Catch.Text = "页面抓取";
            this.btn_Catch.UseVisualStyleBackColor = true;
            this.btn_Catch.Click += new System.EventHandler(this.btn_Catch_Click);
            // 
            // btn_SendMsg
            // 
            this.btn_SendMsg.Location = new System.Drawing.Point(418, 123);
            this.btn_SendMsg.Name = "btn_SendMsg";
            this.btn_SendMsg.Size = new System.Drawing.Size(102, 61);
            this.btn_SendMsg.TabIndex = 2;
            this.btn_SendMsg.Text = "短信群发";
            this.btn_SendMsg.UseVisualStyleBackColor = true;
            this.btn_SendMsg.Click += new System.EventHandler(this.btn_SendMsg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 361);
            this.Controls.Add(this.btn_SendMsg);
            this.Controls.Add(this.btn_Crm);
            this.Controls.Add(this.btn_Catch);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "律师助手";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Crm;
        private System.Windows.Forms.Button btn_Catch;
        private System.Windows.Forms.Button btn_SendMsg;
    }
}

