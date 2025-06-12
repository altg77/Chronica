using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Chronica.Models;

namespace Chronica.Controllers;

public class RacasController : Controller
{
    private readonly ILogger<RacasController> _logger;

    public RacasController(ILogger<RacasController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View("~/Views/Universe/Racas/Index.cshtml");
    }

}

