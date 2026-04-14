using System.Net;
using GestaoDeEquipamentos.ConsoleApp.Dominio;
using GestaoDeEquipamentos.ConsoleApp.Infraestrutura;
namespace GestaoDeEquipamentos.ConsoleApp.Apresentacao;

public class TelaFabricante
{
    public RepositorioFabricante repositorio = new RepositorioFabricante();
    public RepositorioEquipamento? repositorioEquipamento;
    public string? ObterEscolhaMenuPrincipal()
    {
        Console.Clear();
        Console.WriteLine("\nGestão de Fabricantes\n");
        Console.WriteLine("1 - Cadastrar Fabricante");
        Console.WriteLine("2 - Editar Fabricante");
        Console.WriteLine("3 - Excluir Fabricante");
        Console.WriteLine("4 - Visualizar Fabricantes");
        Console.WriteLine("S - Sair");
        Console.Write("\n> ");
        string? opcaoMenu = Console.ReadLine()?.ToUpper();

        return opcaoMenu;
    }
    public void Cadastrar()
    {
        Console.Clear();
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Gestão de Fabricantes");
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Cadastro de Fabricantes");
        Console.WriteLine("---------------------------------");

        Fabricante novoFabricante = new Fabricante();

        do
        {
            Console.Write("Digite o nome do Fabricante: ");
            novoFabricante.nome = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(novoFabricante.nome) &&
                novoFabricante.nome.Length >= 2)
            {
                break;
            }

        } while (true);

        do
        {
            Console.Write("Digite o e-mail do Fabricante: ");
            novoFabricante.email = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(novoFabricante.email) &&
                novoFabricante.email.Length > 2)
            {
                break;
            }

        } while (true);

        do
        {
            Console.Write("Digite o telefone de contato do Fabricante: ");
            novoFabricante.telefone = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(novoFabricante.telefone) &&
                novoFabricante.telefone.Length >= 2)
            {
                break;
            }

        } while (true);

        repositorio.Cadastrar(novoFabricante);

        repositorio.SalvarFabricantes();

        Console.WriteLine("---------------------------------");
        Console.WriteLine($"O registro \"{novoFabricante.id}\" foi cadastrado com sucesso.");
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Digite ENTER para continuar...");
        Console.ReadLine();
    }

    public void Editar()
    {
        Console.Clear();
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Gestão de Fabricantes");
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Edição de Fabricante");
        Console.WriteLine("---------------------------------");

        Console.WriteLine(
            "{0, -7} | {1, -15} | {2, -30} | {3, -22} | {4, -10}",
            "Id", "Fabricante", "E-mail", "Telefone", "Produtos"
        );

        Fabricante?[] Fabricantes = repositorio.SelecionarTodos();
        Equipamento?[] equipamentos = repositorioEquipamento!.SelecionarTodos();

        for (int i = 0; i < Fabricantes.Length; i++)
        {
            Fabricante? f = Fabricantes[i];

            if (f == null)
                continue;

            Console.WriteLine(
                "{0, -7} | {1, -15} | {2, -30} | {3, -22} | {4, -10}",
                f.id, f.nome, f.email, f.telefone, f.Produtos(equipamentos)
            );
        }

        Console.WriteLine("---------------------------------");

        string? idSelecionado;

        do
        {
            Console.Write("Digite o id do Fabricante que deseja editar: ");
            idSelecionado = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(idSelecionado))
            {
                Console.Clear();
                return;
            }

            if (idSelecionado.Length == 7)
                break;
        } while (true);

        Fabricante novoFabricante = new Fabricante();

        do
        {
            Console.Write("Digite o nome do Fabricante: ");
            novoFabricante.nome = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(novoFabricante.nome) &&
                novoFabricante.nome.Length >= 2)
            {
                break;
            }

        } while (true);

        do
        {
            Console.Write("Digite o email do Fabricante: ");
            novoFabricante.email = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(novoFabricante.email) &&
                novoFabricante.email.Length >= 2)
            {
                break;
            }

        } while (true);

        do
        {
            Console.Write("Digite o telefone de contato do Fabricante: ");
            novoFabricante.telefone = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(novoFabricante.telefone) &&
                novoFabricante.telefone.Length >= 2)
            {
                break;
            }

        } while (true);

        bool conseguiuEditar = repositorio.Editar(idSelecionado, novoFabricante);

        if (!conseguiuEditar)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"Não foi possível encontrar o Fabricante informado.");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Digite ENTER para continuar...");
            Console.ReadLine();
            return;
        }

        repositorio.SalvarFabricantes();

        Console.WriteLine("---------------------------------");
        Console.WriteLine($"O registro \"{idSelecionado}\" foi editado com sucesso.");
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Digite ENTER para continuar...");
        Console.ReadLine();
    }

    public void Excluir()
    {
        Console.Clear();
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Gestão de Fabricantes");
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Exclusão de Fabricante");
        Console.WriteLine("---------------------------------");

        Console.WriteLine(
            "{0, -7} | {1, -15} | {2, -30} | {3, -22} | {4, -10}",
            "Id", "Fabricante", "E-mail", "Telefone", "Produtos"
        );

        Fabricante?[] Fabricantes = repositorio.SelecionarTodos();
        Equipamento?[] equipamentos = repositorioEquipamento!.SelecionarTodos();

        for (int i = 0; i < Fabricantes.Length; i++)
        {
            Fabricante? f = Fabricantes[i];

            if (f == null)
                continue;

            Console.WriteLine(
                "{0, -7} | {1, -15} | {2, -30} | {3, -22} | {4, -10}",
                f.id, f.nome, f.email, f.telefone, f.Produtos(equipamentos)
            );
        }

        Console.WriteLine("---------------------------------");

        string? idSelecionado;

        do
        {
            Console.Write("Digite o id do Fabricante que deseja excluir: ");
            idSelecionado = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(idSelecionado))
            {
                Console.Clear();
                return;
            }

            if (idSelecionado.Length == 7)
                break;
        } while (true);

        bool conseguiuExcluir = repositorio.Excluir(idSelecionado);

        if (conseguiuExcluir)
        {
            repositorio.SalvarFabricantes();

            Console.WriteLine("---------------------------------");
            Console.WriteLine($"O registro \"{idSelecionado}\" foi excluído com sucesso.");
            Console.WriteLine("---------------------------------");
        }
        else
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"Não foi possível encontrar o registro \"{idSelecionado}\".");
            Console.WriteLine("---------------------------------");
        }

        Console.Write("Digite ENTER para continuar...");
        Console.ReadLine();
    }

    public void VisualizarTodos()
    {
        Console.Clear();
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Gestão de Fabricantes");
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Visualização de Fabricantes");
        Console.WriteLine("---------------------------------");

        Console.WriteLine(
            "{0, -7} | {1, -15} | {2, -30} | {3, -22} | {4, -10}",
            "Id", "Fabricante", "E-mail", "Telefone", "Produtos"
        );

        Fabricante?[] Fabricantes = repositorio.SelecionarTodos();
        Equipamento?[] equipamentos = repositorioEquipamento!.SelecionarTodos();

        for (int i = 0; i < Fabricantes.Length; i++)
        {
            Fabricante? f = Fabricantes[i];

            if (f == null)
                continue;

            Console.WriteLine(
                "{0, -7} | {1, -15} | {2, -30} | {3, -22} | {4, -10}",
                f.id, f.nome, f.email, f.telefone, f.Produtos(equipamentos)
            );
        }

        Console.WriteLine("---------------------------------");
        Console.Write("Digite ENTER para continuar...");
        Console.ReadLine();
    }
}