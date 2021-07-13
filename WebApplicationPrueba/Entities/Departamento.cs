﻿using System.Collections.Generic;

namespace WebApplicationPrueba.Entities
{
    public class Departamento
    {
        public int DepartamentoId { get; set; }
        public string Nombre { get; set; }
        public float Presupuesto { get; set; }
        public List<Empleado> Empleados { get; set; }
    }
}
