using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MeuMVP.Data; 
using MeuMVP.Models;
using Microsoft.EntityFrameworkCore;

namespace MeuMVP.Controllers;

public class HomeController : ApplicationController
{
    private readonly ILogger<HomeController> _logger;
    private readonly MeuMVPContext _context; 

    public HomeController(ILogger<HomeController> logger, MeuMVPContext context) 
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    public async Task<IActionResult> Landing()
    {
        var eventos = await _context.Eventos
            .OrderBy(e => e.DataHora)
            .ToListAsync();

        return View(eventos);
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
