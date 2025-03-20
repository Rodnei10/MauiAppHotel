using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                double Valor_adultos = QntAdulto * QuartoSelecionado.ValorDiariaAdulto;
                double Valor_criancas = QntCriancas * QuartoSelecionado.ValorDiariaCrianca;

                double total = (Valor_adultos + Valor_criancas) * Estadia;

                return total;
            }
        }//fechamento da classes
    }//fechamento namespace
}
