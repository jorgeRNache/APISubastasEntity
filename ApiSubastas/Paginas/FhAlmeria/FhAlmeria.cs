using System.Collections.Generic;
using System.Security.Policy;
using System.Text.RegularExpressions;
using ApiSubastasEntity.Modelos;
using ApiSubastasEntity.Modelos.Extras;
using ApiSubastasEntity.Utilidades;
using HtmlAgilityPack;
namespace ApiSubastasEntity.Paginas.FhAlmeria
{
    public class FhAlmeria : PaginasControl
    {
        public FhAlmeria()
        { }

        public async override Task<List<SubastaDetalleRawDTO>?> GetInformacion(SubastasControl valor, List<SubastaDTO> listSubasta)
        {
            return await valor.GetCortes(listSubasta);
        }



        #region Metodos Extracion

       
        private static decimal ExtraerNumeroDeFoto(string atributosHijo)
        {
            //te devuelve todos los numeros
            //MatchCollection matches = Regex.Matches(atributosHijo, @"?\d+");
            //te hace un grupo con - o sin - el grupo 1 sera el que tenga guion que es el que queremos
            MatchCollection matches = Regex.Matches(atributosHijo, @"-(\d+)");

            int contador = 0;
            decimal decimales = 0;
            decimal entero = 0;
            decimal valorFinal = 0;
            foreach (Match match in matches)
            {
                string valores = match.Groups[1].Value;

                if (contador == 0)
                {
                    //el primer valor te da los decimales
                    //podria ponerlo con el tryparse y esas cosas pero quiero que explote si falla
                    decimales = (decimal.Parse(valores) / 40) / 100;
                }

                if (contador == 1)
                {
                    entero = (decimal.Parse(valores) / 20);
                    valorFinal = entero + decimales;
                }
                contador++;
            }


            return valorFinal;
        }

        private static void AsignarNombreGenero(SubastaDetalleRawDTO subastaLinea, HtmlNode celdaNode)
        {
            //Nombre del genero
            if (celdaNode.Attributes.Contains("data-title"))
            {
                string titulo = celdaNode.GetAttributeValue("data-title", "");

                if (titulo == "Producto")
                {
                    subastaLinea.nombre_genero = ValoresConstantes.GetNombreGeneroNormalizado(celdaNode.InnerText.ToUpper());
                }
            }
        }

        public async static Task<List<SubastaDetalleRawDTO>> ExtraerInformacion(SubastaDTO subastaJson, List<SubastaDTO> listSubasta, bool almeria = false)
        {
            HtmlDocument htmldoc = new HtmlDocument();

            string myURL = await SubastasControl.ExtractHtml(subastaJson.url);

            htmldoc.LoadHtml(myURL);

            HtmlNodeCollection tablaNodesTitulo = htmldoc.DocumentNode.SelectNodes("//h3/strong | //h3/strong/following-sibling::strong");

            HtmlNodeCollection tablaNodes = htmldoc.DocumentNode.SelectNodes("//table[contains(@class, 'pizarra_precios')]");

            List<SubastaDetalleRawDTO> listSubastaRaw = new List<SubastaDetalleRawDTO>();

            if (tablaNodes == null)
                return listSubastaRaw;

            int contadorTitulos = 0;

            foreach (var tablaNode in tablaNodes!)
            {

                HtmlDocument doc = new HtmlDocument();
                doc.LoadHtml(tablaNode.OuterHtml);

                var fecha_subasta = DateTime.Now.ToString("yyyy-MM-dd");
                var nombre_subasta = tablaNodesTitulo[contadorTitulos].InnerText + "";

                //Colocamos las cabeceras de la subasta
                //vamos a coger solo las subastas que tengamos registradas
                if (!ValoresConstantes._dicNombresFHAlmeria.ContainsKey(nombre_subasta))
                {
                    contadorTitulos += almeria ? 3 : 2;
                    continue;
                }

                contadorTitulos++;

                fecha_subasta = tablaNodesTitulo[contadorTitulos].InnerText + "";

                contadorTitulos++;
                    

                foreach (HtmlNode filaNode in doc.DocumentNode.SelectNodes("//table//tr[position()]"))
                {

                    //Instanciamos el objeto de las lineas de la subasta
                    SubastaDetalleRawDTO subastalin = new SubastaDetalleRawDTO();

                    subastalin.subastaid = listSubasta.Find(x => x.url == ValoresConstantes.NormalizacionNombreSubastaFHAlmeria(nombre_subasta))?.subastaid ?? 0;

                    subastalin.fecha = DateTime.Parse(fecha_subasta);

                    if (!filaNode.ChildNodes.Any(p => p.Name == "td"))
                        continue;

                    int contadorPosicion = 0;

                    foreach (HtmlNode celdaNode in filaNode.ChildNodes.Where(p => p.Name == "td"))
                    {

                        AsignarNombreGenero(subastalin, celdaNode);


                        foreach (var hijo in celdaNode.ChildNodes.Where(p => p.Attributes.Contains("style")))
                        {
                            string atributosHijo = hijo.GetAttributeValue("style", "");

                            if (!atributosHijo.Contains("numeros.png"))
                                continue;

                            decimal valor = ExtraerNumeroDeFoto(atributosHijo);

                            switch (++contadorPosicion)
                            {
                                case 1:
                                    subastalin.corte1 = valor;
                                    break;
                                case 2:
                                    subastalin.corte2 = valor;
                                    break;
                                case 3:
                                    subastalin.corte3 = valor;
                                    break;
                                case 4:
                                    subastalin.corte4 = valor;
                                    break;
                                case 5:
                                    subastalin.corte5 = valor;
                                    break;
                                case 6:
                                    subastalin.corte6 = valor;
                                    break;
                                case 7:
                                    subastalin.corte7 = valor;
                                    break;
                                case 8:
                                    subastalin.corte8 = valor;
                                    break;
                                case 9:
                                    subastalin.corte9 = valor;
                                    break;
                                case 10:
                                    subastalin.corte10 = valor;
                                    break;
                                case 11:
                                    subastalin.corte11 = valor;
                                    break;
                                case 12:
                                    subastalin.corte12 = valor;
                                    break;
                                case 13:
                                    subastalin.corte13 = valor;
                                    break;
                                case 14:
                                    subastalin.corte14 = valor;
                                    break;
                                case 15:
                                    subastalin.corte15 = valor;
                                    break;

                            }     
                        }
                    }

                    if (!string.IsNullOrWhiteSpace(subastalin.nombre_genero))
                        listSubastaRaw.Add(subastalin);
                }
            }
            
            return listSubastaRaw;
        }

        

        #endregion
    }
}
