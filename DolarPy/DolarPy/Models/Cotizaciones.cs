﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using DolarPy.Models;
//
//    var cotizaciones = Cotizaciones.FromJson(jsonString);

namespace DolarPy.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Cotizaciones
    {
        [JsonProperty("dolarpy", NullValueHandling = NullValueHandling.Ignore)]
        public Dolarpy Dolarpy { get; set; }

        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Updated { get; set; }
    }

    public partial class Dolarpy
    {
        [JsonProperty("bcp", NullValueHandling = NullValueHandling.Ignore)]
        public Bcp Bcp { get; set; }

        [JsonProperty("bonanza", NullValueHandling = NullValueHandling.Ignore)]
        public Cotizacion Bonanza { get; set; }

        [JsonProperty("cambiosalberdi", NullValueHandling = NullValueHandling.Ignore)]
        public Cotizacion Cambiosalberdi { get; set; }

        [JsonProperty("cambioschaco", NullValueHandling = NullValueHandling.Ignore)]
        public Cotizacion Cambioschaco { get; set; }

        [JsonProperty("eurocambios", NullValueHandling = NullValueHandling.Ignore)]
        public Cotizacion Eurocambios { get; set; }

        [JsonProperty("familiar", NullValueHandling = NullValueHandling.Ignore)]
        public Cotizacion Familiar { get; set; }

        [JsonProperty("gnbfusion", NullValueHandling = NullValueHandling.Ignore)]
        public Cotizacion Gnbfusion { get; set; }

        [JsonProperty("lamoneda", NullValueHandling = NullValueHandling.Ignore)]
        public Cotizacion Lamoneda { get; set; }

        [JsonProperty("maxicambios", NullValueHandling = NullValueHandling.Ignore)]
        public Cotizacion Maxicambios { get; set; }

        [JsonProperty("mundialcambios", NullValueHandling = NullValueHandling.Ignore)]
        public Cotizacion Mundialcambios { get; set; }

        [JsonProperty("mydcambios", NullValueHandling = NullValueHandling.Ignore)]
        public Cotizacion Mydcambios { get; set; }

        [JsonProperty("set", NullValueHandling = NullValueHandling.Ignore)]
        public Cotizacion Set { get; set; }
    }

    public partial class Bcp
    {
        [JsonProperty("compra", NullValueHandling = NullValueHandling.Ignore)]
        public double? Compra { get; set; }

        [JsonProperty("referencial_diario", NullValueHandling = NullValueHandling.Ignore)]
        public double? ReferencialDiario { get; set; }

        [JsonProperty("venta", NullValueHandling = NullValueHandling.Ignore)]
        public long? Venta { get; set; }
    }

    public partial class Cotizacion
    {
        [JsonProperty("compra", NullValueHandling = NullValueHandling.Ignore)]
        public double? Compra { get; set; }

        [JsonProperty("venta", NullValueHandling = NullValueHandling.Ignore)]
        public double? Venta { get; set; }
    }

    public partial class Cotizaciones
    {
        public static Cotizaciones FromJson(string json) => JsonConvert.DeserializeObject<Cotizaciones>(json, DolarPy.Models.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Cotizaciones self) => JsonConvert.SerializeObject(self, DolarPy.Models.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
