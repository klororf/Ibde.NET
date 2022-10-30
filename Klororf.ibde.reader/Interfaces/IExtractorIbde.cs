using Klororf.ibde.reader.Models;

namespace Klororf.ibde.reader.Interfaces;

public interface IExtractorIbde
{
    public Task<IEnumerable<ComsumoDia>> GetData(string user, string passwd, DateTime dateStart);
}
