using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using do_account_checker.Extensions;
using do_account_checker.Http;
using System.Net;

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
