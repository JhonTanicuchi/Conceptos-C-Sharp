using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerebro.Entidades
{
    public class Neurona
    {
        public int NeuronaId { get; set; } = 1;
        public bool SeñalElectrica { get; set; } = true;
        public List<Dendrita> Dendritas { get; set; } = new List<Dendrita>();
        public List<Neurona> Neuronas { get; set; } = new List<Neurona>();


        internal void CreacionDendritas()
        {
            Random num_Dendritas = new Random();
            int TotalDendritas = num_Dendritas.Next(1, 10);

            for (int i = 0; Dendritas.Count <= TotalDendritas; i++)
            {
                Dendritas.Add(
                    new Dendrita { }
                );
                Dendritas[i].CreacionVesiculas();
            }
        }    

        internal string Recordar(string solicitud)
        {
            var recuerdo = "";
            foreach (Dendrita ramificacionActual in Dendritas)
            {
                recuerdo = ramificacionActual.Recordar(solicitud);
            }
            return recuerdo;
        }

        internal void Aprender(string[] conocimiento)               
        {
            var nuevaDendrita = new Dendrita { };
            Dendritas.Add(
                nuevaDendrita
            );
            nuevaDendrita.Aprender(conocimiento);            
        }

        internal string ComunicacionNeuronal(string concepto)
        {
            var recuerdo = "";
            foreach (Dendrita ramificacionActual in Dendritas)
            {
                recuerdo = ramificacionActual.ComunicacionNeuronal(concepto);
            }
            return recuerdo;
        }

        internal int TotalNeuronas()
        {
            return 1;
        }

        internal int TotalNeurotransmisores()
        {
            int totalNeurotransmisores = 0;
            foreach (Dendrita ramificacionActual in Dendritas)
            {
                totalNeurotransmisores += ramificacionActual.TotalNeurotransmisores();
            }
            return totalNeurotransmisores;
        }
    }
}