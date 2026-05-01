using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema3
{
    public class Problema3
    {
        public string CompararCopias(int originalValue, Product product)
        {
            int variableLocal = originalValue;
            variableLocal++;
            Product copiaProduct = product;
            copiaProduct.SetDescription("Cambio de descripcion");

            return $"{originalValue}-{variableLocal}-{copiaProduct.Description}";
        }
    }
}
