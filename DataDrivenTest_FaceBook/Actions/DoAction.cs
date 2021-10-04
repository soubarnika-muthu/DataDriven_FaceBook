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
using OpenQA.Selenium.Support.UI;

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
            try
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
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void Logout_from_Facebook(IWebDriver driver)
        {
            try
            {
                //calling login method
                Login_into_Facebook(driver);
                //creating object of logout class
                Logout logout = new Logout(driver);
                logout.menu.Click();
                System.Threading.Thread.Sleep(4000);
                //using the click function 
                logout.logoutbt.Click();
                System.Threading.Thread.Sleep(4000);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public static  void Search_In_Facebook()
        {
            try
            {
                Login_into_Facebook(driver);
                LoginPage search = new LoginPage(driver);
                search.searchbar.SendKeys("tvs next");
                System.Threading.Thread.Sleep(2000);
                //using keys to perform keyboard actions 
                search.searchbar.SendKeys(Keys.ArrowDown);
                System.Threading.Thread.Sleep(1000);
                Takescreenshot();           
                search.searchbar.SendKeys(Keys.Enter);
                System.Threading.Thread.Sleep(6000);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void UploadFile()
        {
            try
            {
                //calling login method
                Login_into_Facebook(driver);
                UploadFilePage upload = new UploadFilePage(driver);
                //Upload a file 
                upload.home.Click();
                System.Threading.Thread.Sleep(3000);
                upload.upload.Click();
                System.Threading.Thread.Sleep(3000);
                upload.photo.Click();
                System.Threading.Thread.Sleep(3000);
                upload.plus.Click();
                System.Threading.Thread.Sleep(3000);
                //Using autoit to upload an image
                //Creating instance of AutoItX3 class
                AutoItX3 autoIt = new AutoItX3();
                //Activating file upload window
                autoIt.WinActivate("Open");
                System.Threading.Thread.Sleep(2000);
                //Sending the file path 
                autoIt.Send(@"C:\Users\soubarnika.v\Downloads\img.jfif");
                System.Threading.Thread.Sleep(2000);
                autoIt.Send("{ENTER}");
                System.Threading.Thread.Sleep(3000);
                upload.comments.SendKeys("Doremon pic");
                System.Threading.Thread.Sleep(3000);
                Takescreenshot();
                //Clicking upload button 
                upload.uploadbt.Click();
                System.Threading.Thread.Sleep(8000);
               

            }
            catch (Exception ex)
            {
               Console.WriteLine(ex.ToString());
            }
        }

        public static void SignUp_intofacebook(IWebDriver driver)
        {
            //specifying file path
            ExcelOperations.PopulateInCollection(@"C:\Users\soubarnika.v\source\repos\DataDrivenTest_FaceBook\DataDrivenTest_FaceBook\TestDataFiles\FB_TestData.xlsx");
            Debug.WriteLine("**");
            //creating object of signup page
            SignupPage signup = new SignupPage(driver);

            signup.CreateButton.Click();
            System.Threading.Thread.Sleep(4000);

            signup.FirstName.SendKeys(ExcelOperations.ReadData(1, "firstname"));
            System.Threading.Thread.Sleep(4000);

            signup.LastName.SendKeys(ExcelOperations.ReadData(1, "lastname"));
            System.Threading.Thread.Sleep(4000);

            signup.Email.SendKeys(ExcelOperations.ReadData(1, "regemail"));
            System.Threading.Thread.Sleep(4000);

            signup.ConfirmationEmail.SendKeys(ExcelOperations.ReadData(1, "regemail"));
            System.Threading.Thread.Sleep(4000);

            signup.Password.SendKeys(ExcelOperations.ReadData(1, "regpwd"));
            System.Threading.Thread.Sleep(4000);

            //using select commands
            SelectElement element = new SelectElement(signup.Date);
            element.SelectByText("8");
            System.Threading.Thread.Sleep(4000);

            SelectElement element1 = new SelectElement(signup.Month);
            element1.SelectByValue("4");
            System.Threading.Thread.Sleep(4000);

            SelectElement element2 = new SelectElement(signup.Year);
            element2.SelectByValue("1999");
            System.Threading.Thread.Sleep(4000);

            signup.Gender.Click();
            System.Threading.Thread.Sleep(4000);

            // signup.Submit.Click();
            System.Threading.Thread.Sleep(2000);
        }
        public static void EndtoEnd_Testing()
        {
            try
            {
                //calling other methods to perform end to end testing
                Login_into_Facebook(driver);
                UploadFile();
                Logout_from_Facebook(driver);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
