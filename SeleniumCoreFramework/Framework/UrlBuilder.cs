using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;

namespace SeleniumCoreFramework.Framework
{
    public class UrlBuilder
    {
        public enum Env { Test, Prod};
        private readonly IReadOnlyDictionary<Env, string> _baseUrls = new Dictionary<Env, string>()
        {
            { Env.Test, "http://localhost:4000/#!/" },
            { Env.Prod, "https://angularjs.realworld.io/#/" }
        };
        private readonly Env _env;
        public string SignUpPage => UriAppender("register");
        public string SignInPage => UriAppender("login");
        public string PostLoginHomePage => UriAppender("");

        public UrlBuilder()
        {
            var envVal = new CultureInfo("en-GB").TextInfo.ToTitleCase(ConfigurationManager.AppSettings["Mode"]);
            _env = (Env)Enum.Parse(typeof(Env), envVal);
        }

        private string UriAppender(string path)
        {
            return $"{_baseUrls[_env]}{path}";
        }
    }
}
