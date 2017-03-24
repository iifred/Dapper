using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

using fastJSON;

namespace DemoLib.AHInsuranceWeb.Common
{
    public class BasePage:System.Web.UI.Page
    {
        #region json
        public string ToJson(object o)
        {
            return o != null ? fastJSON.JSON.ToJSON(o) : string.Empty;
        }

        public T FromJson<T>(string jsonstr)
        {
            if (string.IsNullOrWhiteSpace(jsonstr))
            {
                return default(T);
            }
            return fastJSON.JSON.ToObject<T>(jsonstr);
        }

        protected void SetEndResponse(string jsonStr)
        {
            HttpContext.Current.Response.ContentType = "text/plain";
            HttpContext.Current.Response.Clear();
            HttpContext.Current.Response.Write(jsonStr);
            HttpContext.Current.Response.End();
        }
        #endregion
        public static CookieContainer cookies = new CookieContainer();
        #region URL请求数据
        /// <summary>
        /// HTTP POST方式请求数据
        /// </summary>
        /// <param name="url">URL.</param>
        /// <param name="param">POST的数据</param>
        /// <returns></returns>
        public static string HttpPost(string url, string param)
        {
            

            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            
            request.Method = "POST";
            request.ContentType = "application/json";
            request.Accept = "*/*";
            request.Timeout = 15000;
            request.AllowAutoRedirect = false;
            request.CookieContainer = cookies;
            //if (HttpContext.Current.Request.Cookies["start"]!=null)
            //{
            //    request.Headers["Set-Cookie"] = HttpContext.Current.Request.Cookies["start"].Value;
            //}
            StreamWriter requestStream = null;
            WebResponse response = null;
            string responseStr = null;

            try
            {
                requestStream = new StreamWriter(request.GetRequestStream());
                requestStream.Write(param);
                requestStream.Close();
                response = request.GetResponse();
                HttpWebResponse myResponse = (HttpWebResponse)request.GetResponse();
                if (response != null)
                {
                    //HttpCookie cookie = new HttpCookie("start");
                    //HttpWebResponse myHttpWebResponse = (HttpWebResponse)request.GetResponse();
                    //CookieCollection myCookieCollection = myHttpWebResponse.Cookies;
                    //cookie.Value = response.Headers["Set-Cookie"].ToString(); 
                    //HttpContext.Current.Response.Cookies.Add(cookie);
                    cookies.Add(myResponse.Cookies);
                    StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                    responseStr = reader.ReadToEnd();
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                request = null;
                requestStream = null;
                response = null;
            }

            return responseStr;
        }

        /// <summary>
        /// HTTP GET方式请求数据.
        /// </summary>
        /// <param name="url">URL.</param>
        /// <returns></returns>
        public static string HttpGet(string url)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            request.Method = "GET";
            //request.ContentType = "application/x-www-form-urlencoded";
            request.Accept = "*/*";
            request.Timeout = 15000;
            request.AllowAutoRedirect = false;

            WebResponse response = null;
            string responseStr = null;

            try
            {
                response = request.GetResponse();

                if (response != null)
                {
                    StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                    responseStr = reader.ReadToEnd();
                    reader.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                request = null;
                response = null;
            }

            return responseStr;
        }
        #endregion

        /// <summary>
        /// 获取客户端真实IP
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public static string GetRealIPAddress(HttpRequest request)
        {
            return string.IsNullOrEmpty(request.Headers.Get("X-Real-IP")) ? request.UserHostAddress : request.Headers["X-Real-IP"];
        }

        /// <summary>
        /// 支持多级代码获取客户端请求第一个IP
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public static string GetRemoteHost(HttpRequest request)
        {
            string ip = request.Headers.Get("x-forwarded-for");
            if (string.IsNullOrWhiteSpace(ip) || "unknown".Equals(ip, StringComparison.CurrentCultureIgnoreCase))
            {
                ip = request.Headers.Get("Proxy-Client-IP");
            }
            if (string.IsNullOrWhiteSpace(ip) || "unknown".Equals(ip, StringComparison.CurrentCultureIgnoreCase))
            {
                ip = request.Headers.Get("WL-Proxy-Client-IP");
            }
            if (string.IsNullOrWhiteSpace(ip) || "unknown".Equals(ip, StringComparison.CurrentCultureIgnoreCase))
            {
                ip = request.Headers.Get("HTTP_CLIENT_IP");
            }
            if (string.IsNullOrWhiteSpace(ip) || "unknown".Equals(ip, StringComparison.CurrentCultureIgnoreCase))
            {
                ip = GetRealIPAddress(request);
            }

            if (ip.Contains(','))
            {
                ip = ip.Split(',')[0];
            }

            return ip;
        }
    }
}