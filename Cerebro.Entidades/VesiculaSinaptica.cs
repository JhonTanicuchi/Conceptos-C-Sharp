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

        internal void Aprender(string conocimiento)
        {
            string[] definiciones = conocimiento.Split(" "); ;
                
            if (definiciones.Length == 2)
            {
                var nuevoNeurotransmisor = new Neurotransmisor
                {
                    Informacion = definiciones[0],
                    Propiedades = new List<Propiedad>
                    {
                        new Propiedad
                        {
                            Nombre = definiciones[1]
                        }

                    }
                };
                Neurotransmisores.Add(
                    nuevoNeurotransmisor
                );
            }
            else
            {               
                var nuevoNeurotransmisor1 = new Neurotransmisor
                {
                    Informacion = conocimiento,
                    Propiedades = new List<Propiedad>
                    {
                        new Propiedad
                        {
                            Nombre = definiciones[0]
                        }

                    }
                };
                Neurotransmisores.Add(
                    nuevoNeurotransmisor1
                );
            }
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
                    return neurotransmisorActual.Informacion;
                }
            }
            return recuerdo;
        }

        
    }
}