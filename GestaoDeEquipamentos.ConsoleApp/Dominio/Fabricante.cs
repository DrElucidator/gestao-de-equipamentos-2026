using System;
namespace GestaoDeEquipamentos.ConsoleApp.Dominio;

public class Fabricante
{
    public string? id {get; set;}
    public string? nome {get; set;}
    public string? email {get; set;}
    public string? telefone {get; set;}

    public int Produtos(Equipamento?[] equipamentos)
    {
        int quantidadeEquipamento = 0;

        for (int i = 0; i < equipamentos.Length; i++)
        {
            Equipamento? equipamento = equipamentos[i];

            if (equipamento == null)
                continue;

            if (equipamento.fabricanteId == id)
                quantidadeEquipamento++;
        }

        return quantidadeEquipamento;
    }
}