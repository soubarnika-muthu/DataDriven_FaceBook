/*Project:Automation Testing Facebook using selenium
 *Author: Soubarnika Muthu V
 *Date: 13/09/2021
 */

using AventStack.ExtentReports;
using log4net;
using NUnit.Framework;

namespace DataDrivenTest_FaceBook
{
   
    public class Tests : Base.BaseClass
    {
        
        ExtentReports reports = ReportClass.Start_Report();
        ExtentTest test;
        [Test]
        public void Test__LoginPage()
        {
            test = reports.CreateTest("Tests");
            test.Log(Status.Info, "Automation FaceBook");

            //performing Test
            Actions.DoAction.Assert_Titleof_Webpage();
           // Actions.DoAction.Login_into_Facebook(driver);
            Actions.DoAction.UploadFile();

            test.Log(Status.Pass, "Test Passes");
            reports.Flush();


        }

    }
}