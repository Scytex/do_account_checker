using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using do_account_checker.Extensions;
using do_account_checker.Http;
using RestSharp.Extensions;

namespace do_account_checker.DarkOrbit
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; }
        private readonly WebRequestHandler _webRequestHandler = new WebRequestHandler();
        private string _content = "";
        private string _uri = "";
        private bool _loggedIn = false;

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

        public string Server => _uri.GetBetween("//", ".");

        public string Level =>
            _content.GetBetween("header_top_level", "</div>").GetBetween("<span>", "</span>");

        public string Experience => _content.GetBetween("header_top_exp", "</div>").GetBetween("<span>", "</span>");

        public string Honor => _content.GetBetween("header_top_hnr", "</div>").GetBetween("<span>", "</span>");

        public string Rank => _content.GetBetween("userRankIcon", "</div>").GetBetween(">", "\n").Remove(0,1);

        public string RankImageUrl => _content.GetBetween("<img id=\"userRankIcon\" src=\"", ">");

        public string CollectDaily()
        {
            if (!_loggedIn)
                Login();
            var response = _webRequestHandler.Get("https://" + Server + ".darkorbit.com/flashAPI/dailyLogin.php?doBook").Content;

            switch (response)
            {
                case "{\"isError\":1,\"error\":{\"message\":\"Already booked today\"}}":
                    return "Already booked";
                case "{\"success\":true}":
                    return "Booked";
            }

            return "Failed";
        }

        public bool Login()
        {
            var mainPage = _webRequestHandler.Get("https://www.darkorbit.com").Content;
            var authUrl = WebUtility.HtmlDecode(mainPage.GetBetween("class=\"bgcdw_login_form\" action=\"", "\""));

            var response = _webRequestHandler.Post(authUrl, new KeyValuePair<string, object>("username", Username), new KeyValuePair<string, object>("password", Password));
            _content = response.Content;
            _uri = response.ResponseUri.AbsoluteUri;
            var status = _uri.Contains("indexInternal.es");
            _loggedIn = status;
            return status;
        }
    }
}
