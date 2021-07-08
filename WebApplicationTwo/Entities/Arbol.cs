using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationTwo.Entities
{
    public class Arbol
    {
        public int ArbolId { get; set; }

        [DisplayName("El árbol se llama")]

        public string Nombre { get; set; }

        [DisplayName("La hoja es de color")]

        public string ColorHoja { get; set; }

    }
}
