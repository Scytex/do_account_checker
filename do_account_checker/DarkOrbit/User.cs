using System.Net;
using do_account_checker.Extensions;
using do_account_checker.Http;

namespace do_account_checker.DarkOrbit
{
    class User
    {
        public string Username { get; set; }
        private string Password;
        Request request = new Request();
        public User(string username, string password)
        {
            Password = password;
            Username = username;
        }

        public bool Login()
        {
            var mainPage = request.Get("https://www.darkorbit.com");
            var authUrl = WebUtility.HtmlDecode(mainPage.Between("class=\"bgcdw_login_form\" action=\"", "\""));

            var result = request.Post(authUrl,
                "username=" + Username + "&password=" + Password);
            return true;
        }
    }
}
