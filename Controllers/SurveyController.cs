using Microsoft.AspNetCore.Mvc;

namespace DojoSurvey.Controllers
{
    public class StudentData
{
    public string Name { get; set; }
    public string Location { get; set; }
    public string Language { get; set; }
    public string Comment { get; set; }

    public StudentData()
    {
        Name = "";
        Location = "";
        Language = "";
        Comment = "";
    }
}


    public class SurveyController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View("index");
        }

        [HttpPost("process")]
        public IActionResult Process(string Name, string Location, string Language, string Comment)
        {

            ViewBag.Name = Name;
            ViewBag.Location = Location;
            ViewBag.Language = Language;
            ViewBag.Comment = Comment;

            // To return a view or a redirect
            return RedirectToAction("Display");
        }

        [HttpGet("results")]
        public ViewResult Display()
        {
            return View("display");
        }
    }
}


