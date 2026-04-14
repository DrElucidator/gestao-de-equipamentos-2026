using System;
using System.Security.Cryptography;
using GestaoDeEquipamentos.ConsoleApp.Dominio;

namespace GestaoDeEquipamentos.ConsoleApp.Infraestrutura;

public class RepositorioEquipamento
{
    public Equipamento?[] equipamentos = new Equipamento[100];
    private const string caminhoArquivo = "listaEquipamentos";

    public void CarregarEquipamentos()
    {
        List<Equipamento> equipamentosSalvos = RepositorioFabricante.Carregar<Equipamento>(caminhoArquivo);

        for (int i = 0; i < equipamentos.Length; i++)
            equipamentos[i] = null;

        for (int i = 0; i < equipamentosSalvos.Count && i < equipamentos.Length; i++)
            equipamentos[i] = equipamentosSalvos[i];
    }

    public void SalvarEquipamentos()
    {
        List<Equipamento> lista = new List<Equipamento>();

        for (int i = 0; i < equipamentos.Length; i++)
        {
            if (equipamentos[i] != null)
                lista.Add(equipamentos[i]!);
        }

        RepositorioFabricante.Salvar(caminhoArquivo, lista);
    }

    public void Cadastrar(Equipamento novoEquipamento)
    {
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
    }

    public bool Editar(string idSelecionado, Equipamento novoEquipamento)
    {
        Equipamento? equipamentoSelecionado = SelecionarPorId(idSelecionado);

        if (equipamentoSelecionado == null)
            return false;

        equipamentoSelecionado.nome = novoEquipamento.nome;
        equipamentoSelecionado.fabricanteId = novoEquipamento.fabricanteId;
        equipamentoSelecionado.precoAquisicao = novoEquipamento.precoAquisicao;
        equipamentoSelecionado.dataFabricacao = novoEquipamento.dataFabricacao;

        return true;
    }

    public bool Excluir(string idSelecionado)
    {
        for (int i = 0; i < equipamentos.Length; i++)
        {
            Equipamento? e = equipamentos[i];

            if (e == null)
                continue;

            if (e.id == idSelecionado)
            {
                equipamentos[i] = null;
                return true;
            }
        }

        return false;
    }

    public Equipamento? SelecionarPorId(string idSelecionado)
    {
        Equipamento? equipamentoSelecionado = null;

        for (int i = 0; i < equipamentos.Length; i++)
        {
            Equipamento? e = equipamentos[i];

            if (e == null)
                continue;

            if (e.id == idSelecionado)
            {
                equipamentoSelecionado = e;
                break;
            }
        }

        return equipamentoSelecionado;
    }

    public Equipamento?[] SelecionarTodos()
    {
        return equipamentos;
    }
}