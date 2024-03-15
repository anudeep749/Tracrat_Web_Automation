using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using JsonSerializer = System.Text.Json.JsonSerializer;



namespace SpecFlowProject.Utility
{

    public class ControlHelper : ExtentReport
    {

        [ThreadStatic]
        public static IWebDriver _driver;
        public static Dictionary<string, string> data = null!;

        //Initialised the driver from dictionary StoreAdmin_BDD.json file ( Hooks )
        public IWebDriver InitializeDriver(string browser)
        {
            switch (browser.ToUpper())
            {
         //For chrome browser
                case "CHROME":
                    _driver = new ChromeDriver();
                    break;
         //For fire fox browser
                case "FIREFOX":
                    _driver = new FirefoxDriver();
                    break;
         //For edge browser
                case "EDGE":
                    _driver = new EdgeDriver();
                    break;
         // Add more cases for other browsers if needed

                default:
                    throw new ArgumentOutOfRangeException(nameof(browser), browser, null);
            }

            _driver.Manage().Window.Maximize();

           
            _driver.Url = "https://gotracrat.in/#/login";

            return _driver;
        }


        //Code for Click the Element
        public static void PressElement(By locator)
        {

           
            // Wait for the first element to be clickable
             IWebElement initialElement = new WebDriverWait(_driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementToBeClickable(locator));

           
            // Click on the second element using the provided locator
            _driver.FindElement(locator).Click();
        }



        //Code for Enter the Text in the xpath
        public static void EnterText(By locator, string text)
        {
          //  _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement inputField = _driver.FindElement(locator);
            inputField.SendKeys(text);
        }


       //Code for  Clear the text
         public static void ClearTextField(By locator)
            {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement element = _driver.FindElement(locator);
                element.Clear();
            }
        

      //Code for calling the data from json file into dictionary (Stores the data into dictionary)
        public static Dictionary<string, string> WhenTheUserEntersValidCredentialsFromJson()
        {
           string jsonFilePath = "C:\\Users\\Iray Trust\\Desktop\\VsCode\\VSCODE\\SpecFlowProjectSol\\SpecFlowProject\\StoreAdmin_BDD.json";
           string json = File.ReadAllText(jsonFilePath);
            data = new Dictionary<string, string>(JsonSerializer.Deserialize<Dictionary<string, string>>(json));


            return data;

        }
        


        public class UserCredentials : ControlHelper
        {
            public string username { get; set; }
            public string password { get; set; }
        }



    }
}