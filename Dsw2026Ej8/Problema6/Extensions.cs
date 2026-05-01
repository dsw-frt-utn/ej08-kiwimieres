using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema6
{
//    el método de extensión debe:
//○ eliminar espacios al inicio y al final,
//○ convertir el texto a mayúsculas,
//○ reemplazar espacios internos por guiones.
//● Si el código es null, debe retornar "SIN-CODIGO".

    public static class Extensions
    {
        public static string ToProductCode(this string str)
        {
            if (str == null) return "SIN-CODIGO";
            return str.Trim().ToUpper().Replace("", "-");
        }
    }
}
