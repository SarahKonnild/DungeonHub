using Microsoft.AspNetCore.Mvc;

namespace DungeonHub.Web.Controllers;

public class CharacterController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}