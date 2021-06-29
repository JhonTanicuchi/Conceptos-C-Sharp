using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerebro.Entidades
{
    public class Dendrita
    {
        public int RamificacionId { get; set; } = 1;
        public int Valor { get; set; }
        public List<VesiculaSinaptica> VesiculasSinapticas { get; set; } = new List<VesiculaSinaptica>();

       
        internal void CreacionVesiculas()
        {
            Random num_Vesiculas = new Random();
            int TotalVesiculas = num_Vesiculas.Next(1, 100);

            for (int i = 0; VesiculasSinapticas.Count <= TotalVesiculas; i++)
            {
                VesiculasSinapticas.Add(
                    new VesiculaSinaptica { }
                );
                VesiculasSinapticas[i].CreacionNeurotransmisores();
            }
        }

        internal void Aprender(string conocimiento)
        {                   
            var vesiculaSinaptica = new VesiculaSinaptica { };
            VesiculasSinapticas.Add(
                vesiculaSinaptica
            );
            vesiculaSinaptica.Aprender(conocimiento);                   
        }

        internal string Recordar(string solicitud)
        {
            var recuerdo = "";
            foreach (VesiculaSinaptica vesiculaActual in VesiculasSinapticas)
            {
                recuerdo = vesiculaActual.Recordar(solicitud);
            }
            return recuerdo;
        }

        internal string ComunicacionNeuronal(string concepto)
        {
            var recuerdo = "";
            foreach (VesiculaSinaptica vesiculaActual in VesiculasSinapticas)
            {
                recuerdo = vesiculaActual.ComunicacionNeuronal(concepto);
            }
            return recuerdo;
        }
    }
}
