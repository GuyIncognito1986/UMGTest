using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumCoreFramework.DataBuilders.TestPocos;

namespace SeleniumCoreFramework.PageObjectModel
{
    public class SignUpPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//*[@placeholder='Username']")]
        [CacheLookup]
        private IWebElement Username { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@placeholder='Password']")]
        [CacheLookup]
        private IWebElement Password { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@placeholder='Email']")]
        [CacheLookup]
        private IWebElement Email { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Sign up')]")]
        [CacheLookup]
        private IWebElement SignUpButton { get; set; }

        public SignUpPage(IWebDriver driver): base(driver, _uriBuilder.SignUpPage, By.XPath("//button[contains(text(),'Sign up')]"))
        {
            OpenQA.Selenium.Support.PageObjects.PageFactory.InitElements(driver, this);  
        }

        public void FillInForm(UserDetailsPoco userDetails)
        {
            Username.SendKeys(userDetails.Username);
            Password.SendKeys(userDetails.Password);
            Email.SendKeys(userDetails.Email);
        }

        public void SubmitForm()
        {
            SignUpButton.Click();
        }
    }
}
