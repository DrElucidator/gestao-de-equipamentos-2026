using System;
namespace GestaoDeEquipamentos.ConsoleApp.Dominio;

public class Equipamento
{
    public string? id { get; set; }
    public string? nome { get; set; }
    public string? fabricanteId { get; set; }
    public decimal? precoAquisicao { get; set; }
    public DateTime? dataFabricacao { get; set; }
}