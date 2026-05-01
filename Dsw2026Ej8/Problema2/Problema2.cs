using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema2
{
    public class Problema2
    {
        public string CrearResumenVenta(long productCode, string productDescription, int quantity, decimal unitPrice)
        {
            var Total = quantity * unitPrice;
            if (quantity <= 0m) { Total = 0m; }
            long Code = productCode;
            string Description = productDescription;
            int Quantity = quantity;

            var claseAnonima = new { Code, Description, Quantity, Total };

            return $"{claseAnonima.Code}-{claseAnonima.Description}-{claseAnonima.Total}";
        }

    }
}
