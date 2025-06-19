using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace AgenciaTurismo.Pages.Exercicios.Exercicio04
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public int ReservasAtuais { get; set; }

        [BindProperty]
        public int CapacidadeMaxima { get; set; }

        public string Mensagem { get; set; } = string.Empty;
        public string AlertaCssClass { get; set; } = string.Empty;

        public void OnPost()
        {
            var pacote = new PacoteTuristico(CapacidadeMaxima);

            // Inscreve no evento
            pacote.CapacidadeUltrapassada += Pacote_CapacidadeUltrapassada;

            // Simula as reservas
            pacote.AdicionarReservas(ReservasAtuais);

            // Se o evento não disparar, significa que está dentro do limite
            if (string.IsNullOrEmpty(Mensagem))
            {
                Mensagem = "Reservas dentro da capacidade permitida.";
                AlertaCssClass = "alert-success";
            }
        }

        private void Pacote_CapacidadeUltrapassada(object? sender, EventArgs e)
        {
            Mensagem = "Capacidade máxima ultrapassada!";
            AlertaCssClass = "alert-danger";
            Console.WriteLine(Mensagem);
        }
    }

    public class PacoteTuristico
    {
        public int CapacidadeMaxima { get; }
        public int TotalReservas { get; private set; }

        public event EventHandler? CapacidadeUltrapassada;

        public PacoteTuristico(int capacidadeMaxima)
        {
            CapacidadeMaxima = capacidadeMaxima;
        }

        public void AdicionarReservas(int novasReservas)
        {
            TotalReservas += novasReservas;

            if (TotalReservas > CapacidadeMaxima)
            {
                CapacidadeUltrapassada?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
