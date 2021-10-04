

using DataDrivenTest_FaceBook.Pages;
using OpenQA.Selenium;
using System;
using System.Diagnostics;

namespace DataDrivenTest_FaceBook.Actions
{
    public class NegativeTestCases : Base.BaseClass
    {
        public static LoginPage login;

        public static void Invalid_Password()
        {
            try
            {
                login = new LoginPage(driver);
                //specifying file path
                ExcelOperations.PopulateInCollection(@"C:\Users\soubarnika.v\source\repos\DataDrivenTest_FaceBook\DataDrivenTest_FaceBook\TestDataFiles\FB_TestData.xlsx");
                Debug.WriteLine("**");
                //Reads data from excel file and enters data into webpage using sendkeys method
                login.email.SendKeys(ExcelOperations.ReadData(2, "email"));
                System.Threading.Thread.Sleep(2000);

                login.password.SendKeys(ExcelOperations.ReadData(2, "password"));
                System.Threading.Thread.Sleep(2000);

                //using the click function 
                login.loginbt.Click();
                System.Threading.Thread.Sleep(15000);
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine(ex.Message); ;
            }
        }
    }
}
