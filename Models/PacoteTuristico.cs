using System.ComponentModel.DataAnnotations;

namespace AgenciaTurismo.Models
{
    public class PacoteTuristico
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O título do pacote é obrigatório.")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "O título deve ter entre 5 e 100 caracteres.")]
        public string Titulo { get; set; } = string.Empty;

        [Required(ErrorMessage = "O preço é obrigatório.")]
        [Range(0.01, 99999.99, ErrorMessage = "Informe um preço válido.")]
        public decimal Preco { get; set; }
        public DateTime? DeletedAt { get; set; }

        public List<CidadeDestino> Destinos { get; set; } = new();
        public ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();
    }
}
