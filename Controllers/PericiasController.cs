using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Chronica.Models;

namespace Chronica.Controllers;

public class PericiasController : Controller
{
    private readonly ILogger<PericiasController> _logger;

    public PericiasController(ILogger<PericiasController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View("~/Views/Universe/Pericias/Index.cshtml");
    }


}
