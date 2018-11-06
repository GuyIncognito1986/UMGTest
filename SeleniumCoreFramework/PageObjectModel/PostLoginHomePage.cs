using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumCoreFramework.PageObjectModel
{
    public class PostLoginHomePage: BasePage
    {
        public PostLoginHomePage(IWebDriver driver) : base(driver, _uriBuilder.PostLoginHomePage, By.ClassName("user-pic"))
        {
            OpenQA.Selenium.Support.PageObjects.PageFactory.InitElements(driver, this);
            
        }

        public bool UserNameIsPresent(string username)
        {
            var waitForElement = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(10));
            waitForElement.Until(ExpectedConditions.ElementExists(By.ClassName("tag-list")));
            return _webDriver.PageSource.Contains(username);
        }
    }
}
