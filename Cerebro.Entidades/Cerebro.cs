using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerebro.Entidades
{
    public class CerebroHumano
    { 
        public int CerebroId { get; set; } = 1;
        public List<Hemisferio> Hemisferios { get; set; } = new List<Hemisferio>();

        public void CrearRedNeuronal()
        {
            foreach (Hemisferio hemisferioActual in Hemisferios)
            {
                hemisferioActual.CreacionNeuronas();
            }                         
        }

        public void Aprender(string conocimiento)
        {
            Hemisferios[1].Aprender(conocimiento);
        }

        public string Recordar(string solicitud)
        {      
            var recuerdo = Hemisferios[1].Recordar(solicitud);
            var respuesta = "";
            if (recuerdo == solicitud)
            {
                respuesta = ComunicacionNeuronal(recuerdo);
            }

            if (recuerdo == "")
            {
                respuesta = $"¿Qué es {solicitud}?";
            }
            
            return respuesta;
        }

        internal string ComunicacionNeuronal(string concepto)
        {
            var recuerdo = "";
            foreach (Hemisferio hemisferioActual in Hemisferios)
            {
                recuerdo += hemisferioActual.ComunicacionNeuronal(concepto);
            }              
            return recuerdo;
        }

        public void MostrarRedNeuronal()
        {           
            int totalNeuornas = 0;
            int totalNeurotransmisores = 0;
            Console.WriteLine($"┌{new string('─', 36)}┐");
            Console.WriteLine(string.Format("│{0}│", $"Hemisferios: {Hemisferios.Count}".PadRight(36)));
            foreach (Hemisferio hemisferioActual in Hemisferios)
            {
                Console.WriteLine($"│{new string('─', 36)}│");
                Console.WriteLine(string.Format("│{0} {1}│", "".PadRight(7), hemisferioActual.Nombre.PadRight(28)));
                Console.WriteLine($"│{new string('─', 36)}│");

                hemisferioActual.MostrarRedNeuronal();
                totalNeuornas += hemisferioActual.TotalNeuronas();
                totalNeurotransmisores += hemisferioActual.TotalNeurotransmisores();
            }
            Console.WriteLine($"├{new string('─', 36)}┤");
            Console.WriteLine(string.Format("│{0} {1}│", "Neuronas Totales:".PadRight(26), $"{totalNeuornas}".PadRight(9)));
            Console.WriteLine(string.Format("│{0} {1}│", "Neurotransmisores Totales:".PadRight(26), $"{totalNeurotransmisores}".PadRight(9)));
            Console.WriteLine($"└{new string('─', 36)}┘");
        }
    }
}