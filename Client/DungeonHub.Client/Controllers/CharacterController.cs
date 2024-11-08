using DungeonHub.Backend.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DungeonHub.Client.Controllers;

public class CharacterController(IRepository repository) : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}