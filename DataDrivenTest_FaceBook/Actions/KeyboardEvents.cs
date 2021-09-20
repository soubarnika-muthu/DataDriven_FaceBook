using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDrivenTest_FaceBook.Actions
{
   public  class KeyboardEvents:Base.BaseClass
    {
        public static void PerformKeyboardActions()
        {
            //finds the element using path
            IWebElement myelement = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/label[1]/input[1]"));
            myelement.SendKeys("s");
           System.Threading.Thread.Sleep(2000);
            myelement.SendKeys(Keys.ArrowDown);
            System.Threading.Thread.Sleep(2000);
            myelement.SendKeys(Keys.Enter);
            System.Threading.Thread.Sleep(2000);
        }
    }
}
