using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolarPy.Core.Models
{
    public class ExchangeRate
    {
        public string Provider { get; set; }
        public decimal Compra { get; set; }
        public decimal Venta { get; set; }
        public decimal ReferencialDiario { get; set; }

        public string CompraFormatted => $"₲ {Compra:N2}";
        public string VentaFormatted => $"₲ {Venta:N2}";
        public string ReferencialFormatted => ReferencialDiario > 0 ? $"₲ {ReferencialDiario:N2}" : null;
        public bool HasReferencial => ReferencialDiario > 0;


    }
}
