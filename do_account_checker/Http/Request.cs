using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace do_account_checker.Http
{
    class Request
    {
        private CookieContainer cookieContainer = new CookieContainer();
        private string referer = string.Empty;
        public string Get(string url)
        {
            var request = WebRequest.CreateHttp(url);
            request.UserAgent =
                "Mozilla/5.0 (Windows NT 6.3; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/67.0.3396.99 Safari/537.36";
            request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
            request.KeepAlive = true;
            request.Method = "GET";
            request.CookieContainer = cookieContainer;
            request.ContentType = "application/x-www-form-urlencoded";
            request.Referer = referer;
            request.Proxy = new WebProxy();

            var response = (HttpWebResponse)request.GetResponse();
            var responseStream = response.GetResponseStream();
            if (responseStream == null)
                return "";
            var sr = new StreamReader(responseStream);
            var serverResponse = sr.ReadToEnd();
            sr.Close();
            response.Close();
            referer = url;

            return serverResponse;
        }

        public string Post(string url, string data)
        {
            var request = WebRequest.CreateHttp(url);
            request.Method = "POST";
            request.CookieContainer = cookieContainer;
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.3; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/67.0.3396.99 Safari/537.36";
            request.ContentType = "application/x-www-form-urlencoded";
            request.Proxy = new WebProxy();
            request.Referer = referer;
            request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8";
            request.KeepAlive = true;
            request.AllowAutoRedirect = false;
            request.PreAuthenticate = true;
            var buffer = Encoding.UTF8.GetBytes(data);
            request.ContentLength = buffer.Length;
            using (var stream = request.GetRequestStream())
            {
                stream.Write(buffer, 0, buffer.Length);
            }

            referer = url;

            using (var response = request.GetResponse())
            {
                using (var responseStream = response.GetResponseStream())
                {
                    if (responseStream == null)
                        return "";
                    using (var streamReader = new StreamReader(responseStream))
                    {
                        return streamReader.ReadToEnd();
                    }
                }
            }
        }
    }
}
