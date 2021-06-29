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
    }
}