using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebApplicationPrueba.Data;
using WebApplicationPrueba.Entities;

namespace WebApplicationPrueba.Controllers
{
    public class ConsultasController : Controller
    {
        readonly ApplicationDbContext _context;

        public ConsultasController(ApplicationDbContext aplicationDbContext)
        {
            _context = aplicationDbContext;

        }
        public IEnumerable<Departamento> Departamentos()
        {
            return _context.Departamentos;
        }

        public IEnumerable<Empleado> Empleados()
        {
            //_context.Empleados.OrderBy(e => e.Apellido);
            //_context.Empleados.OrderByDescending(e => e.Apellido);
            //_context.Empleados.OrderBy(e => e.Nombre).ThenBy(e => e.Apellido);
            var empleados = _context.Empleados.ToList();
            return empleados.OrderBy(e => e.NombreCompleto);
        }
    }
}
