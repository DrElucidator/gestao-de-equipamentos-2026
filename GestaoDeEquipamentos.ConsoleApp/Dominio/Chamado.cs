namespace GestaoDeEquipamentos.ConsoleApp.Dominio;

public class Chamado
{
    public string? id { get; set; }
    public string? titulo { get; set; }
    public string? descricao { get; set; }
    public DateTime? dataAbertura { get; set; }
    public Equipamento? equipamento { get; set; }

    public int ObterDiasDecorridos()
    {
        TimeSpan diferencaTempo = DateTime.Now.Subtract(dataAbertura.Value);
        return diferencaTempo.Days;
    }
}