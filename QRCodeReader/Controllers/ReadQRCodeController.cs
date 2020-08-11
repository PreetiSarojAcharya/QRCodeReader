using System.Web.Mvc;

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