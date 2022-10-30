using Klororf.ibde.reader.Extensions;
using Klororf.ibde.reader.Interfaces;
using Klororf.ibde.reader.Models;
using Newtonsoft.Json;
namespace Klororf.ibde.reader.Services;

public class ExtractorIbde : IExtractorIbde
{
    private const string DATA_LOGIN = "[\"{0}\",\"{1}\",null,\"Linux -\",\"PC\",\"Chrome 77.0.3865.90\",\"0\",\"\",\"s\"]";
    private const string URL_CONSUMO_PERIODO = "consumidores/rest/consumoNew/obtenerDatosConsumoPeriodo/fechaInicio/{0}00:00:00/fechaFinal/{1}00:00:00/";
    private readonly HttpClient httpClient;
    public ExtractorIbde(HttpClient client)
    {
        this.httpClient = client;
    }
    public async Task<IEnumerable<ComsumoDia>> GetData(string user, string passwd, DateTime dateStart)
    {
        await Login(user, passwd);
        string query = string.Format(URL_CONSUMO_PERIODO, dateStart.ToString("dd-MM-yyyy"), DateTime.Now.AddDays(0).ToString("dd-MM-yyyy"));
        HttpResponseMessage res = await httpClient.GetAsync(query);
        string ret = await res.Content.ReadAsStringAsync();
        Consumo convert = JsonConvert.DeserializeObject<Consumo>(ret) ?? throw new ArgumentNullException();
        return convert.ConvertToDays(dateStart);
    }
    private async Task Login(string user, string passwd)
    {
        string headersLogin = string.Format(DATA_LOGIN, user, passwd);
        HttpResponseMessage res = await httpClient.PostAsync("consumidores/rest/loginNew/login", new StringContent(headersLogin, System.Text.Encoding.UTF8, "application/json"));
        if (!res.IsSuccessStatusCode)
            throw new HttpRequestException("Login failure");
    }
}
