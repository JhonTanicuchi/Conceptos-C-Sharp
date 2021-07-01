using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerebro.Entidades
{
    public class Hemisferio
    {
        public int HemisferioId { get; set; } = 1;
        public string Nombre { get; set; }
        public List<Zona> Zonas { get; set; } = new List<Zona>();


        public void CreacionNeuronas()
        {
            foreach (Zona zonaActual in Zonas)
            {
                zonaActual.CreacionNeuronas();
            }
        }

        internal void Aprender(string conocimiento)
        {
            Zonas[Zonas.Count - 1].Aprender(conocimiento);
        }

        internal string Recordar(string solicitud)
        {
            var recuerdo = "";
            foreach(Zona zonaActual in Zonas){
                recuerdo = zonaActual.Recordar(solicitud);
            }
            recuerdo = recuerdo.Replace(" ", String.Empty);
            return recuerdo;  
        }

        internal string ComunicacionNeuronal(string concepto)
        {
            var recuerdo = "";
            foreach (Zona zonaActual in Zonas)
            {
                recuerdo = zonaActual.ComunicacionNeuronal(concepto);
            }
            return recuerdo;
        }

        internal void MostrarRedNeuronal()
        {
            Console.WriteLine(string.Format("│{0}│", $"Zonas: { Zonas.Count}".PadRight(36)));
            Console.WriteLine($"│{new string('·', 36)}│");

            foreach (Zona zonaActual in Zonas)
            {
                zonaActual.MostrarRedNeuronal();             
            }         
        }

        internal int TotalNeuronas()
        {
            int totalNeuronas = 0;
            foreach (Zona zonaActual in Zonas)
            {             
                totalNeuronas += zonaActual.TotalNeuronas();
            }
            return totalNeuronas;
        }

        internal int TotalNeurotransmisores()
        {
            int totalNeurotransmisores = 0;
            foreach (Zona zonaActual in Zonas)
            {              
                totalNeurotransmisores += zonaActual.TotalNeurotransmisores();
            }
            return totalNeurotransmisores;
        }
    }
}