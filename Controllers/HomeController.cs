// This brings all the MVC features we need to this file
using Microsoft.AspNetCore.Mvc;
// Be sure to use your own project's namespace here! 
namespace DojoSurvey.Controllers;
public class HomeController : Controller   // Remember inheritance?    
{
    [HttpGet] // We will go over this in more detail on the next page    
    [Route("/test")] // We will go over this in more detail on the next page
    public string Index()
    {
        return "Hello World from HelloController!";
    }
}

