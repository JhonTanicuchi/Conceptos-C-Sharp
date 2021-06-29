using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerebro.Entidades
{
    public class Zona
    {
        public int ZonaId{ get; set; } = 1;
        public string Nombre{ get; set; }
        public List<Neurona> Neuronas { get; set; } = new List<Neurona>();


        public void CreacionNeuronas()
        {           
            Random num_Neuronas = new Random();
            int TotalNeuronas = num_Neuronas.Next(1, 1000);

            for (int i = 0; Neuronas.Count <= TotalNeuronas; i++)
            {               
                Neuronas.Add(
                    new Neurona { }                  
                );
                Neuronas[i].CreacionDendritas();
            }          
        }

        internal string Recordar(string solicitud)
        {
            var recuerdo = "";
            foreach (Neurona neuronaActual in Neuronas)
            {
                recuerdo = neuronaActual.Recordar(solicitud);
            }
            return recuerdo;
        }

        internal void Aprender(string conocimiento)
        {
            string[] definiciones = conocimiento.Split(" ");
            
            if (Recordar(definiciones[0]) != definiciones[0])
            {
                Neurona nuevaNeurona = new Neurona { };
                Neuronas.Add(
                    nuevaNeurona
                );
                nuevaNeurona.Aprender(conocimiento);
            }

            if (Recordar(definiciones[1]) != definiciones[1])
            {
                Neurona nuevaNeurona = new Neurona { };
                Neuronas.Add(
                    nuevaNeurona
                );
                nuevaNeurona.Aprender(definiciones[1]);
            }
        }

        public string ComunicacionNeuronal(string concepto)
        {
            var recuerdo = "";
            foreach (Neurona neuronaActual in Neuronas)
            {
                recuerdo = neuronaActual.ComunicacionNeuronal(concepto);
            }
            return recuerdo;
        }
    }
}