using System.Collections.Generic;
using System.Net;
using do_account_checker.Extensions;
using do_account_checker.Http;

namespace do_account_checker.DarkOrbit
{
    public class User
    {
        public string Username { get; set; }
        private string Password { get; }
        private readonly WebRequestHandler _webRequestHandler = new WebRequestHandler();
        private string _content = "";
        public User(string username, string password)
        {
            Password = password;
            Username = username;
        }

        // TODO: Make this an int
        public string Uridium
        {
            get
            {
                if (_content == "")
                    return "0";
                const string start1 = "<a id=\"header_uri\" class=\"header_money\"";
                const string start3 = ");\"";
                var start2 = _content.GetBetween(start1, start3);

                var start = start1 + start2 + start3;
                const string end = "</a>";

                var uridium = _content.GetBetween(start, end);
                return uridium.Replace(" ", "").Replace(">", "").Replace("\n", "");
            }
        }

        public string UserId => _content.GetBetween("<span>", "</span>");

        public string Credits => _content.GetBetween("class=\"header_money\">", "</div>").Trim();

        public bool Login()
        {
            var mainPage = _webRequestHandler.Get("https://www.darkorbit.com").Content;
            var authUrl = WebUtility.HtmlDecode(mainPage.GetBetween("class=\"bgcdw_login_form\" action=\"", "\""));

            var response = _webRequestHandler.Post(authUrl, new KeyValuePair<string, object>("username", Username), new KeyValuePair<string, object>("password", Password));
            _content = response.Content;
            return response.ResponseUri.AbsoluteUri.Contains("indexInternal.es");
        }
    }
}
