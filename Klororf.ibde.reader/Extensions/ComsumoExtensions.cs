using Klororf.ibde.reader.Models;

namespace Klororf.ibde.reader.Extensions;

internal static class ComsumoExtensions
{
    internal static IEnumerable<ComsumoDia> ConvertToDays(this Consumo consumos, DateTime fechaBase)
    {
        int numberOfDays = consumos.y.data[0].Count / 24;
        ComsumoDia[] consumosDia = new ComsumoDia[numberOfDays];
        for (var i = 0; i < consumosDia.Length; i++)
        {
            consumosDia[i] = new();
            consumosDia[i].Comsumos = new List<ComsumoHora>();
            consumosDia[i].Dia = fechaBase;
            int hora = 0;
            for (var pos = i * 24; pos < (i + 1) * 24; pos++)
            {
                var value = consumos.y.data[0][pos];
                consumosDia[i].Comsumos = consumosDia[i].Comsumos.Append(new() { Hora = hora, Kw = value != null ? value.ValorKw : 0f });
                hora++;
            }
            fechaBase = fechaBase.AddDays(1);
        }
        return consumosDia;
    }
}
