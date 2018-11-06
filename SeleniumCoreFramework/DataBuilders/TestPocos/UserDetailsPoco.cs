using System;

namespace SeleniumCoreFramework.DataBuilders.TestPocos
{
    public class UserDetailsPoco
    {
        public string Username { get; }
        public string Password { get; }
        public string Email { get; }

        public UserDetailsPoco(string username, string password, string email)
        {
            Username = username;
            Password = password;
            Email = email;
        }

        public static UserDetailsPoco Random(int maxChars)
        {
            return new UserDetailsPoco(GetMaxCharRandomString(maxChars), GetMaxCharRandomString(maxChars), $"{GetMaxCharRandomString(maxChars)}@test.com");
        }

        private static string GetMaxCharRandomString(int maxChars)
        {
            return Guid.NewGuid().ToString().Substring(0, maxChars);
        }
    }
}
