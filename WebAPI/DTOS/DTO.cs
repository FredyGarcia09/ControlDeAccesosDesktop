using Core.Models;

namespace WebAPI.DTOS
{
    public class VehiculosDTO
    {
        public string Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placas { get; set; }

        public string ResidenteId { get; set; }
    }

    public class InvitadosDTO
    {
        public string Id { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }

        public string tipoInvitacion { get; set; }
        public string fechaInicio { get; set; }
        public string fechaFin { get; set; }

        public string residenteId { get; set; }
        public string? codigoQR { get; set; }
    }
}