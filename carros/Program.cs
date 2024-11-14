using carros.Classes;
using carros.Interface;

class Program
{
    static void Main(string[] args)
    {
        List<IVeiculo> veiculos = new List<IVeiculo>();

        Carro carro = new Carro
        {
            Modelo = "Fusca",
            Ano = 1969,
            CapacidadeTanque = 30,
            ConsumoPorKm = 10,
            Tipo = "Sedan",
            Hibrido = false
        };

        Caminhao caminhao = new Caminhao
        {
            Modelo = "Volvo FH16",
            Ano = 2021,
            CapacidadeTanque = 300,
            ConsumoPorKm = 4,
            CapacidadeCarga = 20
        };

        veiculos.Add(carro);
        veiculos.Add(caminhao);

        foreach (IVeiculo veiculo in veiculos)
        {
            veiculo.ExibirDetalhes();
            Console.WriteLine($"Consumo estimado para 100 km: {veiculo.CalcularConsumo(100)} litros\n");
        }
    }
}
