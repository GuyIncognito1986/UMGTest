using SeleniumCoreFramework.Framework;
using SeleniumCoreFramework.PageObjectModel;

namespace SpecflowTests.ContextBuilders
{
    public class Context
    {
        public static readonly Context Current;
        public PageFactory PageFactory { get; }

        public Context(WebDriver.Browser b)
        {
            PageFactory = new PageFactory(new WebDriver(b));
        }
        static Context()
        {
            Current = new Context(WebDriver.Browser.Chrome);
        }
    }
}
