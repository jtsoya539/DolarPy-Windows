namespace DolarPy.Services
{
    public class DolarPyService
    {
        public async Task<Cotizaciones> GetCotizaciones()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "https://dolar.melizeche.com/api/1.0/");
            request.Headers.Add("accept", "application/json");

            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            var cotizaciones = Cotizaciones.FromJson(await response.Content.ReadAsStringAsync());

            return cotizaciones;
        }

        public async Task<IEnumerable<ProviderDetail>> GetItems()
        {
            var cotizaciones = await GetCotizaciones();

            var result = new List<ProviderDetail>
            {
                new ProviderDetail { Nombre = "BCP", Compra = cotizaciones.Dolarpy.Bcp.Compra, Venta = cotizaciones.Dolarpy.Bcp.Venta, ReferencialDiario = cotizaciones.Dolarpy.Bcp.ReferencialDiario},
                new ProviderDetail { Nombre = "BONANZA CAMBIOS", Compra = cotizaciones.Dolarpy.Bonanza.Compra, Venta = cotizaciones.Dolarpy.Bonanza.Venta},
                new ProviderDetail { Nombre = "CAMBIOS ALBERDI", Compra = cotizaciones.Dolarpy.Cambiosalberdi.Compra, Venta = cotizaciones.Dolarpy.Cambiosalberdi.Venta},
                new ProviderDetail { Nombre = "CAMBIOS CHACO", Compra = cotizaciones.Dolarpy.Cambioschaco.Compra, Venta = cotizaciones.Dolarpy.Cambioschaco.Venta},
                new ProviderDetail { Nombre = "EURO CAMBIOS", Compra = cotizaciones.Dolarpy.Eurocambios.Compra, Venta = cotizaciones.Dolarpy.Eurocambios.Venta},
                new ProviderDetail { Nombre = "FAMILIAR", Compra = cotizaciones.Dolarpy.Familiar.Compra, Venta = cotizaciones.Dolarpy.Familiar.Venta},
                new ProviderDetail { Nombre = "GNB", Compra = cotizaciones.Dolarpy.Gnbfusion.Compra, Venta = cotizaciones.Dolarpy.Gnbfusion.Venta},
                new ProviderDetail { Nombre = "LA MONEDA CAMBIOS", Compra = cotizaciones.Dolarpy.Lamoneda.Compra, Venta = cotizaciones.Dolarpy.Lamoneda.Venta},
                new ProviderDetail { Nombre = "MAXICAMBIOS", Compra = cotizaciones.Dolarpy.Maxicambios.Compra, Venta = cotizaciones.Dolarpy.Maxicambios.Venta},
                new ProviderDetail { Nombre = "MUNDIAL CAMBIOS", Compra = cotizaciones.Dolarpy.Mundialcambios.Compra, Venta = cotizaciones.Dolarpy.Mundialcambios.Venta},
                new ProviderDetail { Nombre = "MYD CAMBIOS", Compra = cotizaciones.Dolarpy.Mydcambios.Compra, Venta = cotizaciones.Dolarpy.Mydcambios.Venta},
                new ProviderDetail { Nombre = "DNIT", Compra = cotizaciones.Dolarpy.Set.Compra, Venta = cotizaciones.Dolarpy.Set.Venta}
            };

            return result;
        }
    }
}
