/*Project:Automation Testing Facebook using selenium
 *Author: Soubarnika Muthu V
 *Date: 13/09/2021
 */

using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace DataDrivenTest_FaceBook
{
    [TestFixture("chrome")]
   // [TestFixture("firefox")]
    //[Parallelizable(ParallelScope.Fixtures)]
    public class Tests : Base.BaseClass
    {
        public Tests(string browsername) : base(browsername)
        {
        }

        ExtentReports reports = ReportClass.Start_Report();
        ExtentTest test;
        [Test, Order(0)]
        public void Test__LoginPage()
        {
            test = reports.CreateTest("Tests");
            test.Log(Status.Info, "Automation FaceBook");
            //performing Test
            Actions.DoAction.Assert_Titleof_Webpage();
            Actions.DoAction.Login_into_Facebook(driver);
            //Actions.DoAction.UploadFile();
            Takescreenshot();
            test.Info("ScreenShot", MediaEntityBuilder.CreateScreenCaptureFromPath(@"C:\Users\soubarnika.v\source\repos\DataDrivenTest_FaceBook\DataDrivenTest_FaceBook\Screenshot\Login_SC.png").Build());
            test.Log(Status.Pass, "Test Passes");
            reports.Flush();
            String actualUrl = "https://www.facebook.com/?sk=welcome";
            String expectedUrl = driver.Url;
            //Assert.AreEqual(actualUrl, expectedUrl);
            if (expectedUrl.Equals(actualUrl))
            {
                Console.WriteLine("Login Successful");
            }
            else
            {
                Console.WriteLine("Login Failed");
            }
        }
        [Test,Order(1)]
        public void Test_SearchingMethod()
        {
            Actions.DoAction.Search_In_Facebook();
            String actualUrl = "https://www.facebook.com/search/top?q=tvs%20next";
            String expectedUrl = driver.Url;
            //Assert.AreEqual(actualUrl, expectedUrl);
            if (expectedUrl.Equals(actualUrl))
            {
                Console.WriteLine("Search Successful");
            }
            else
            {
                Console.WriteLine("Search Failed");
            }
        }
        [Test, Order(2)]
        public void Test_UploadingFile()
        {
            Actions.DoAction.UploadFile();
            //Assert.IsTrue(driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[3]/div[1]/div[3]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/span[1]/h4[1]/span[1]/a[1]/strong[1]/span[1]")).Displayed);
            IWebElement element = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[3]/div[1]/div[3]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/span[1]/h4[1]/span[1]/a[1]/strong[1]/span[1]"));
            if(element.Displayed)
            {
                Console.WriteLine("File Uploaded Successfully");
            }
            else
            {
                Console.WriteLine("File Upload Failed");
            }
        }
        [Test, Order(3)]
        public void Test_Logout()
        {
            Actions.DoAction.Logout_from_Facebook(driver);
           // Assert.IsTrue(driver.Url.Contains("stype"));
            IWebElement element = driver.FindElement(By.XPath("//body[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/form[1]/div[2]/button[1]"));
            if (element.Displayed)
            {
                Console.WriteLine("Logged out Successfully");
            }
            else
            {
                Console.WriteLine("Logout Failed");
            }
        }

        [Test, Order(4)]
        public void Test_SendEmail()
        {
            Email.EmailClass.ReadDataFromExcel();
            Email.EmailClass.email_send();
        }
        [Test, Order(5)]
        public void Test_Invalid_Password()
        {
            Actions.NegativeTestCases.Invalid_Password();
            string expectedmsg = "நீங்கள் உள்ளிட்ட கடவுச்சொல் தவறானது. கடவுச்சொல்லை மறந்துவிட்டீர்களா?";
            string actual = driver.FindElement(By.ClassName("_9ay7")).Text;
            Console.WriteLine("Error Message: {0}", actual);
            if (expectedmsg.Equals(actual))
            {
                Console.WriteLine("Given Error Message: {0}", actual);
            }
            else
            {
                Console.WriteLine("Testcase Failed");
            }
        }
        [Test]
        public void Test_EndtoEnd()
        {
            Actions.DoAction.EndtoEnd_Testing();
            //Assert.IsTrue(driver.FindElement(By.XPath("//body[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/form[1]/div[2]/button[1]")).Displayed);
        }
    }
}