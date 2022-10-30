namespace Klororf.ibde.reader.Models;

public class Y
{
    public List<string> vars { get; set; }
    public List<object> smps { get; set; }
    public List<string> desc { get; set; }
    public List<List<Data>> data { get; set; }
    public List<object> dataExcluido { get; set; }
    public string unidadesConsumo { get; set; }
}
