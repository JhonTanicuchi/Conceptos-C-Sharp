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
            int TotalNeuronas = num_Neuronas.Next(1, 500);

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
                recuerdo += neuronaActual.Recordar(solicitud);
            }
            return recuerdo;
        }     

        internal void Aprender(string conocimiento)
        {          
            string[] definicion = conocimiento.Split(" ");
            string[] concepto = conocimiento.Split(" ");

            foreach (var palabra in definicion)
            {
                if (Recordar(palabra) != palabra)
                {
                    Neurona nuevaNeurona = new() { };
                    Neuronas.Add(
                        nuevaNeurona
                    );
                    nuevaNeurona.Aprender(concepto);
                    var tmp = concepto[0];
                    concepto[0] = concepto[1];
                    concepto[1] = tmp;
                }
                else
                {                   
                    foreach (Neurona neuronaActual in Neuronas)
                    {
                        neuronaActual.RelacionNeuronal(conocimiento);
                    }                     
                }
            }        
        }

        internal int TotalNeuronas()
        {
            int totalNeuronas = 0;
            foreach (Neurona neuronaActual in Neuronas)
            {
                totalNeuronas += neuronaActual.TotalNeuronas();
            }
            return totalNeuronas;
        }

        internal int TotalNeurotransmisores()
        {
            int totalNeurotransmisores = 0;
            foreach (Neurona neuronaActual in Neuronas)
            {
                totalNeurotransmisores += neuronaActual.TotalNeurotransmisores();
            }
            return totalNeurotransmisores;
        }

        internal void MostrarRedNeuronal()
        {
            Console.WriteLine(string.Format("│{0} {1} {2}│", $" {Nombre}:".PadRight(21), $"{Neuronas.Count}".PadRight(4), "Neuronas".PadRight(9)));                       
        }

        public string ComunicacionNeuronal(string concepto)
        {
            var recuerdo = "";
            foreach (Neurona neuronaActual in Neuronas)
            {
                recuerdo += neuronaActual.ComunicacionNeuronal(concepto);
            }
            return recuerdo;
        }
    }
}