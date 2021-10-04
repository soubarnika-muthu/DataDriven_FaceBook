/*Project:Automation Testing Facebook using selenium
 *Author: Soubarnika Muthu V
 *Date: 13/09/2021
 */
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DataDrivenTest_FaceBook.Pages
{
    public class UploadFilePage:Base.BaseClass
    {
        public UploadFilePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        //Upload a file
        [FindsBy(How = How.XPath, Using = "//body[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[3]/div[1]/div[1]/div[1]/ul[1]/li[1]/span[1]/div[1]/a[1]")]
        [CacheLookup]
        public IWebElement home;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Venkat, உங்கள் மனதில் என்ன உள்ளது?')]")]
        [CacheLookup]
        public IWebElement upload;

        [FindsBy(How = How.XPath, Using = "//body[1]/div[1]/div[1]/div[1]/div[1]/div[4]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/form[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/div[2]/div[1]/div[1]/div[1]/span[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/i[1]")]
        [CacheLookup]
        public IWebElement photo;

        [FindsBy(How = How.XPath, Using = "//body[1]/div[1]/div[1]/div[1]/div[1]/div[4]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/form[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/i[1]")]
        [CacheLookup]
        public IWebElement plus;


        [FindsBy(How = How.XPath, Using = "//body[1]/div[1]/div[1]/div[1]/div[1]/div[4]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/form[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]")]    
        [CacheLookup]
        public IWebElement comments;


        [FindsBy(How = How.XPath, Using = "//body[1]/div[1]/div[1]/div[1]/div[1]/div[4]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/form[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[2]/div[1]/div[1]/div[1]/div[1]/span[1]/span[1]")]
        [CacheLookup]
        public IWebElement uploadbt;

    }
}
