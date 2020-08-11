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
          return View();          
        }     
             
    }
}