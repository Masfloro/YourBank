using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using YourBank.Data;
using YourBank.Models;
using YourBank.Models.Entity;

namespace YourBank.Controllers;

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

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult ListadoCuentas()
    {

        var cuentassss = from o in _context.DataCuentas select o;

        return View(cuentassss.ToList());
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    [HttpPost]
    public IActionResult Create([Bind("Nombre,TipoCuenta, SaldoInicial, Correo")] Cuentas cuenta)
    {
        if (ModelState.IsValid)
        {
            _context.DataCuentas.Add(cuenta);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        _context.DataCuentas.Add(cuenta);
        _context.SaveChanges();
        return View("~/Views/Home/Index.cshtml");
    }



}
