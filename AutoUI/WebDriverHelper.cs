using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoUI
{
    public class WebDriverHelper
    {
        private WebDriverHelper() { }
        private static WebDriverHelper _instance = new WebDriverHelper();
        public static WebDriverHelper Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new WebDriverHelper();
                }
                return _instance;
            }
        }
        private IWebDriver chromeWebDriver;

        public IWebDriver ChromeWebDriver
        {
            get
            {
                if (chromeWebDriver == null)
                {
                    ChromeOptions chromeOptions = new ChromeOptions();
                    chromeOptions.AddArgument("--start-maximized");
                    ////忽略Https证书不存在的错误，有助于加快Https页面加载速度
                    //options.AddArgument("--ignore-certificate-errors");
                    chromeWebDriver = new ChromeDriver(chromeOptions);
                    //webDriver.Manage().Window.Maximize();
                }
                return chromeWebDriver;
            }
            internal set
            {
                chromeWebDriver = value;
            }
        }
    }
}
