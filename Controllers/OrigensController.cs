using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Chronica.Models;

namespace Chronica.Controllers;

public class OrigensController : Controller
{
    private readonly ILogger<OrigensController> _logger;

    public OrigensController(ILogger<OrigensController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View("~/Views/Universe/Origens/Index.cshtml");
    }

}

