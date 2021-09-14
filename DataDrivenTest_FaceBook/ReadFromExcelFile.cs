using NUnit.Framework;
using OpenQA.Selenium;
using System.Diagnostics;

namespace DataDrivenTest_FaceBook
{
    class ReadFromExcelFile : Base.BaseClass
    {
        [Test]
        public void ReadingData()
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
