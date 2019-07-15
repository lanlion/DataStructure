﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Common
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
        public WebDriverWait Waiter { get; internal set; }

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
                    Waiter = new WebDriverWait(chromeWebDriver, TimeSpan.FromSeconds(20));
                }
                return chromeWebDriver;
            }
            internal set
            {
                chromeWebDriver = value;
            }
        }
    }

    public static class WebDriverWaitEx
    {
        public static void UntilTrue(this WebDriverWait wait, Func<bool> checkFunction, int maxSeconds = 10)
        {
            DateTime startTime = DateTime.Now;
            while (true)
            {
                var funcResult = false;
                try
                {
                    funcResult = checkFunction();
                }
                catch
                {
                }
                if (funcResult)
                    break;
                if ((DateTime.Now - startTime).TotalSeconds > maxSeconds)
                    throw new TimeoutException("等待超时");
                Thread.Sleep(500);
            }
        }

        public static bool UntilDisappear(this WebDriverWait wait, By by, IWebDriver webDriver, IWebElement parentContainer = null, int maxSecond = 60)
        {
            DateTime startTime = DateTime.Now;
            if (maxSecond <= 0)
                maxSecond = 10;
            while (true)
            {
                var elements = webDriver.FindElements(by);
                //如果找不到该元素
                if (elements.Count == 0)
                    return true;
                //或者只有一个元素，且此元素的display属性还是none
                else if (elements.Count == 1)
                {
                    try
                    {
                        var displayValue = elements.FirstOrDefault().GetCssValue("display");
                        if (displayValue != null && displayValue == "none")
                            return true;
                    }
                    catch (StaleElementReferenceException ex)
                    {//如果出现异常（很有可能StaleElementReferenceException），就跳过本次循环，再重新找一次即可。
                    }
                }

                if ((DateTime.Now - startTime).TotalSeconds > maxSecond)
                    throw new TimeoutException("等待超时");
                Thread.Sleep(500);
            }
        }

        public static IWebElement UntilFindElement(this WebDriverWait wait, By by, ISearchContext searchContext, int maxSecond = 60)
        {
            if (maxSecond <= 0)
                maxSecond = 10;
            DateTime startTime = DateTime.Now;
            while (true)
            {
                try
                {
                    var elements = searchContext.FindElements(by);
                    if (elements.Count > 0)
                        return elements.FirstOrDefault();
                    if ((DateTime.Now - startTime).TotalSeconds > maxSecond)

                        Thread.Sleep(500);
                }
                catch (Exception)
                {
                    break;
                   
                }
              
            }
            return null;
        }
    }
}
