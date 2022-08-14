using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DemoIdentity.Models;
using DemoIdentity.Data;
using Microsoft.EntityFrameworkCore;

namespace DemoIdentity.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ApplicationDbContext _context;

    public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }
    public async Task<IActionResult> GetAllUser()
    {
        var users = await _context.Users.ToListAsync();
        return View(users);
    }
    public async Task<IActionResult> GetAllRole()
    {
        var roles = await _context.Roles.ToListAsync();
        return View(roles);
    }
    public async Task<IActionResult> GetAllUserRole()
    {
        var userRoles = await _context.UserRoles.ToListAsync();
        return View(userRoles);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
