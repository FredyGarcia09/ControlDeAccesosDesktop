using ControlDeAccesosDesktop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeAccesosDesktop.Data
{
    public class ControlDbContext : DbContext
    {
        public DbSet<Residente> Residentes { get; set; }
        public DbSet<Invitado> Invitados { get; set; }
        public DbSet<Guardia> Guardias { get; set; }
        public DbSet<RegistroAcceso> RegistrosAcceso { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=localhost;database=controlaccesos;user=root;password=root;";
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
    }
}
