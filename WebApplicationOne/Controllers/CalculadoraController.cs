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
        public IActionResult Calcular(int numero_1, int numero_2, string operacion)
        {
            var resultadoFromBody = 0;
            var resultado = 0;

            var numero_1FromBody = int.Parse(Request.Form["numero_1"]);
            var numero_2FromBody = int.Parse(Request.Form["numero_2"]);

            switch (operacion)
            {
                case "+":
                    resultadoFromBody = numero_1FromBody + numero_2FromBody;
                    resultado = numero_1 + numero_2;
                    break;
                case "-":
                    resultadoFromBody = numero_1FromBody - numero_2FromBody;
                    resultado = numero_1 - numero_2;
                    break;
                case "*":
                    resultadoFromBody = numero_1FromBody * numero_2FromBody;
                    resultado = numero_1 * numero_2;
                    break;
                case "/":
                    resultadoFromBody = numero_1FromBody / numero_2FromBody;
                    resultado = numero_1 / numero_2;
                    break;
                default:                  
                    break;
            }
          
            ViewData["ResultadoFromBody"] = resultadoFromBody;
            ViewData["Resultado"] = resultado;
            return View();
        }
    }
}
