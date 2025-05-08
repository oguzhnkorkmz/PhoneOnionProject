using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Onion.ApplicationLayer.Services.TelefonService;
using Onion.InfrastructureLayer;
using Onion.UI.MVC_Core.Models;

namespace Onion.UI.MVC_Core.Controllers;

public class HomeController : Controller
{
    private readonly ITelefonService telefonService;

    public HomeController(ITelefonService telefonService)
    {
        this.telefonService = telefonService;
    }

    public async Task<IActionResult> Index()
    {
        return View(await telefonService.TumTelefonlarAsync());
    }

    public async Task<IActionResult> Detay(int id)
    {
        return View(await telefonService.TelefonDetayAsync(id));
    }

    public IActionResult Privacy()
    {
        return View();
    }

    
}
