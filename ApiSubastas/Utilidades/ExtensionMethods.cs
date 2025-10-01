using System.Reflection;
using ApiSubastasEntity.Paginas.AgroPrecios.Detalle;
using ApiSubastasEntity.Paginas.FhAlmeria.Detalle;
using ApiSubastasEntity.Paginas;
using static ApiSubastasEntity.Modelos.Error.ErrorResponse;
using ApiSubastasEntity.Modelos.Error;
using Google.Protobuf.WellKnownTypes;
using ApiSubastasEntity.Modelos.Atributos;
using ApiSubastasEntity.Modelos.Base;
using System.ComponentModel.DataAnnotations;
using Org.BouncyCastle.Asn1.Cmp;
using Microsoft.AspNetCore.Mvc;

namespace ApiSubastasEntity.Utilidades;

public static class ExtensionMethods
{
    public static string GetCustomAttribute<T>(this object enumValue)
    {
        object[] customAttributes = GetCustomAtributes<T>(enumValue);
        if (customAttributes.Length != 0)
        {
            return ((T)customAttributes[0]).ToString();
        }
        

        return string.Empty;
    }

    public static string GetValorString(this IConfiguration configuration, string seccion, string valor)
    {
        return configuration?.GetSection(seccion)[valor] ?? string.Empty;
    }


    public static ErrorResponse? GetError(this TypeError error)
    {

        object[] customAttributes = GetCustomAtributes<ErrorType>(error);
        if (customAttributes.Length != 0)
        {
            return Activator.CreateInstance(((ErrorType)customAttributes[0]).value) as ErrorResponse;
        }
        

        return null;
    }


    public static T Result<T>(this ActionResult result)
    {
        if (result is OkObjectResult)
        {
            return (T)((OkObjectResult)result).Value;
        }
        else
        {

        }

        return default;
    }

    public static T Result<T>(this ActionResult<T> result)
    {
        if (result is not null)
        {

            if (result.Result is OkObjectResult objectResult)
                return objectResult.Value is null ? default : (T)objectResult.Value;

            return result.Value;
        }

        return default;
    }

    public static List<T> Result<T>(this ActionResult<List<T>> result)
    {
        if (result is not null)
        {

            if (result.Result is OkObjectResult objectResult)
                return objectResult.Value as List<T>;

            return result.Value;
        }

        return null;
    }

    public static bool checkResult(this IActionResult resultado)
    {
        if (resultado is BadRequestResult || resultado is BadRequestObjectResult)
            return false;
        return true;
    }


    #region Private Methods


    private static object[] GetCustomAtributes<T>(object value)
    {
        MemberInfo[] member = value.GetType().GetMember(value.ToString());
        if (member.Length != 0)
        {
            object[] customAttributes = member[0].GetCustomAttributes(typeof(T), inherit: false);

            return customAttributes;

        }

        return new object[0];
    }

    #endregion

}

