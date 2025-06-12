using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Chronica.Models;

namespace Chronica.Controllers;

public class ClasseController : Controller
{
    private readonly ILogger<ClasseController> _logger;

    public ClasseController(ILogger<ClasseController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }


}

