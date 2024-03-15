using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Text.Json;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using SpecFlowProject.Hook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JsonSerializer = System.Text.Json.JsonSerializer;
using BoDi;
using System.ComponentModel;
using SpecFlowProject.Utility;
namespace StoreAdmin_BDD.Utility
{
    public class JavaScriptExecutor : ControlHelper
    {


        public  void ClickElementByJavaScript(By locator)
        {
            IWebElement element = _driver.FindElement(locator);

            // Use JavaScriptExecutor to perform the click
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)_driver;
            jsExecutor.ExecuteScript("arguments[0].click();", element);
        }


        //Java Script code for Scroll to element
        public  void ScrollToElement(By locator)
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            IWebElement element = _driver.FindElement(locator);
            if (element is IJavaScriptExecutor)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
            }
        }



        //JavaScript code for enter text 
        public  void jsEnterText(By locator, string text)
        {
            IWebElement inputField = _driver.FindElement(locator);
            if (inputField is IJavaScriptExecutor)
            {
                ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].value = arguments[1];", inputField, text);
            }
            else
            {
                inputField.SendKeys(text);
            }
        }




    }
}
