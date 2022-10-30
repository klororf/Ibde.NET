namespace Klororf.ibde.reader.Models;

public class Consumo
{
    public string fechaPeriodo { get; set; }
    public string periodoMuestra { get; set; }
    public Y y { get; set; }
    public string acumulado { get; set; }
    public string acumuladoCO2 { get; set; }
    public string consumoMedio { get; set; }
    public string mostrarBotonComparar { get; set; }
    public string consumoMaximo { get; set; }
    public string posicionConsumoMaximo { get; set; }
    public string periodoConsumoMaximo { get; set; }
    public string mediaDiariaConsumo { get; set; }
}
