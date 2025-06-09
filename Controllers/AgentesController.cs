using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Chronica.Models;

namespace Chronica.Controllers;

public class AgentesController : Controller
{
    private readonly ILogger<AgentesController> _logger;

    public AgentesController(ILogger<AgentesController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

     public IActionResult CriarAgente()
    {
        return View();
    }
}
