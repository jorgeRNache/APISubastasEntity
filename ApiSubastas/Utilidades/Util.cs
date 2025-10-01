using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ApiSubastasEntity.Modelos.Base;
using Microsoft.AspNetCore.Mvc;

namespace ApiSubastasEntity.Utilidades
{
    public static class Util
    {
        public static decimal ToDecimal(string? valor)
        {
            decimal valorParseado = 0;

            if (!string.IsNullOrEmpty(valor))
            {
                decimal.TryParse(valor, out valorParseado);
            }

            return valorParseado;
        }


        public static long ToLong(object? valor)
        {
            long valorParseado = 0;

            if (valor is not null)
            {
                long.TryParse(valor.ToString(), out valorParseado);
            }

            return valorParseado;
        }


       public static void AutoMapper(ModelosControl modeloBase, ModelosControl modeloTraspaso)
        {
            Type typeBase = modeloBase.GetType();

            PropertyInfo [] propiedadesBase = typeBase.GetProperties(BindingFlags.Instance | BindingFlags.Public);

            Dictionary<string, object?> dicTraspaso = modeloTraspaso.PropiedadesDic();

            foreach(PropertyInfo propiedad in propiedadesBase)
            {
                if (dicTraspaso.ContainsKey(propiedad.Name))
                    propiedad.SetValue(modeloBase, dicTraspaso[propiedad.Name]);
            }
        }

        

    }
}
