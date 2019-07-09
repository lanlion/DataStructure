using Common;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LawTribe
{
    public partial class GetLawyer : Form
    {
        IWebDriver WebDriver = WebDriverHelper.Instance.ChromeWebDriver;
        public GetLawyer()
        {
            InitializeComponent();
        }

        private void btn_HomePage_Click(object sender, EventArgs e)
        {
            Go();
        }

        private void Go()
        {
            if (!string.IsNullOrEmpty(txt_Url.Text))
            {
                WebDriver.Navigate().GoToUrl(txt_Url.Text);
            }
            else
            {
                MessageBox.Show("请输入地址");
                return;
            }
        }
        
    }
}
