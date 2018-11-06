using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCoreFramework.Framework
{
    public class WebDriver : IDisposable
    {
        public enum Browser { Edge, Chrome, FireFox }
        public IWebDriver Driver { get; }

        public WebDriver(Browser b)
        {
            switch(b)
            {
                case Browser.Chrome: Driver = new ChromeDriver();
                    break;
                default: throw new NotImplementedException($"Driver for {b.ToString()}");
            }
        }

        #region IDisposable Support
        private bool disposedValue = false; 

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                Driver.Close();
                Driver.Dispose();
                disposedValue = true;
            }
        }
       
        ~WebDriver() {
           Dispose(false);
         }

        public void Dispose()
        {
            Dispose(true);
        }
        #endregion
    }
}
