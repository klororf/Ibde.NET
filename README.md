# Ibde.NET
Lector de IDE de Iberdrola para .Net (NO OFICIAL)

Lector de los datos de consumo de la web de Iberdrola distribuidores.

## Uso como servicio

Se ha desarrollado principalmente para integrarse como servicio scoped desde cualquier proyecto

## Advertencia

## Un uso continuado de peticiones puede conllevar un baneo del usuario usado, no me hago cargo del uso inadecuado y los correspondientes baneos por parte de iberdrola.



### Este proyecto intenta ser una implementación basica en .Net del extractor en python del repo de hectorespert: 
[Repo](https://github.com/hectorespert/python-oligo)


Muchas gracias a sus creadores

## Ejemplo de uso desde consola

```c#
using IHost host = Host.CreateDefaultBuilder(args)
.ConfigureServices((_,services)=>{
services.ConfigureIbde();
}).Build();

var ibde = host.Services.GetRequiredService<IExtractorIbde>();
var consumos = await ibde.GetData("[USUARIO]","[CONTRASEÑA]",new DateTime(2022,09,27));


