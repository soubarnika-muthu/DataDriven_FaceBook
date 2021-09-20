/*Project:Automation Testing Facebook using selenium
 *Author: Soubarnika Muthu V
 *Date: 13/09/2021
 */
using DataDrivenTest_FaceBook.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Diagnostics;
using AutoItX3Lib;


namespace DataDrivenTest_FaceBook.Actions
{
    public class DoAction : Base.BaseClass
    {
        public static LoginPage login;

        //Method to check title of webpage
        public static void Assert_Titleof_Webpage()
        {
            string title1 = "Facebook - உள்நுழையவும் அல்லது பதிவுசெய்யவும்";
            string title = driver.Title;
            Assert.AreEqual(title1, title);
        }

        public static void Login_into_Facebook(IWebDriver driver)
        {
           
           
            login = new LoginPage(driver);
            //specifying file path
            ExcelOperations.PopulateInCollection(@"C:\Users\soubarnika.v\source\repos\DataDrivenTest_FaceBook\DataDrivenTest_FaceBook\TestDataFiles\FB_TestData.xlsx");
            Debug.WriteLine("**");
            //Reads data from excel file and enters data into webpage using sendkeys method
            login.email.SendKeys(ExcelOperations.ReadData(1, "email"));
            System.Threading.Thread.Sleep(2000);

            login.password.SendKeys(ExcelOperations.ReadData(1, "password"));
            System.Threading.Thread.Sleep(2000);

            //using the click function 
            login.loginbt.Click();
            System.Threading.Thread.Sleep(10000);

            //calling takescreenshot method
            Takescreenshot();
            //performing keyboard actions
            KeyboardEvents.PerformKeyboardActions();

        }
        public static void UploadFile()
        {
            Login_into_Facebook(driver);
            //Upload a file 
            login.home.Click();
            System.Threading.Thread.Sleep(3000);
            login.upload.Click();
            System.Threading.Thread.Sleep(3000);
            login.photo.Click();
            System.Threading.Thread.Sleep(3000);
            login.plus.Click();
            System.Threading.Thread.Sleep(3000);

            //Using autoit to upload an image
            //Creating instance of AutoItX3 class
            AutoItX3 autoIt = new AutoItX3();
            //Activating file upload window
            autoIt.WinActivate("Open");
            System.Threading.Thread.Sleep(3000);
            //Sending the file path 
            autoIt.Send(@"C:\Users\soubarnika.v\Downloads\img.jfif");
            System.Threading.Thread.Sleep(3000);
            autoIt.Send("{ENTER}");
            System.Threading.Thread.Sleep(3000);

            login.comments.SendKeys("Doremon pic");
            System.Threading.Thread.Sleep(3000);
            //Clicking upload button 
            login.uploadbt.Click();
            System.Threading.Thread.Sleep(10000);
            Takescreenshot();
        }

        public static void Takescreenshot()
        {
            ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
            Screenshot screenshot = screenshotDriver.GetScreenshot();
            screenshot.SaveAsFile(@"C:\Users\soubarnika.v\source\repos\DataDrivenTest_FaceBook\DataDrivenTest_FaceBook\Screenshot\ " + DateTime.Now.ToString("HHmmss") + ".png");
        }

    }
}
