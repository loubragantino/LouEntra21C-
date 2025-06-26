using ConsoleMentoria2;
using Microsoft.VisualBasic;

bool continuar = true;

Action v = Console.Clear;

while (continuar)
{
    v();
    Console.WriteLine("=== Menu de Exemplos ===");
    Console.WriteLine("1 - Exemplo Idade");
    Console.WriteLine("2 - Possui CNH");
    Console.WriteLine("3 - Exemplo Estação do Ano");
    Console.WriteLine("4 - Exemplo Cliente");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("\nEscolha uma opção:");

    string? opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            VerificadorIdade.Executar();
            break;
        case "2":
            VerificadorCNH.Executar();
            break;
        case "3":
            VerificadorEstacao.Executar();
            break;
        case "4":
            Console.WriteLine("Informe o nome do cliente: ");
            string? nome = Console.ReadLine()?.Trim();
            Console.WriteLine("Informe a idade do cliente: ");
            int idadeCliente = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o e-mail do cliente: ");
            string? email = Console.ReadLine()?.Trim();

            ObjetoCliente objetoCliente = new ObjetoCliente {
                NomeCompleto = nome,
                Idade = idadeCliente,
                Email = email,
            };

            CriacaoCliente criacaoCliente = new CriacaoCliente(objetoCliente);
            ObjetoCliente clienteCriado = criacaoCliente.CriarCliente();


            break;
        case "0":
            continuar = false;
            break;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }

    if (continuar)
    {
        Console.WriteLine("\nPressione qualquer tecla para continuar...");
        Console.ReadKey();
    }
}
