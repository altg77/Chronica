using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Chronica.Models;

namespace Chronica.Controllers;

public class ItensController : Controller
{
    private readonly ILogger<ItensController> _logger;

    public ItensController(ILogger<ItensController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View("~/Views/Universe/itens/Index.cshtml");
    }




}
