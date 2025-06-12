using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Chronica.Models;

namespace Chronica.Controllers;

public class VantagenseDesvantagensController : Controller
{
    private readonly ILogger<VantagenseDesvantagensController> _logger;

    public VantagenseDesvantagensController(ILogger<VantagenseDesvantagensController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View("~/Views/Universe/VantagenseDesvantagens/Index.cshtml");
    }

}

