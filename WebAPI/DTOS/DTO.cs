using Core.Models;

namespace WebAPI.DTOS
{
    public class VehiculosDTO
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placas { get; set; }

        public int ResidenteId { get; set; }
    }

    public class IvitadosDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        public TipoInvitacion TipoInvitacion { get; set; }
        public DateTime? FechaInicioValidez { get; set; }
        public DateTime? FechaFinValidez { get; set; }

        public string CodigoQR { get; set; }

        public int ResidenteId { get; set; }
    }
}