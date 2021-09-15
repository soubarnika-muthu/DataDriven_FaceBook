using DataDrivenTest_FaceBook.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDrivenTest_FaceBook.Actions
{
   public class DoAction :Base.BaseClass
    {
        public static LoginPage login;

        public static void Assert_Titleof_Webpage()
        {
            string title1 = "Facebook - உள்நுழையவும் அல்லது பதிவுசெய்யவும்";
            string title = driver.Title;
            Assert.AreEqual(title1, title);
        }
       
        /*   public static void ReadingDataFromFile(IWebDriver driver)
           {
               login = new LoginPage(driver);
               ExcelOperations.PopulateInCollection(@"C:\Users\soubarnika.v\source\repos\DataDrivenTest_FaceBook\DataDrivenTest_FaceBook\TestDataFiles\FB_TestData.xlsx");
               Debug.WriteLine("**");
               login.email.SendKeys(ExcelOperations.ReadData(1, "email"));
               System.Threading.Thread.Sleep(2000);

               login.password.SendKeys(ExcelOperations.ReadData(1, "password"));
               System.Threading.Thread.Sleep(2000);

               login.loginbt.Click();
               System.Threading.Thread.Sleep(10000);

           }*/
     
        public static void Login_into_FaceBook()
        {
            ExcelOperations.PopulateInCollection(@"C:\Users\soubarnika.v\source\repos\DataDrivenTest_FaceBook\DataDrivenTest_FaceBook\TestDataFiles\FB_TestData.xlsx");
            Debug.WriteLine("**");
            driver.FindElement(By.Name("email")).SendKeys(ExcelOperations.ReadData(1, "email"));
            System.Threading.Thread.Sleep(2000);

            driver.FindElement(By.Id("pass")).SendKeys(ExcelOperations.ReadData(1, "password"));
            System.Threading.Thread.Sleep(2000);

            driver.FindElement(By.Name("login")).Click();
            System.Threading.Thread.Sleep(10000);

        }
    }
}
