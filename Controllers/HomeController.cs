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

    [HttpGet]
    public IActionResult Index()
    {
        string s = "branch";
        int asd = 12;
        int aaa = 10;
        
        return View();
    }
    [HttpPost]
    public IActionResult Index(string adi)
    {
        var x = HttpContext.Request.Form["adi"].ToString();
        string s = adi;
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
