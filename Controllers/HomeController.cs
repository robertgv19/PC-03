using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PC_03.Models;

namespace PC_03.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly WebAppContext _context;

        public HomeController(ILogger<HomeController> logger, WebAppContext context)
        {
            _context = context;
            _logger = logger;

        }

        public IActionResult Index()
        {
            var productos = _context.Productos.ToList();
            return View(productos);
        }

        [HttpPost]
        public IActionResult Eliminar(int id){
            var productos = _context.Productos.FirstOrDefault(x => x.id == id);
            _context.Remove(productos);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
         public IActionResult Producto()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Producto(Productos p)
        {

            if(ModelState.IsValid){
                _context.Add(p);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(p);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
