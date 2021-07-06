using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationOne.Controllers
{
    public class CalculadoraController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calcular(int numero_1, int numero_2)
        {
            //TODO: Como acceder a Request.Form desde asp.net core
            var numero_1FromBody = int.Parse(Request.Form["numero_1"]); 
            var numero_2FromBody = int.Parse(Request.Form["numero_2"]);

            var resultadoFromBody = numero_1FromBody + numero_2FromBody;
            var resultado = numero_1 + numero_2;

            ViewData["ResultadoFromBody"] = resultadoFromBody;
            ViewData["Resultado"] = resultado;
            return View();
        }
    }
}
