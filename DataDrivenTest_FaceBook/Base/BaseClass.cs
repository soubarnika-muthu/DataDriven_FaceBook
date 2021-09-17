
/*Project:Testing Facebook loginpage using data driven framework
 *Author: Soubarnika Muthu V
 *Date: 13/09/2021
 */
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace DataDrivenTest_FaceBook.Base
{
   public class BaseClass
    {
        //initialization
        public static IWebDriver driver;
        [SetUp]
        public void SetUp()
        {
            //Creating an instance webdriver
            driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com/";
            // To maximize browser
            driver.Manage().Window.Maximize();
           
        }
        [TearDown]
        public void TearDown()
        {
            //closing the browser
            driver.Quit();
        }
    }
}
