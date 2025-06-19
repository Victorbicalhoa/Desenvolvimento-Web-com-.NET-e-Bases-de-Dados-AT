using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgenciaTurismo.Models
{
    public class Reserva
    {
        public int Id { get; set; }

        public int ClienteId { get; set; }

        [ForeignKey("ClienteId")]
        public Cliente? Cliente { get; set; }

        public int PacoteTuristicoId { get; set; }

        [ForeignKey("PacoteTuristicoId")]
        public PacoteTuristico? PacoteTuristico { get; set; }
        [DataType(DataType.Date)]
        public DateTime DataReserva { get; set; }
    }

}
