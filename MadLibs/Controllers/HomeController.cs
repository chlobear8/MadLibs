using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/form")]
    public ActionResult Form() { return View(); 
    }

    [Route("/madlibsform")] 
      public ActionResult MadLibEntry(string noun1, string noun2, string noun3, string adjective1, string adjective2, string food1, string food2, string verb, string verbing, string body, string color1, string color2) 
      { 
        EntryForm myEntryForm = new EntryForm();
        myEntryForm.Noun1 = noun1;
        myEntryForm.Noun2 = noun2;
        myEntryForm.Noun3 = noun3;
        myEntryForm.Adjective1 = adjective1;
        myEntryForm.Adjective2 = adjective2;
        myEntryForm.Food1 = food1;
        myEntryForm.Food2 = food2;
        myEntryForm.Verb = verb;
        myEntryForm.Verbing = verbing;
        myEntryForm.Color1 = color1;
        myEntryForm.Color2 = color2;
        return View(myEntryForm);
      }
  }
}
