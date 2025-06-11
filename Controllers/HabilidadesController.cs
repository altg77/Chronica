using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Chronica.Models;

namespace Chronica.Controllers;

public class HabilidadesController : Controller
{
    private readonly ILogger<HabilidadesController> _logger;

    public HabilidadesController(ILogger<HabilidadesController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View("~/Views/Universe/Habilidades/Index.cshtml");
    }
    
}

