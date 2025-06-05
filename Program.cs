
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 5.00m;
decimal precoPorHora = 2.00m;
Estacionamento estacionamento = new Estacionamento(precoInicial, precoPorHora);

bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Sistema de Estacionamento");
    Console.WriteLine("-------------------------");
    Console.WriteLine("1. Adicionar Veículo");
    Console.WriteLine("2. Remover Veículo");
    Console.WriteLine("3. Listar Veículos");
    Console.WriteLine("4. Sair");
    Console.Write("Escolha uma opção: ");

    switch (Console.ReadLine())
    {
        case "1":
            Console.Write("Digite a placa do veículo para adicionar: ");
            string placaAdicionar = Console.ReadLine();
            estacionamento.AdicionarVeiculo(placaAdicionar);
            break;

        case "2":
            Console.Write("Digite a placa do veículo para remover: ");
            string placaRemover = Console.ReadLine();
            estacionamento.RemoverVeiculo(placaRemover);
            break;

        case "3":
            estacionamento.ListarVeiculos();
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            break;

        case "4":
            exibirMenu = false;
            Console.WriteLine("Saindo do sistema...");
            break;

        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            break;
    }
}

Console.WriteLine("Obrigado por usar o sistema de estacionamento!");
