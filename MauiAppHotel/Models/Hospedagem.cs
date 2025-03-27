using System;

namespace MauiAppHotel.Models
{
    public class Hospedagem
    {
        public Quarto QuartoSelecionado { get; set; }

        public double QntAdultos { get; set; }

        public double QntCriancas { get; set; }

        public DateTime DataCheckIn { get; set; }

        public DateTime DataCheckout { get; set; }

        public double Estadia
        {
            get => DataCheckout.Subtract(DataCheckIn).Days;
        }

        public double ValorTotal
        {
            get
            {
                
                double Valor_adultos = QntAdultos * QuartoSelecionado.ValorDiariaAdulto;
                double Valor_criancas = QntCriancas * QuartoSelecionado.ValorDiariaCrianca;

                // Cálculo total
                double total = (Valor_adultos + Valor_criancas) * Estadia;

                return total;
            }
        }
    }
}

