using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplicationPrueba.Entities;

namespace WebApplicationPrueba.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Hijo> Hijos { get; set; }
        public DbSet<Conyuge> Conyuges { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
    }
}
