using Klororf.ibde.reader.Interfaces;
using Klororf.ibde.reader.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Klororf.ibde.reader;
public static class ExtractorIbdeConfiguration
{
    public static IServiceCollection ConfigureIbde(this IServiceCollection services){
        services.AddScoped<IExtractorIbde,ExtractorIbde>();
        services.AddHttpClient<IExtractorIbde,ExtractorIbde>(conf => {conf.BaseAddress = new Uri("https://www.i-de.es/");});

        return services;
    }

}
