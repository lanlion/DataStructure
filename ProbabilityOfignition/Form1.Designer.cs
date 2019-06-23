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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.lbl_title = new System.Windows.Forms.Label();
            this.txt_Pressure = new System.Windows.Forms.TextBox();
            this.lbl_Pressure = new System.Windows.Forms.Label();
            this.txt_PODIOutdoor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Temperature = new System.Windows.Forms.TextBox();
            this.tab_Level = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txt_PONI = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_AIT = new System.Windows.Forms.TextBox();
            this.txt_POII = new System.Windows.Forms.TextBox();
            this.txt_PODIIndoor = new System.Windows.Forms.TextBox();
            this.cmb_Chemical = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MIE = new System.Windows.Forms.TextBox();
            this.txt_POSI = new System.Windows.Forms.TextBox();
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
            this.splitContainer.Panel1.Controls.Add(this.lbl_title);
            this.splitContainer.Panel1.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.txt_Pressure);
            this.splitContainer.Panel2.Controls.Add(this.lbl_Pressure);
            this.splitContainer.Panel2.Controls.Add(this.txt_PODIOutdoor);
            this.splitContainer.Panel2.Controls.Add(this.label9);
            this.splitContainer.Panel2.Controls.Add(this.txt_Temperature);
            this.splitContainer.Panel2.Controls.Add(this.tab_Level);
            this.splitContainer.Panel2.Controls.Add(this.txt_PONI);
            this.splitContainer.Panel2.Controls.Add(this.label8);
            this.splitContainer.Panel2.Controls.Add(this.label4);
            this.splitContainer.Panel2.Controls.Add(this.label7);
            this.splitContainer.Panel2.Controls.Add(this.label2);
            this.splitContainer.Panel2.Controls.Add(this.txt_AIT);
            this.splitContainer.Panel2.Controls.Add(this.txt_POII);
            this.splitContainer.Panel2.Controls.Add(this.txt_PODIIndoor);
            this.splitContainer.Panel2.Controls.Add(this.cmb_Chemical);
            this.splitContainer.Panel2.Controls.Add(this.label1);
            this.splitContainer.Panel2.Controls.Add(this.label6);
            this.splitContainer.Panel2.Controls.Add(this.label5);
            this.splitContainer.Panel2.Controls.Add(this.label3);
            this.splitContainer.Panel2.Controls.Add(this.txt_MIE);
            this.splitContainer.Panel2.Controls.Add(this.txt_POSI);
            this.splitContainer.Size = new System.Drawing.Size(1195, 619);
            this.splitContainer.SplitterDistance = 79;
            this.splitContainer.SplitterWidth = 3;
            this.splitContainer.TabIndex = 0;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("仿宋", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_title.Location = new System.Drawing.Point(467, 28);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(236, 27);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "点火概率计算工具";
            // 
            // txt_Pressure
            // 
            this.txt_Pressure.Location = new System.Drawing.Point(222, 256);
            this.txt_Pressure.Name = "txt_Pressure";
            this.txt_Pressure.Size = new System.Drawing.Size(204, 21);
            this.txt_Pressure.TabIndex = 23;
            this.txt_Pressure.TextChanged += new System.EventHandler(this.txt_Pressure_TextChanged);
            // 
            // lbl_Pressure
            // 
            this.lbl_Pressure.AutoSize = true;
            this.lbl_Pressure.Location = new System.Drawing.Point(175, 259);
            this.lbl_Pressure.Name = "lbl_Pressure";
            this.lbl_Pressure.Size = new System.Drawing.Size(41, 12);
            this.lbl_Pressure.TabIndex = 22;
            this.lbl_Pressure.Text = "压力：";
            // 
            // txt_PODIOutdoor
            // 
            this.txt_PODIOutdoor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_PODIOutdoor.Location = new System.Drawing.Point(610, 256);
            this.txt_PODIOutdoor.Name = "txt_PODIOutdoor";
            this.txt_PODIOutdoor.Size = new System.Drawing.Size(204, 21);
            this.txt_PODIOutdoor.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(509, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 12);
            this.label9.TabIndex = 20;
            this.label9.Text = "延迟引燃-室外：";
            // 
            // txt_Temperature
            // 
            this.txt_Temperature.Location = new System.Drawing.Point(222, 207);
            this.txt_Temperature.Name = "txt_Temperature";
            this.txt_Temperature.Size = new System.Drawing.Size(204, 21);
            this.txt_Temperature.TabIndex = 9;
            this.txt_Temperature.TextChanged += new System.EventHandler(this.txt_Temperature_TextChanged);
            // 
            // tab_Level
            // 
            this.tab_Level.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_Level.Controls.Add(this.tabPage1);
            this.tab_Level.Controls.Add(this.tabPage2);
            this.tab_Level.Controls.Add(this.tabPage3);
            this.tab_Level.ItemSize = new System.Drawing.Size(96, 27);
            this.tab_Level.Location = new System.Drawing.Point(3, 17);
            this.tab_Level.Name = "tab_Level";
            this.tab_Level.SelectedIndex = 0;
            this.tab_Level.Size = new System.Drawing.Size(1190, 34);
            this.tab_Level.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tab_Level.TabIndex = 0;
            this.tab_Level.SelectedIndexChanged += new System.EventHandler(this.tab_Level_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1182, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Level1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1182, 0);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Level2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1182, 0);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Level3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txt_PONI
            // 
            this.txt_PONI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_PONI.Location = new System.Drawing.Point(610, 124);
            this.txt_PONI.Name = "txt_PONI";
            this.txt_PONI.Size = new System.Drawing.Size(204, 21);
            this.txt_PONI.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(509, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 18;
            this.label8.Text = "立即引燃：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "温度：";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(509, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "自然引燃：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "材料：";
            // 
            // txt_AIT
            // 
            this.txt_AIT.Location = new System.Drawing.Point(222, 169);
            this.txt_AIT.Name = "txt_AIT";
            this.txt_AIT.Size = new System.Drawing.Size(204, 21);
            this.txt_AIT.TabIndex = 7;
            this.txt_AIT.TextChanged += new System.EventHandler(this.txt_AIT_TextChanged);
            // 
            // txt_POII
            // 
            this.txt_POII.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_POII.Location = new System.Drawing.Point(610, 169);
            this.txt_POII.Name = "txt_POII";
            this.txt_POII.Size = new System.Drawing.Size(204, 21);
            this.txt_POII.TabIndex = 13;
            // 
            // txt_PODIIndoor
            // 
            this.txt_PODIIndoor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_PODIIndoor.Location = new System.Drawing.Point(610, 207);
            this.txt_PODIIndoor.Name = "txt_PODIIndoor";
            this.txt_PODIIndoor.Size = new System.Drawing.Size(204, 21);
            this.txt_PODIIndoor.TabIndex = 17;
            // 
            // cmb_Chemical
            // 
            this.cmb_Chemical.FormattingEnabled = true;
            this.cmb_Chemical.Location = new System.Drawing.Point(222, 89);
            this.cmb_Chemical.Name = "cmb_Chemical";
            this.cmb_Chemical.Size = new System.Drawing.Size(204, 20);
            this.cmb_Chemical.TabIndex = 4;
            this.cmb_Chemical.SelectedIndexChanged += new System.EventHandler(this.cmb_Chemical_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "AIT：";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(509, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "静态引燃：";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(509, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "延迟引燃-室内：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "MIE：";
            // 
            // txt_MIE
            // 
            this.txt_MIE.Location = new System.Drawing.Point(222, 124);
            this.txt_MIE.Name = "txt_MIE";
            this.txt_MIE.Size = new System.Drawing.Size(204, 21);
            this.txt_MIE.TabIndex = 5;
            this.txt_MIE.TextChanged += new System.EventHandler(this.txt_MIE_TextChanged);
            // 
            // txt_POSI
            // 
            this.txt_POSI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_POSI.Location = new System.Drawing.Point(610, 89);
            this.txt_POSI.Name = "txt_POSI";
            this.txt_POSI.Size = new System.Drawing.Size(204, 21);
            this.txt_POSI.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 619);
            this.Controls.Add(this.splitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_Chemical;
        private System.Windows.Forms.TextBox txt_AIT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MIE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Temperature;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox txt_PONI;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_PODIIndoor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_POSI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_POII;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_PODIOutdoor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Pressure;
        private System.Windows.Forms.Label lbl_Pressure;
    }
}

