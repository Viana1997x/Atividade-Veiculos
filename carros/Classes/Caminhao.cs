using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carros.Classes
{
    public class Caminhao : Veiculo
    {
        public double CapacidadeCarga { get; set; } // em toneladas

        public override void ExibirDetalhes()
        {
            base.ExibirDetalhes();
            Console.WriteLine($"Capacidade de Carga: {CapacidadeCarga} toneladas");
        }

        public override double CalcularConsumo(double distancia)
        {
            double consumoAjustado = ConsumoPorKm * (1 - (CapacidadeCarga * 0.05)); // Ajuste do consumo baseado na carga
            return distancia / consumoAjustado;
        }
    }

}
