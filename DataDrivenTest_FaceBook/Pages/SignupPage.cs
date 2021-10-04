/*Project:Automation Testing Facebook using selenium
 *Author: Soubarnika Muthu V
 *Date: 13/09/2021
 */
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DataDrivenTest_FaceBook.Pages
{
    public class SignupPage : Base.BaseClass
    {
        //initializing pagefactory method
        public SignupPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        // Using FindBy for locating elements
        //login page
        [FindsBy(How = How.XPath, Using = "//*[@class='_6ltg'][2]")]
        [CacheLookup]
        public IWebElement CreateButton;

        [FindsBy(How = How.Name, Using = "firstname")]
        [CacheLookup]
        public IWebElement FirstName;

        [FindsBy(How = How.Name, Using = "lastname")]
        [CacheLookup]
        public IWebElement LastName;

        [FindsBy(How = How.Name, Using = "reg_email__")]
        [CacheLookup]
        public IWebElement Email;

        [FindsBy(How = How.Name, Using = "reg_email_confirmation__")]
        [CacheLookup]
        public IWebElement ConfirmationEmail;

        [FindsBy(How = How.Name, Using = "reg_passwd__")]
        [CacheLookup]
        public IWebElement Password;

        [FindsBy(How = How.Name, Using = "birthday_day")]
        [CacheLookup]
        public IWebElement Date;

        [FindsBy(How = How.Id, Using = "month")]
        [CacheLookup]
        public IWebElement Month;

        [FindsBy(How = How.Id, Using = "year")]
        [CacheLookup]
        public IWebElement Year;

        [FindsBy(How = How.Name, Using = "sex")]
        [CacheLookup]
        public IWebElement Gender;

        [FindsBy(How = How.Name, Using = "websubmit")]
        [CacheLookup]
        public IWebElement Submit;



    }
}
