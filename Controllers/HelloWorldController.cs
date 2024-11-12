using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace test_web_app_mvc_dotNET.Controllers
{
    public class HelloWorldController : Controller
    {
        //GET: /HelloWorld
        public IActionResult Index()
        {
            return View();
        }

        //GET: /HelloWorld/Welcome

        [HttpGet("HelloWorld/Welcome/{name?}")]
        public IActionResult Welcome(string name)
        {
            if(string.IsNullOrEmpty(name)) {
                ViewData["Message"] = "Benvenuto, Ospite!";
            } else {
                ViewData["Message"] = "Benvenuto " + name;
            }
                return View();

        }





    }
}