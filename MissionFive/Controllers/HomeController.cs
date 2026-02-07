using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MissionFive.Models;

namespace MissionFive.Controllers;

public class HomeController : Controller
{
    // Hobby page
    public IActionResult Index()
    {
        return View();
    }

    // Tutor cost calculator page
    public IActionResult Calculator()
    {
        return View();
    }

    // Error page
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel
        {
            RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
        });
    }
}