namespace Klororf.ibde.reader.Models;

public class Data{
    public string Valor {get; set;}
    public string Tipo {get; set;}
    public bool Excluido {get; set;}
    public float ValorFloat => float.Parse(this.Valor.Replace(".",","));
    public float ValorKw => this.ValorFloat/1000;
    private float GetValorFLoat(string value){
        float v = 0f;
        if(float.TryParse(value ,out v))
            return v;
        else
            return 0f;
    }
}