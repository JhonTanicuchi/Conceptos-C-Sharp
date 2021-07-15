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

        public IEnumerable<Empleado> EmpleadosPaginados(int pagina, int registrosPorPagina )
        {
            var salto = (pagina -1) * registrosPorPagina;
            return _context.Empleados.Skip(salto).Take(registrosPorPagina);
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
