using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema1
{
    internal partial class ProductHelper
    {
        public string GenerarTexto(long code, string description, decimal price)
        {
            return $"[{code}] {description} - {price:C2}";
        }
    }
}
