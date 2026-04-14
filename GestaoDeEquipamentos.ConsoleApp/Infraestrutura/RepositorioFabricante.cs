using System.Text.Json;
using System.Security.Cryptography;
using GestaoDeEquipamentos.ConsoleApp.Dominio;
namespace GestaoDeEquipamentos.ConsoleApp.Infraestrutura;

public class RepositorioFabricante
{
    public static void Salvar<T>(string caminhoArquivo, List<T> lista)
    {
        string json = JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(caminhoArquivo + ".json", json);
    }

    public static List<T> Carregar<T>(string caminhoArquivo)
    {
        if (File.Exists(caminhoArquivo + ".json"))
        {
            string json = File.ReadAllText(caminhoArquivo + ".json");
            return JsonSerializer.Deserialize<List<T>>(json) ?? new List<T>();
        }

        return new List<T>();
    }

    private const string caminhoArquivo = "listaFabricantes";
    public Fabricante?[] fabricantes = new Fabricante[100];

    public void CarregarFabricantes()
    {
        List<Fabricante> fabricantesSalvos = Carregar<Fabricante>(caminhoArquivo);

        for (int i = 0; i < fabricantes.Length; i++)
            fabricantes[i] = null;

        for (int i = 0; i < fabricantesSalvos.Count && i < fabricantes.Length; i++)
            fabricantes[i] = fabricantesSalvos[i];
    }

    public void SalvarFabricantes()
    {
        List<Fabricante> lista = new List<Fabricante>();

        for (int i = 0; i < fabricantes.Length; i++)
        {
            if (fabricantes[i] != null)
                lista.Add(fabricantes[i]!);
        }

        Salvar(caminhoArquivo, lista);
    }

    public void Cadastrar(Fabricante novoFabricante)
    {
        novoFabricante.id = Convert
            .ToHexString(RandomNumberGenerator.GetBytes(20))
            .ToLower()
            .Substring(0, 7);

        for (int i = 0; i < fabricantes.Length; i++)
        {
            Fabricante? f = fabricantes[i];

            if (f == null)
            {
                fabricantes[i] = novoFabricante;
                break;
            }
        }
    }
    public bool Editar(string idSelecionado, Fabricante novoFabricante)
    {
        Fabricante? fabricanteSelecionado = SelecionarPorId(idSelecionado);

        if (fabricanteSelecionado == null)
            return false;

        fabricanteSelecionado.nome = novoFabricante.nome;
        fabricanteSelecionado.email = novoFabricante.email;
        fabricanteSelecionado.telefone = novoFabricante.telefone;

        return true;
    }

    public bool Excluir(string idSelecionado)
    {
        for (int i = 0; i < fabricantes.Length; i++)
        {
            Fabricante? f = fabricantes[i];

            if (f == null)
                continue;

            if (f.id == idSelecionado)
            {
                fabricantes[i] = null;
                return true;
            }
        }

        return false;
    }

    public Fabricante? SelecionarPorId(string idSelecionado)
    {
        Fabricante? fabricanteSelecionado = null;

        for (int i = 0; i < fabricantes.Length; i++)
        {
            Fabricante? f = fabricantes[i];

            if (f == null)
                continue;

            if (f.id == idSelecionado)
            {
                fabricanteSelecionado = f;
                break;
            }
        }

        return fabricanteSelecionado;
    }

    public Fabricante?[] SelecionarTodos()
    {
        return fabricantes;
    }
}