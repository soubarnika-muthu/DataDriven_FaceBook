/*Project:Automation Testing Facebook using selenium
 *Author: Soubarnika Muthu V
 *Date: 13/09/2021
 */
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DataDrivenTest_FaceBook.Pages
{
    public class LoginPage : Base.BaseClass
    {
        //initializing pagefactory method
        public LoginPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        // Using FindBy for locating elements
        //login page
        [FindsBy(How = How.Name, Using = "email")]
        [CacheLookup]
        public IWebElement email;

        [FindsBy(How = How.Id, Using = "pass")]
        [CacheLookup]
        public IWebElement password;

        [FindsBy(How = How.Name, Using = "login")]
        [CacheLookup]
        public IWebElement loginbt;

        [FindsBy(How = How.XPath, Using = "//body[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/label[1]/input[1]")]
        [CacheLookup]
        public IWebElement searchbar;


    }
}
