using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerebro.Entidades
{
    public class Neurotransmisor
    {
        public string Informacion { get; set; }
        public List<Propiedad> Propiedades { get; set; } = new List<Propiedad>();
        public MoleculaEA MoleculasEA { get; set; }

        public string ComunicacionNeuronal(string concepto)
        {
            var recuerdo = "";
            foreach (Propiedad propiedadActual in Propiedades)
            {
                if (Informacion == concepto)
                {
                    recuerdo = propiedadActual.Nombre;
                }
            }

            return recuerdo;
        }

        internal int TotalNeurotransmisores()
        {
            return 1;
        }

        
    }
}