using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Residente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string ContrasenaHash { get; set; }
        public string CodigoQR { get; set; }


        public byte[]? Foto { get; set; }

        public ICollection<Vehiculo> Vehiculos { get; set; }
        public ICollection<Invitado> Invitados { get; set; }
        public ICollection<RegistroAcceso> RegistrosAcceso { get; set; }
    }


    public class Vehiculo
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placas { get; set; }

        public int ResidenteId { get; set; }
        public Residente Residente { get; set; }
    }


    public class Invitado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        public TipoInvitacion TipoInvitacion { get; set; }
        public DateTime? FechaInicioValidez { get; set; }
        public DateTime? FechaFinValidez { get; set; }

        public string CodigoQR { get; set; }

        public int ResidenteId { get; set; }
        public Residente Residente { get; set; }

        public ICollection<RegistroAcceso> RegistrosAcceso { get; set; }
    }

    public class RegistroAcceso
    {
        public int Id { get; set; }

        public DateTime FechaHora { get; set; }
        public TipoAcceso TipoAcceso { get; set; }

        public string? PlacasVehiculo { get; set; }
        public string? Notas { get; set; }

        public int? ResidenteId { get; set; }
        public Residente? Residente { get; set; }

        public int? InvitadoId { get; set; }
        public Invitado? Invitado { get; set; }

        public int GuardiaId { get; set; }
        public Guardia Guardia { get; set; }
    }

    public class Guardia
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Usuario { get; set; }
        public string ContrasenaHash { get; set; }

        public ICollection<RegistroAcceso> RegistrosAcceso { get; set; }
    }

    public enum TipoAcceso
    {
        Entrada,
        Salida
    }

    public enum TipoInvitacion
    {
        Unica,
        PorFecha,
        Recurrente
    }
}
