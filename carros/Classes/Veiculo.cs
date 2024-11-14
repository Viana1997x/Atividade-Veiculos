using carros.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carros.Classes
{
    public abstract class Veiculo : IVeiculo
    {
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public double CapacidadeTanque { get; set; }
        public double ConsumoPorKm { get; set; }

        public virtual void ExibirDetalhes()
        {
            Console.WriteLine($"Modelo: {Modelo}, Ano: {Ano}, Capacidade do Tanque: {CapacidadeTanque} litros, Consumo por Km: {ConsumoPorKm} km/l");
        }

        public virtual double CalcularConsumo(double distancia)
        {
            return distancia / ConsumoPorKm;
        }
    }

}
