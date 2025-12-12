using DolarPy.Core.Models;
using MvvmCross.Core.ViewModels;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DolarPy.Core.ViewModels
{
    public class ExchangeRatesViewModel : MvxViewModel
    {
        private ObservableCollection<ExchangeRate> _rates;
        public ObservableCollection<ExchangeRate> Rates
        {
            get => _rates;
            set => SetProperty(ref _rates, value);
        }

        private string _lastUpdated;
        public string LastUpdated
        {
            get => _lastUpdated;
            set => SetProperty(ref _lastUpdated, value);
        }


        public override async Task Initialize()
        {
            await base.Initialize();
            //LoadRates();
            await LoadRatesFromApi();
        }

        private void LoadRates()
        {
            Rates = new ObservableCollection<ExchangeRate>
            {
                new ExchangeRate { Provider = "CAMBIOS CHACO", Compra = 80859750, Venta = 83699100 },
                new ExchangeRate { Provider = "CAMBIOS ALBERDI", Compra = 80859750, Venta = 82958400 },
                new ExchangeRate { Provider = "MAXICAMBIOS", Compra = 80859750, Venta = 83699100 },
                // Agrega más según sea necesario
            };
        }

        public async Task LoadRatesFromApi()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var url = "https://dolar.melizeche.com/api/1.0/";
                    var response = await client.GetStringAsync(url);

                    var json = JObject.Parse(response);
                    var dolarpy = json["dolarpy"];
                    var updated = json["updated"]?.ToString();

                    var list = new ObservableCollection<ExchangeRate>();

                    foreach (var property in dolarpy.Children<JProperty>())
                    {
                        var providerName = property.Name;
                        var compraStr = property.Value["compra"]?.ToString();
                        var ventaStr = property.Value["venta"]?.ToString();
                        var referencialDiarioStr = property.Value["referencial_diario"]?.ToString();

                        if (string.IsNullOrEmpty(referencialDiarioStr))
                        {
                            referencialDiarioStr = "0";
                        }

                        if (decimal.TryParse(compraStr, NumberStyles.Any, CultureInfo.InvariantCulture, out var compra) &&
                            decimal.TryParse(ventaStr, NumberStyles.Any, CultureInfo.InvariantCulture, out var venta) &&
                            decimal.TryParse(referencialDiarioStr, NumberStyles.Any, CultureInfo.InvariantCulture, out var referencialDiario))
                        {
                            list.Add(new ExchangeRate
                            {
                                Provider = providerName.ToUpperInvariant(),
                                Compra = compra,
                                Venta = venta,
                                ReferencialDiario = referencialDiario
                            });
                        }
                    }

                    Rates = list;
                    LastUpdated = updated;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error al cargar datos: {ex.Message}");
            }
        }



    }
}
