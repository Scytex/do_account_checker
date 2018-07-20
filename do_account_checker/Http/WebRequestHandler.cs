using System;
using System.IO;
using System.Net;
using RestSharp;

namespace do_account_checker.Http
{
    internal class WebRequestHandler
    {
        private readonly RestClient _client = new RestClient();
        private string _content;
        /// <summary>
        /// Logs into Account using Username & Password
        /// </summary>
        /// <param name="username">DO Username</param>
        /// <param name="password">DO Password</param>
        /// <returns>Login successful</returns>
        public bool LoginToAccount(string username, string password)
        {
            _client.BaseUrl = new Uri($"https://sas.bpsecure.com/Sas/Authentication/Bigpoint?authUser=22&token={GetToken()}");
            var request = new RestRequest(Method.POST);

            request.AddHeader("content-type", "application/x-www-form-urlencoded");
            request.AddParameter("application/x-www-form-urlencoded", $"username={username}&password={password}", ParameterType.RequestBody);

            var response = _client.Execute(request);
            _content = response.Content;

            return response.ResponseUri.AbsoluteUri.Contains("indexInternal.es");
        }

        public string GetContent()
        {
            return _content;
        }

        public string GetUridium()
        {
            const string start1 =
                "<a id=\"header_uri\" class=\"header_money\"";
            const string start3 = ");\"";
            string start2 = GetStringBetween(_content, start1, start3);

            var start = start1 + start2 + start3;
            var end = "</a>";

            var uridium = GetStringBetween(_content, start, end);
            return uridium.Replace(" ", "").Replace(">", "").Replace("\n", "");
        }

        private static string GetToken()
        {
            var request = (HttpWebRequest)WebRequest.Create(new Uri("http://www.darkorbit.de/"));
            request.Method = WebRequestMethods.Http.Get;
            var response = (HttpWebResponse)request.GetResponse();
            var responseStream = response.GetResponseStream();
            var reader = new StreamReader(responseStream ?? throw new InvalidOperationException()); //TODO Exception
            var responseString = reader.ReadToEnd();

            return GetToken(responseString);
        }

        private static string GetToken(string source)
        {
            const string start = "class=\"bgcdw_login_form\" action=\"https://sas.bpsecure.com/Sas/Authentication/Bigpoint?authUser=22&amp;token=";
            const string end = "\"";
            return GetStringBetween(source, start, end);
        }

        private static string GetStringBetween(string text, string start, string end)
        {
            var startIndex = text.IndexOf(start, 0, StringComparison.Ordinal) + start.Length;
            var endIndex = text.IndexOf(end, startIndex, StringComparison.Ordinal);
            return text.Substring(startIndex, endIndex - startIndex);
        }
    }
}