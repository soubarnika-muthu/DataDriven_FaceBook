/*Project:Automation Testing Facebook using selenium
 *Author: Soubarnika Muthu V
 *Date: 13/09/2021
 */
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using System;
using System.IO;

namespace DataDrivenTest_FaceBook
{
   public class ReportClass
    {
        //Instance of extents reports
        public static ExtentHtmlReporter htmlReporter;
        // create ExtentReports and attach reporter(s)
        public static ExtentReports extent;
        public static ExtentTest test;

        public static ExtentReports Start_Report()
        {
            if (extent == null)
            {
                //current solution report path
                string reportPath = @"C:\Users\soubarnika.v\source\repos\DataDrivenTest_FaceBook\DataDrivenTest_FaceBook\Reports\Report.html";
                htmlReporter = new ExtentHtmlReporter(reportPath);
                extent = new ExtentReports();
                extent.AttachReporter(htmlReporter);
                extent.AddSystemInfo("OS", "Windows");
                extent.AddSystemInfo("UserName", "Soubarnika");
                extent.AddSystemInfo("ProviderName", "Soubarnika");
                extent.AddSystemInfo("Domain", "QA");
                extent.AddSystemInfo("ProjectName", "FaceBook Automation");
                //Adding config.xml file
                string conifgPath = @"C:\Users\soubarnika.v\source\repos\DataDrivenTest_FaceBook\DataDrivenTest_FaceBook\Reports\Report-Config.xml";
                htmlReporter.LoadConfig(conifgPath);


            }
            return extent;
        }

        
    }
}
