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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Guardias
            modelBuilder.Entity<Guardia>().HasData(
                new Guardia
                {
                    Id = 1,
                    Nombre = "Isela Cerritos Guzman",
                    Usuario = "isaguzman",
                    ContrasenaHash = "isa123"
                },
                new Guardia
                {
                    Id = 2,
                    Nombre = "Alfredo Garcia Olmedo",
                    Usuario = "root",
                    ContrasenaHash = "root"
                }
            );

            // Residentes
            modelBuilder.Entity<Residente>().HasData(
                new Residente
                {
                    Id = 1,
                    Nombre = "Juan",
                    Apellidos = "Pérez",
                    Domicilio = "Calle Robles 101",
                    Telefono = "555-1001",
                    ContrasenaHash = "res123"
                },
                new Residente
                {
                    Id = 2,
                    Nombre = "María",
                    Apellidos = "González",
                    Domicilio = "Calle Encinos 202",
                    Telefono = "555-1002",
                    ContrasenaHash = "res234"
                },
                new Residente
                {
                    Id = 3,
                    Nombre = "Luis",
                    Apellidos = "Martínez",
                    Domicilio = "Calle Ciprés 303",
                    Telefono = "555-1003",
                    ContrasenaHash = "res345"
                },
                new Residente
                {
                    Id = 4,
                    Nombre = "Ana",
                    Apellidos = "Rodríguez",
                    Domicilio = "Calle Palmas 404",
                    Telefono = "555-1004",
                    ContrasenaHash = "res456"
                },
                new Residente
                {
                    Id = 5,
                    Nombre = "Pedro",
                    Apellidos = "López",
                    Domicilio = "Calle Sauces 505",
                    Telefono = "555-1005",
                    ContrasenaHash = "res567"
                }
            );

            // Vehículos
            modelBuilder.Entity<Vehiculo>().HasData(
                new Vehiculo
                {
                    Id = 1,
                    Marca = "Toyota",
                    Modelo = "Corolla",
                    Placas = "ABC-123",
                    ResidenteId = 1
                },
                new Vehiculo
                {
                    Id = 2,
                    Marca = "Nissan",
                    Modelo = "Versa",
                    Placas = "XYZ-456",
                    ResidenteId = 2
                },
                new Vehiculo
                {
                    Id = 3,
                    Marca = "Honda",
                    Modelo = "Civic",
                    Placas = "JKL-789",
                    ResidenteId = 5
                }
            );

            base.OnModelCreating(modelBuilder);
        }

    }
}
