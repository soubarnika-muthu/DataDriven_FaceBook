using OpenQA.Selenium;

using SeleniumExtras.PageObjects;

namespace DataDrivenTest_FaceBook.Pages
{
    public class LoginPage:Base.BaseClass
    {
        public LoginPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        //To locate the webelement 
        [FindsBy(How = How.Name, Using = "email")]
        [CacheLookup]
        public IWebElement email;

        [FindsBy(How = How.Id, Using = "pass")]
        [CacheLookup]
        public IWebElement password;

        [FindsBy(How = How.Name, Using = "login")]
        [CacheLookup]
        public IWebElement loginbt;
    }
}
