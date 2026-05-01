using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema5
{
    public class WholesaleSale : Sale
    {
          public override decimal CalculateTotal()
        {
            decimal total = base.CalculateTotal();
            
                total *= 0.9m; // Aplicar un descuento del 10%
            
            return total;
        }
    }
}
