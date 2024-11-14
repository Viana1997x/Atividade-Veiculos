using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carros.Classes
{
    public class Carro : Veiculo
    {
        public string Tipo { get; set; }
        public bool Hibrido { get; set; } // Exemplo de característica adicional

        public override void ExibirDetalhes()
        {
            base.ExibirDetalhes();
            Console.WriteLine($"Tipo: {Tipo}, Híbrido: {Hibrido}");
        }

        public override double CalcularConsumo(double distancia)
        {
            double consumo = Hibrido ? ConsumoPorKm * 1.2 : ConsumoPorKm; // Exemplo de ajuste para veículos híbridos
            return distancia / consumo;
        }
    }

}
