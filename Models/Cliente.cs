using AgenciaTurismo.Models;
using System.ComponentModel.DataAnnotations;

namespace AgenciaTurismo.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required]
        public string? Nome { get; set; }

        [EmailAddress]
        public string? Email { get; set; }

        [Phone]
        public string? Telefone { get; set; }

        public ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();
    }
}