using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Chronica.Models;

namespace Chronica.Controllers;

public class AmeacasController : Controller
{
    private readonly ILogger<AmeacasController> _logger;

    public AmeacasController(ILogger<AmeacasController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

}

