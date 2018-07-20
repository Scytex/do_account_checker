using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using RestSharp;

namespace do_account_checker.Http
{
    internal class WebRequestHandler
    {
        private readonly RestClient _client = new RestClient();

        public IRestResponse Get(string url)
        {
            _client.BaseUrl = new Uri(url);
            var request = new RestRequest(Method.GET);
            request.AddHeader("content-type", "application/x-www-form-urlencoded");

            return _client.Execute(request);
        }

        public IRestResponse Post(string url, params KeyValuePair<string, object>[] parameters)
        {
            _client.BaseUrl = new Uri(url);
            var request = new RestRequest(Method.POST);

            var data = parameters.Aggregate("",
                (current, parameter) => current + $"{parameter.Key}={parameter.Value}&");

            if (data.EndsWith("&"))
            {
                data = data.Substring(0, data.Length - 1);
            }

            request.AddHeader("content-type", "application/x-www-form-urlencoded");
            request.AddParameter("application/x-www-form-urlencoded", data, ParameterType.RequestBody);

            return _client.Execute(request);
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