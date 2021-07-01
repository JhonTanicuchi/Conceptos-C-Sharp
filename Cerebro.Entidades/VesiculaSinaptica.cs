using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerebro.Entidades
{
    public class VesiculaSinaptica
    {
        public List<Neurotransmisor> Neurotransmisores { get; set; } = new List<Neurotransmisor>();

        internal void CreacionNeurotransmisores()
        {
            Random num_Neurotransmisores = new Random();
            int TotalNeurotransmisores = num_Neurotransmisores.Next(1, 100);

            for (int i = 0; Neurotransmisores.Count <= TotalNeurotransmisores; i++)
            {
                Neurotransmisores.Add(
                    new Neurotransmisor { }
                );
            }
        }
     
        internal void Aprender(string[] conocimiento)
        {
            Neurotransmisores.Add(
                new Neurotransmisor
                {
                    Informacion = conocimiento[0],
                    Propiedades = new List<Propiedad>
                    {
                        new Propiedad
                        {
                            Nombre = conocimiento[1]
                        }
                    }
                }
            );
            
        }

        internal string ComunicacionNeuronal(string concepto)
        {
            var recuerdo = "";
            foreach (Neurotransmisor neurotransmisorActual in Neurotransmisores)
            {
                return neurotransmisorActual.ComunicacionNeuronal(concepto);       
            }
            return recuerdo;
        }

        internal string Recordar(string solicitud)
        {
            var recuerdo = "";
            foreach(Neurotransmisor neurotransmisorActual in Neurotransmisores)
            {                                       
                if (neurotransmisorActual.Informacion == solicitud)
                {
                    recuerdo = neurotransmisorActual.Informacion;
                }
            }
            return recuerdo;
        }

        internal int TotalNeurotransmisores()
        {
            int totalNeurotransmisores = 0;
            foreach (Neurotransmisor neurotransmisorActual in Neurotransmisores)
            {
                totalNeurotransmisores += neurotransmisorActual.TotalNeurotransmisores();
            }
            return totalNeurotransmisores;
        }
    }
}