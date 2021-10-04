using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DataDrivenTest_FaceBook.Pages
{
    public class Logout : Base.BaseClass
    {
        //initializing pagefactory method
        public Logout(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        // Using FindBy for locating elements
    
        [FindsBy(How = How.XPath, Using = "//body[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[4]/div[1]/span[1]/div[1]/div[1]")]
        [CacheLookup]
        public IWebElement menu;

        [FindsBy(How = How.XPath, Using = "//body[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[4]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/div[4]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/span[1]")]
        [CacheLookup]
        public IWebElement logoutbt;

        [FindsBy(How = How.Name, Using = "login")]
        [CacheLookup]
        public IWebElement loginbt;


    }
}
