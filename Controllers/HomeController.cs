using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DictionaryGame.Models;

namespace DictionaryGame.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        string s = "branch";
        return View();
    }

    public IActionResult Privacy()
    {
        int i= 5;
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
