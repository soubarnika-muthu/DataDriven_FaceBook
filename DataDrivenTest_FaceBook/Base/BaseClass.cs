
/*Project:Testing Facebook loginpage using data driven framework
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

        [SetUp]
        public void SetUp()
        {
            // Valid XML file with Log4Net Configurations
            var fileInfo = new FileInfo(@"Log4net.config");

            // Configure default logging repository with Log4Net configurations
            log4net.Config.XmlConfigurator.Configure(repository, fileInfo);
            log.Info("Entering Setup");
            //Creating an instance webdriver
            driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com/";
            // To maximize browser
            driver.Manage().Window.Maximize();
            log.Debug("navigating to url");

            log.Info("Exiting setup");

        }
        [TearDown]
        public void TearDown()
        {
            //closing the browser
            driver.Quit();
        }
    }
}
