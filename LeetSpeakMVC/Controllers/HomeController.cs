using Microsoft.AspNetCore.Mvc;
using LeetSpeakMVC.Models;

namespace LeetSpeakMVC.Controllers
{
    public class HomeController : Controller
    {
      [Route("/")]
      public ActionResult Form()
      {
        return View();
      }

      [Route("/Translate")]
      public ActionResult Translate()
      {
        LeetSpeak newLeet = new LeetSpeak();
        newLeet.SetInput(Request.Query["newInput"]);
        return View(newLeet);
      }
    }
}
