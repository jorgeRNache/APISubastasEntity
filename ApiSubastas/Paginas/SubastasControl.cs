using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiSubastasEntity.Modelos.Extras;
using Newtonsoft.Json.Linq;
using ApiSubastasEntity.Utilidades;
using Newtonsoft.Json;
using ApiSubastasEntity.Modelos;
using ApiSubastasEntity.Modelos.Atributos;

namespace ApiSubastasEntity.Paginas
{
    public abstract class SubastasControl
    {

        #region Abstrac Metohds

        public abstract PaginasControl pagina { get; } 

        public abstract Task<List<SubastaDetalleRawDTO>?> GetCortes(List<SubastaDTO> listSubasta);

        #endregion

        #region Public Metods



        public static SubastaDTO? GetSubasta(ValoresConstantes.subastasENUM direccion, List<SubastaDTO> listSubasta)
        {
            string nombre = direccion.GetCustomAttribute<SearchValue>();

            SubastaDTO? subasta = listSubasta.Find(subasta => subasta.nombre_subasta == nombre);

            return subasta ?? null;

            //string relativePath = @"Paginas\DireccionesUrl.json";

            ////cuando se vaya a publicar esta linea se puede quitar pero es para que cuando este en debug no me trolee
            //string urlBase = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug\\net8.0\\", "");

            //string fullPath = Path.Combine(urlBase, relativePath);

            //if (!File.Exists(fullPath))
            //{
            //    Console.WriteLine("El archivo JSON no existe en: " + fullPath);
            //    return null;
            //}

            //string jsonContent = File.ReadAllText(fullPath);


            //var dicSubastasUrls = JsonConvert.DeserializeObject<Dictionary<string, SubastaJSON>>(jsonContent);


            //if (dicSubastasUrls is not null)
            //{
            //    if (dicSubastasUrls.ContainsKey(direccion.ToString()))
            //    {
            //        return dicSubastasUrls[direccion.ToString()]!;
            //    } 
            //}

            return null;

        }

        public static async Task<string> ExtractHtml(string url)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage response = await httpClient.GetAsync(url);

                response.EnsureSuccessStatusCode();

                return await response.Content.ReadAsStringAsync();
            }
        }

        #endregion

        #region Private Methods

       


        #endregion
    }
}
