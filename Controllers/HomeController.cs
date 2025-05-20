using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MeuMVP.Models;

namespace MeuMVP.Controllers;

public class HomeController : ApplicationController // herda do novo controller base
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View(); // usará _HomeLayout.cshtml
    }

    public IActionResult Privacy()
    {
        return View(); // usará _HomeLayout.cshtml
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
