namespace Klororf.ibde.reader.Models;

public class ComsumoDia
{
    public DateTime Dia { get; set; }
    public IEnumerable<ComsumoHora> Comsumos { get; set; }
}
