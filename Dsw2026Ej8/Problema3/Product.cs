using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema3
{
    internal class Product
    {
        public string Description { get; private set; }
        public Product(string initialDescription)
        {
            Description = initialDescription;
        }
        public void SetDescription(string newDescription)
        {
            Description = newDescription;
        }
    }
}
