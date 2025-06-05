using System;
using System.Collections.Generic;

class Estacionamento
{
    private decimal precoInicial;
    private decimal precoPorHora;
    private List<string> veiculos = new List<string>();

    public Estacionamento(decimal precoInicial, decimal precoPorHora)
    {
        this.precoInicial = precoInicial;
        this.precoPorHora = precoPorHora;
    }

    public void AdicionarVeiculo(string placa)
    {
        if (string.IsNullOrWhiteSpace(placa))
        {
            Console.WriteLine("Placa inválida. Tente novamente.");
            return;
        }

        veiculos.Add(placa.ToUpper());
        Console.WriteLine($"Veículo {placa.ToUpper()} adicionado com sucesso.\n");
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
    }

    public void RemoverVeiculo(string placa)
    {
        placa = placa.ToUpper();

        if (!veiculos.Contains(placa))
        {
            Console.WriteLine("Veículo não encontrado. Tente novamente.");
            return;
        }

        Console.Write("Digite a quantidade de horas que o veículo permaneceu estacionado: ");
        if (!int.TryParse(Console.ReadLine(), out int horas))
        {
            Console.WriteLine("Valor inválido de horas. Operação cancelada.");
            return;
        }

        decimal valorTotal = precoInicial + precoPorHora * horas;
        veiculos.Remove(placa);
        Console.WriteLine($"Veículo {placa} removido com sucesso. Valor total: {valorTotal:C}");
    }

    public void ListarVeiculos()
    {
        if (veiculos.Count == 0)
        {
            Console.WriteLine("Nenhum veículo estacionado.");
            return;
        }

        Console.WriteLine("Veículos estacionados:");
        foreach (var veiculo in veiculos)
        {
            Console.WriteLine($"- {veiculo}");
        }
    }
}
