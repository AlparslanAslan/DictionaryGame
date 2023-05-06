using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DictionaryGame.Models;
using DictionaryGame.Database;

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
        return View();
    }

    [HttpPost]
    public IActionResult Index(string adi)
    {
        var x = HttpContext.Request.Form["adi"].ToString();
        string s = adi;
        return View();
    }
    [HttpGet]
    public IActionResult ReadArticle()
    {
        return View();
    }
    [HttpGet]
    public IActionResult FindDefinitions()
    {
        return View();
    }
    [HttpGet]
    public IActionResult TestGame()
    {
        DbConnection dbo = new DbConnection();
        IEnumerable<EnglishWord> listOfWord = dbo.GetWords();
        
        return View(listOfWord);
    }

    public IActionResult Privacy()
    {
        
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
