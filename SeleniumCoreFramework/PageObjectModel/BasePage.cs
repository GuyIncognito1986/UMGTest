using OpenQA.Selenium;
using SeleniumCoreFramework.Framework;

namespace SeleniumCoreFramework.PageObjectModel
{
    public class BasePage
    {
        protected readonly IWebDriver _webDriver;
        protected static readonly UrlBuilder _uriBuilder = new UrlBuilder();
        protected readonly string _uriOfPage;
        protected readonly By _validationElementLocator;
        protected BasePage(IWebDriver webDriver, string pUri, By validationElementLocator)
        {
            _webDriver = webDriver;
            _uriOfPage = pUri;
            _validationElementLocator = validationElementLocator;
        }

        public void NavigateToPage()
        {
            _webDriver.Navigate().GoToUrl(_uriOfPage);
        }

        public void Validate()
        {
            _webDriver.FindElement(_validationElementLocator);
        }
    }
}
