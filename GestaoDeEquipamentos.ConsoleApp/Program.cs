using System.Security.Cryptography;
using GestaoDeEquipamentos.ConsoleApp;

Equipamento?[] equipamentos = new Equipamento[100];

while (true)
{
    Console.Clear();
    Console.WriteLine("---------------------------------");
    Console.WriteLine("Gestão de Equipamentos");
    Console.WriteLine("---------------------------------");
    Console.WriteLine("1 - Cadastrar equipamento");
    Console.WriteLine("2 - Editar equipamento");
    Console.WriteLine("3 - Excluir equipamento");
    Console.WriteLine("4 - Visualizar equipamentos");
    Console.WriteLine("S - Sair");
    Console.WriteLine("---------------------------------");
    Console.Write("> ");
    string? opcaoMenu = Console.ReadLine()?.ToUpper();

    if (opcaoMenu == "S")
    {
        Console.Clear();
        break;
    }

    if (opcaoMenu == "1")
    {
        Console.Clear();
        Console.WriteLine("\nGestão de Equipamentos\n");
        Console.WriteLine("Cadastro de Equipamento\n");

        Equipamento novoEquipamento = new Equipamento();

        do
        {
            Console.Write("Digite o nome do equipamento: ");
            novoEquipamento.nome = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(novoEquipamento.nome) && novoEquipamento.nome.Length > 3)
            {
                break;
            }
        } while (true);

        do
        {
            Console.Write("Digite o fabricante do equipamento: ");
            novoEquipamento.fabricante = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(novoEquipamento.fabricante) && novoEquipamento.fabricante.Length > 2)
            {
                break;
            }
        } while (true);

        Console.WriteLine("Digite o preço de aquisição do equipamento: ");
        novoEquipamento.precoAquisicao = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Digite a data de fabricação do equipamento: ");
        novoEquipamento.dataFabricacao = Convert.ToDateTime(Console.ReadLine());

        novoEquipamento.id = Convert
            .ToHexString(RandomNumberGenerator.GetBytes(20))
            .ToLower()
            .Substring(0, 7);

        for (int i = 0; i < equipamentos.Length; i++)
        {
            Equipamento? e = equipamentos[i];

            if (e == null)
            {
                equipamentos[i] = novoEquipamento;
                break;
            }
        }

        Console.WriteLine($"\nO registro \"{novoEquipamento}\" foi registrado com sucesso.\n");
        Console.WriteLine("Pressione ENTER para continuar...");
        Console.ReadLine();
    }

    else if (opcaoMenu == "2")
    {
        Console.Clear();
        Console.WriteLine("\nGestão de equipamentos\n");
        Console.WriteLine("Edição de equipamento\n");

        Console.WriteLine(
            "{0, -7} | {1, -15} | {2, -15} | {3, -22} | {4, -10}",
            "id", "fabricante", "preço de aquisição", "data de fabricação"
        );

        for (int i = 0; i < equipamentos.Length; i++)
        {
            Equipamento? e = equipamentos[i];
            if (e == null)
                continue;

            Console.WriteLine(
                "{0, -7} | {1, -15} | {2, -15} | {3, -22} | {4, -10}",
                e.id, e.fabricante, e.precoAquisicao.ToString("C2"), e.dataFabricacao.ToShortDateString()
            );
        }

        Console.WriteLine("Digite o id do equipamento que deseja editar: ");
        Console.ReadLine();
    }

    else if (opcaoMenu == "3")
    {

    }

    else if (opcaoMenu == "4")
    {

    }
}