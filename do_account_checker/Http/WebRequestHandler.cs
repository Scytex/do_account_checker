using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using RestSharp;

namespace do_account_checker.Http
{
    public class WebRequestHandler
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
    }
}