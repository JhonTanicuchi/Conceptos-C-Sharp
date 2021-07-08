using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebApplicationTwo.Data;
using WebApplicationTwo.Entities;

namespace WebApplicationTwo.Controllers
{
    public class ArbolesController : Controller
    {
        private readonly MainContext _mainContext;
        public ArbolesController(MainContext mainContext)
        {
            _mainContext = mainContext;
        }

        public IActionResult Index()
        {
            return View(_mainContext.Arboles.Where(a => a.ColorHoja != "Morado").OrderBy(a=>a.Nombre).ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Arbol arbol)
        {
            _mainContext.Add(arbol);
            var filasAfectadas = _mainContext.SaveChanges();
            if (filasAfectadas > 0)
                return RedirectToAction("Index");
            
            return View("Error");
        }
    }
}