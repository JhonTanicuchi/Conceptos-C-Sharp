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
        public Hemisferio HemisferioIzquierdo{ get; set; }
        public Hemisferio HemisferioDerecho{ get; set; }

        public void CrearRedNeuronal()
        {
            HemisferioIzquierdo.CreacionNeuronas();
            HemisferioDerecho.CreacionNeuronas();                
        }

        public void Aprender(string conocimiento)
        {
            HemisferioIzquierdo.Aprender(conocimiento);
        }

        public string Recordar(string solicitud)
        {      
            var recuerdo = HemisferioIzquierdo.Recordar(solicitud);
            if (recuerdo == "")
            {
                recuerdo = HemisferioDerecho.Recordar(solicitud);
            }
            else if (recuerdo == solicitud)
            {
                recuerdo = ComunicacionNeuronal(recuerdo);
            }
            else
            {
                recuerdo = $"¿Qué es {solicitud}?";
            }
            
            return recuerdo;
        }

        internal string ComunicacionNeuronal(string concepto)
        {
            var recuerdo = HemisferioIzquierdo.ComunicacionNeuronal(concepto);
            if (recuerdo == "")
            {
                recuerdo = HemisferioDerecho.ComunicacionNeuronal(concepto);
            }

            return recuerdo;

        }

        public void MostrarRedNeuronal()
        {
            
        }
    }
}