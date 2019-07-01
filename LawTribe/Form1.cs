using AutoUI;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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
        WebDriverWait Waiter;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Catch_Click(object sender, EventArgs e)
        {
            showGetLawyer();
        }

        private void btn_Crm_Click(object sender, EventArgs e)
        {
            if (WebDriver == null)
            {
                WebDriver = WebDriverHelper.Instance.ChromeWebDriver;
                Waiter = WebDriverHelper.Instance.Waiter;
            }

            WebDriver.Navigate().GoToUrl("http://boss.boolaw.com/invitation/shouye?menu=crm");          
            var loginelement = Waiter.UntilFindElement(By.XPath("//h3[text()='企业微信登录']"), WebDriver);
            loginelement.Click();
            Waiter.UntilFindElement(By.XPath("//a[text()='CRM管理']"), WebDriver, 300).Click(); 
            Thread.Sleep(1000);
            WebDriver.Navigate().GoToUrl("http://boss.boolaw.com/invitation/shouye?menu=crm");
            Thread.Sleep(1000);
            IWebElement OneKey;
            while (true)
            {
                WebDriver.Navigate().GoToUrl("http://boss.boolaw.com/lawstore");
                OneKey = Waiter.UntilFindElement(By.XPath("//a[text()='一键接收']"), WebDriver);
                if (OneKey != null)
                {
                    OneKey.Click();
                    Thread.Sleep(1000);
                    var al = WebDriver.SwitchTo().Alert();
                    if (al!=null)
                    {
                        al.Accept();
                    }
                  
                }
                Thread.Sleep(3*60*1000);
               
            }
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

        private void btn_SendMsg_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
