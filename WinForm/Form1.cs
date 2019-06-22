using com.baidu.ai;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (file_pic.ShowDialog()== DialogResult.OK)
            {
                tbx_pic.Text = file_pic.FileName;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            file_pic.Filter =
@"All Image Files|*.bmp;*.ico;*.gif;*.jpeg;*.jpg;*.png;*.tif;*.tiff|""Windows Bitmap(*.bmp)|*.bmp|""Windows Icon(*.ico)|*.ico|""Graphics Interchange Format (*.gif)|(*.gif)|""JPEG File Interchange Format (*.jpg)|*.jpg;*.jpeg|""Portable Network Graphics (*.png)|*.png|""Tag Image File Format (*.tif)|*.tif;*.tiff";
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            var result = AdvancedGeneral.advancedGeneral(tbx_pic.Text);
            richTxt.AppendText(result);
        }
    }
}
