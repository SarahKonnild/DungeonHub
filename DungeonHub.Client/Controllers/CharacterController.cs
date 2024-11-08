using DungeonHub.Backend.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DungeonHub.Web.Controllers;

public class CharacterController(IRepository repository) : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}