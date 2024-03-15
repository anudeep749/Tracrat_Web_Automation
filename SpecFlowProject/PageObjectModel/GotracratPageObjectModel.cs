using MongoDB.Driver;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowProject.Utility;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static NUnit.Framework.Constraints.Tolerance;

namespace Gotracrat.POM
{
    public class GotracratPageObjectModel : ControlHelper
    {

        public static string Company;
        public static IWebElement element2;
        public static string xpath1;
        private static string _name;
        public static  string _company;
        public static string _DropDownName;

        //options.AddArguments("--disable-notifications");



        public static void UserLoginWithCredentials()
        {

            _driver.FindElement(By.Name("username")).Click();
            _driver.FindElement(By.Name("username")).SendKeys("ypatel");

            _driver.FindElement(By.Name("password")).SendKeys("tracrat");
            _driver.FindElement(By.XPath("//button[normalize-space(text())='Login']")).Click();

        }


        public static void UserSelects(string DropdownName)
        {
            Thread.Sleep(6000);
            _DropDownName = DropdownName;
            IWebElement selectCompany = _driver.FindElement(By.XPath($"//span[normalize-space(text())='{DropdownName}']"));
            ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].scrollIntoView(true);", selectCompany);
            selectCompany.Click();


        }


        public static void randomClick()
        {

            Thread.Sleep(3000);
            ReadOnlyCollection<IWebElement> elements1 = _driver.FindElements(By.XPath("//ul[contains(@class, 'available-items')]/li"));
            Console.WriteLine(elements1);
            // Check if there are any elements
            if (elements1.Count > 0)
            {
                int maxIndex1 = elements1.Count;
                Random random1 = new Random();
                // Generate a random index within the range [0, maxIndex)
                int randomIndex1 = random1.Next(0, maxIndex1);

                xpath1 = $"//ul[contains(@class, 'available-items')]/li[{randomIndex1 + 1}]";

                //   ScrollToElement(xpath1);

                element2 = _driver.FindElement(By.XPath(xpath1));
                try
                {
                    element2.Click();
                    // PressElement(xpath1);
                    Console.WriteLine($"Clicked on element with random index: {randomIndex1}");
                    // Add additional logic as needed after clicking the element
                }
                catch (NoSuchElementException)
                {
                    // Handle the case where the element with the random index is not found
                }
            }
        }






        public static void TheUserSelectedTheCompanyInTheCompanyList(string company)
        {
            _company = company;
            _driver.FindElement(By.XPath($"//li[normalize-space(text())='{company}']")).Click();

        }





        public static void ManageCompany(string manageCompany)
        {
            Thread.Sleep(6000);
            _driver.FindElement(By.XPath($"//a[contains(., '{manageCompany}')]")).Click();
            //_driver.FindElement(By.XPath($"//a[contains(., 'Manage Companies')]")).Click();

        }


        public static void addCompany(string AddCompany)
        {
            Thread.Sleep(3000);
            _driver.FindElement(By.XPath($"//button[normalize-space(text())='{AddCompany}']")).Click();

        }



        public static void enterText(string name)
        {
            Thread.Sleep(3000);
            _name = name;
            //
            _driver.FindElement(By.XPath("//input[@id='name']")).SendKeys(name);

        }


      

        public static void saveButton()
        {
            Thread.Sleep(3000);
            _driver.FindElement(By.XPath("//button[normalize-space(text())='Save']")).Click();
            

            _driver.Navigate().Refresh();


        }
        public static void userSelectedTheRecentlySelectedCompany()
        {


            _driver.FindElement(By.XPath($"//span[normalize-space(text())='{_DropDownName}']")).Click();
            _driver.FindElement(By.XPath($"//li[normalize-space(text())='{_company}']")).Click();
        }

        public static void TheUserSelectsARandomlyAddedCompany()
        {



            Thread.Sleep(3000);
            
           
            _driver.FindElement(By.XPath(xpath1)).Click();
           
            //element2.Click();

        }


        public static void ClickOnDropdown()
        {
            Thread.Sleep(6000);
            IWebElement selectCompany = _driver.FindElement(By.XPath($"//span[normalize-space(text())='Select Company']"));
            ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].scrollIntoView(true);", selectCompany);
            selectCompany.Click();


        }


        public static void enterTextOnSeatchBar() {


            Thread.Sleep(3000);
            _driver.FindElement(By.XPath("//span[normalize-space(text())='Search :']/following::input[contains(@class, 'ng-pristine')]")).SendKeys(_name);

           }

        public static void ValidationForCompanyName()
        {

            Thread.Sleep(3000);
            IWebElement CompanyXpath = _driver.FindElement(By.XPath("//tr/child::td[1]"));
            string CompanyNameText = CompanyXpath.Text;

            Assert.AreEqual(_name, CompanyNameText);


        }



    }
}
