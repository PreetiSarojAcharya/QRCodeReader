using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using Newtonsoft.Json;
using System.Dynamic;
using Newtonsoft.Json.Converters;

namespace QRCodeReader.Controllers
{
    public class ReadQRCodeController : Controller
    {
        // GET: ReadQRCode
        public ActionResult Index(string jsonReceiverInCsharpObjecName)
        {

          //  dynamic dynData = JsonConvert.DeserializeObject<ExpandoObject>
          //(jsonReceiverInCsharpObjecName, new ExpandoObjectConverter());

          //  foreach (KeyValuePair<string, object> transItem in dynData)
          //  {

          //      if (transItem.Key == "transaction_time")
          //      { }

          //      //else
          //      //do for rest attribute of your json data
          //  }

           // return true;

          return View();
             
        }


         private HttpWebRequest GetRequest(string url, string httpMethod = "GET", bool allowAutoRedirect = true)
        {
            Uri uri = new Uri(url);
            HttpWebRequest request = HttpWebRequest.Create(url) as HttpWebRequest;
            request.UserAgent = @"Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; rv:11.0) like Gecko";
          
            request.Timeout = Convert.ToInt32(new TimeSpan(0, 5, 0).TotalMilliseconds);
                request.Method = httpMethod;
            return request;
        }


        [HttpPost]
        public ActionResult ProcessForm( )
        {
            HttpClient client = new HttpClient();

            ServicePointManager.ServerCertificateValidationCallback = (sender, cert, chain, sslPolicyErrors) => true;
            HttpWebRequest request = this.GetRequest("http://api.qrserver.com/v1/read-qr-code/?fileurl=http%3A%2F%2Fapi.qrserver.com%2Fv1%2Fcreate-qr-code%2F%3Fdata%3DHelloWorld");
            WebResponse webResponse = request.GetResponse();
            var responseText = new StreamReader(webResponse.GetResponseStream()).ReadToEnd();

            return View(responseText);
        }
    }
}