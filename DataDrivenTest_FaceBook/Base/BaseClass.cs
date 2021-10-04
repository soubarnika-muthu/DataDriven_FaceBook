/*Project:Automation Testing Facebook using selenium
 *Author: Soubarnika Muthu V
 *Date: 13/09/2021
 */
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using log4net;
using System;
using log4net.Repository;
using System.Reflection;
using System.IO;
using OpenQA.Selenium.Firefox;

namespace DataDrivenTest_FaceBook.Base
{
    public class BaseClass
    {
        //initialization
        public static IWebDriver driver;
        //Get Logger for fully qualified name for type of 'Tests'
        private static readonly ILog log = LogManager.GetLogger(typeof(Tests));

        //Get the default ILoggingRepository
        private static readonly ILoggerRepository repository = log4net.LogManager.GetRepository(Assembly.GetCallingAssembly());

        protected string browser;

        //default constructor
        public BaseClass()
        {

        }
        //parameterized constructor
        public BaseClass(string browser)
        {
            this.browser = browser;
        }


        [SetUp]
        public void BrowserTest()
        {

            var fileInfo = new FileInfo(@"Log4net.config");

            // Configure default logging repository with Log4Net configurations
            log4net.Config.XmlConfigurator.Configure(repository, fileInfo);
            log.Info("Entering Setup");
            try
            {

                switch (browser)
                {

                    case "chrome":
                        //Creating an instance of chrome webdriver
                        ChromeOptions options = new ChromeOptions();
                        options.AddArguments("--disable-notifications");
                        driver = new ChromeDriver(options);
                        break;
                    case "firefox":
                        //Creating an instance of firefox webdriver
                        FirefoxOptions options1 = new FirefoxOptions();
                        options1.AddArguments("--disable-notifications");
                        driver = new FirefoxDriver();
                        break;
                    default:
                        driver = new ChromeDriver();
                        break;
                }
                //print which browser is started
                Console.WriteLine(browser + " Started");

                log.Debug("navigating to url");
                driver.Url = "https://www.facebook.com/";
                // To maximize browser
                driver.Manage().Window.Maximize();


                log.Info("Exiting setup");
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
            }

        }
        //method to take screeshot
        public static void Takescreenshot()
        {
            ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
            Screenshot screenshot = screenshotDriver.GetScreenshot();
            screenshot.SaveAsFile(@"C:\Users\soubarnika.v\source\repos\DataDrivenTest_FaceBook\DataDrivenTest_FaceBook\Screenshot\ " + DateTime.Now.ToString("HHmmss") + ".png");
        }
        [TearDown]
        public void TearDown()
        {
            //closing the browser
            driver.Quit();
        }
    }
}
