using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Chronica.Models;

namespace Chronica.Controllers;

public class ManualController : Controller
{
    private readonly ILogger<ManualController> _logger;

    public ManualController(ILogger<ManualController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View("~/Views/Universe/Manual/Index.cshtml");
    }

}

