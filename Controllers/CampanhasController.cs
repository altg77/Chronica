using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Chronica.Models;

namespace Chronica.Controllers;

public class CampanhasController : Controller
{
    private readonly ILogger<CampanhasController> _logger;

    public CampanhasController(ILogger<CampanhasController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

}

