using SeleniumCoreFramework.Framework;
using System;

namespace SeleniumCoreFramework.PageObjectModel
{
    public class PageFactory
    {
        private readonly WebDriver _webDriver;
        public PageFactory(WebDriver driver)
        {
            _webDriver = driver;
        }

        public BasePage Build<T>() where T: BasePage
        {
            if(typeof(T) == typeof(PostLoginHomePage))
            {
                return new PostLoginHomePage(_webDriver.Driver);
            }
            if (typeof(T) == typeof(SignUpPage))
            {
                return new SignUpPage(_webDriver.Driver);
            }
            throw new NotImplementedException($"The page object for {typeof(T)} has not been implemented yet!");
        }
    }
}
