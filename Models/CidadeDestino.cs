﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgenciaTurismo.Models
{
    public class CidadeDestino
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome da cidade é obrigatório.")]
        [MinLength(3, ErrorMessage = "O nome da cidade deve ter pelo menos 3 caracteres.")]
        public string Nome { get; set; } = string.Empty;

        [Display(Name = "País")]
        public int PaisDestinoId { get; set; }

        [ForeignKey("PaisDestinoId")]
        public PaisDestino PaisDestino { get; set; } = null!;

    }
}
