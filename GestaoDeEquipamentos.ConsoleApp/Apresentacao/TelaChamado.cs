namespace GestaoDeEquipamentos.ConsoleApp.Apresentacao;
public class TelaChamado
{
    public string? ObterEscolhaMenuPrincipal()
    {
        Console.Clear();
        Console.WriteLine("\nGestão de Chamados\n");
        Console.WriteLine("1 - Cadastrar chamado");
        Console.WriteLine("2 - Editar chamado");
        Console.WriteLine("3 - Excluir chamado");
        Console.WriteLine("4 - Visualizar chamados");
        Console.WriteLine("S - Sair");
        Console.Write("\n> ");
        string? opcaoMenu = Console.ReadLine()?.ToUpper();

        return opcaoMenu;
    }
    public void Cadastrar()
    {
        
    }
    public void Editar()
    {
        
    }
    public void Excluir()
    {
        
    }
    public void VisualizarTodos()
    {
        
    }
}