namespace ProbabilityOfignition
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.tab_Level = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.radioBtn_US = new System.Windows.Forms.RadioButton();
            this.radioBtn_Metric = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_Chemical = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.tab_Level.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.cmb_Chemical);
            this.splitContainer.Panel1.Controls.Add(this.label2);
            this.splitContainer.Panel1.Controls.Add(this.label1);
            this.splitContainer.Panel1.Controls.Add(this.radioBtn_Metric);
            this.splitContainer.Panel1.Controls.Add(this.radioBtn_US);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.tab_Level);
            this.splitContainer.Size = new System.Drawing.Size(1195, 619);
            this.splitContainer.SplitterDistance = 56;
            this.splitContainer.SplitterWidth = 3;
            this.splitContainer.TabIndex = 0;
            // 
            // tab_Level
            // 
            this.tab_Level.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_Level.Controls.Add(this.tabPage1);
            this.tab_Level.Controls.Add(this.tabPage2);
            this.tab_Level.Controls.Add(this.tabPage3);
            this.tab_Level.Location = new System.Drawing.Point(3, -4);
            this.tab_Level.Name = "tab_Level";
            this.tab_Level.SelectedIndex = 0;
            this.tab_Level.Size = new System.Drawing.Size(1189, 666);
            this.tab_Level.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tab_Level.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1181, 640);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Level1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1181, 639);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Level2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1181, 639);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Level3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // radioBtn_US
            // 
            this.radioBtn_US.AutoSize = true;
            this.radioBtn_US.Location = new System.Drawing.Point(61, 23);
            this.radioBtn_US.Name = "radioBtn_US";
            this.radioBtn_US.Size = new System.Drawing.Size(47, 16);
            this.radioBtn_US.TabIndex = 0;
            this.radioBtn_US.Text = "U.S.";
            this.radioBtn_US.UseVisualStyleBackColor = true;
            // 
            // radioBtn_Metric
            // 
            this.radioBtn_Metric.AutoSize = true;
            this.radioBtn_Metric.Checked = true;
            this.radioBtn_Metric.Location = new System.Drawing.Point(114, 23);
            this.radioBtn_Metric.Name = "radioBtn_Metric";
            this.radioBtn_Metric.Size = new System.Drawing.Size(59, 16);
            this.radioBtn_Metric.TabIndex = 1;
            this.radioBtn_Metric.TabStop = true;
            this.radioBtn_Metric.Text = "Metric";
            this.radioBtn_Metric.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "单位：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "材料：";
            // 
            // cmb_Chemical
            // 
            this.cmb_Chemical.FormattingEnabled = true;
            this.cmb_Chemical.Location = new System.Drawing.Point(237, 19);
            this.cmb_Chemical.Name = "cmb_Chemical";
            this.cmb_Chemical.Size = new System.Drawing.Size(136, 20);
            this.cmb_Chemical.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 619);
            this.Controls.Add(this.splitContainer);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "点火概率计算工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.tab_Level.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TabControl tab_Level;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioBtn_Metric;
        private System.Windows.Forms.RadioButton radioBtn_US;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_Chemical;
    }
}

