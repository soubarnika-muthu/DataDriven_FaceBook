using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDrivenTest_FaceBook.Pages
{
  public  class UploadFile : Base.BaseClass
    {
        public void Uploadfile_InApp()
        {
            driver.FindElement(By.ClassName("a8c37x1j ni8dbmo4 stjgntxs l9j0dhe7 ltmttdrg g0qnabr5 ojkyduve")).Click();
            IWebElement upload = driver.FindElement(By.ClassName("bp9cbjyn j83agx80 taijpn5t c4xchbtz by2jbhx6 a0jftqn4"));
            upload.SendKeys(@"C:\Users\soubarnika.v\Desktop\Rose.png");

        }


        }
    }
