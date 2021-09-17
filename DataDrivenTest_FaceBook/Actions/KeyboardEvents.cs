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
            //finds the element using id
            IWebElement myelement = driver.FindElement(By.Name("pass"));
            //myelement.SendKeys(Keys.Control + "a");
            
            myelement.SendKeys(Keys.Home);
            System.Threading.Thread.Sleep(2000);
            myelement.SendKeys(Keys.End);
            System.Threading.Thread.Sleep(2000);
            myelement.SendKeys(Keys.ArrowDown);
            // Enter text  and perform keyboard action "Enter"
            myelement.SendKeys("9629522931");
            System.Threading.Thread.Sleep(2000);
            myelement.SendKeys(Keys.Enter);

            System.Threading.Thread.Sleep(2000);
        }
    }
}
