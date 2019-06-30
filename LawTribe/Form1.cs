using AutoUI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LawTribe
{
    public partial class Form1 : Form
    {
        public static GetLawyer getLawyer;
        IWebDriver WebDriver;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (WebDriver == null)
            {
                WebDriver = WebDriverHelper.Instance.ChromeWebDriver;
            }

            WebDriver.Navigate().GoToUrl("http://boss.boolaw.com/invitation/shouye?menu=crm");
            Thread.Sleep(1000);
            var loginelement = WebDriver.FindElement(By.XPath("//h3[text()='企业微信登录']"));
            loginelement.Click();
        }

        private void showGetLawyer()
        {
            if (getLawyer == null)
            {
                getLawyer = new LawTribe.GetLawyer();
                getLawyer.Show();
            }
            else
            {
                getLawyer.Activate();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
