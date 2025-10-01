using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ApiSubastasEntity.Utilidades;
using ApiSubastasEntity.Modelos;
using ApiSubastasEntity.Modelos.Extras;
using ApiSubastasEntity.Paginas;
using ApiSubastasEntity.Paginas.AgroPrecios.Detalle;
using HtmlAgilityPack;

namespace ApiSubastasEntity.Paginas.AgroPrecios
{
    public class AgroPrecios : PaginasControl
    {
        public AgroPrecios()
        { }

        public async override Task<List<SubastaDetalleRawDTO>?> GetInformacion(SubastasControl valor, List<SubastaDTO> listSubasta)
        {
            return await valor.GetCortes(listSubasta);
        }

        #region Metodos de Extraccion

        /// <summary>
        /// por defecto los valores para esta seccion se saca del mismo sitio solo que para 4vientos es diferente por lo que entraran parametos diferentes
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="tableName"></param>
        /// <param name="fechaInfoPos"></param>
        /// <returns></returns>
        public static async Task<List<SubastaDetalleRawDTO>?> ExtraerInformacion(SubastaDTO? subastaDTO, string tableName = "tab_pre_pro", string fechaInfoPos = "//td[contains(@class, 'titNombreder')]")
        {

            if (subastaDTO == null)
                return null;

            var html = await SubastasControl.ExtractHtml(subastaDTO.url!);



            return ConvertHtmlToSubastaDetalleRaw(ExtractTableClass(html, tableName), ExtractDate(html, fechaInfoPos), subastaDTO.subastaid, (tableName == "tab_pre_pro" && fechaInfoPos == "//td[contains(@class, 'titNombreder')]") ? true : false);

        }

        

        public static string ExtractTableClass(string html, string tableName)
        {
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(html);

            HtmlNode tablaNode = doc.DocumentNode.SelectSingleNode($"//table[contains(@class, '{tableName}')]");

            if (tablaNode != null)
            {
                return tablaNode.OuterHtml;
            }
            else
            {
                return "fallo";
            }
        }

        public static string ExtractDate(string html, string fechaInfoPos)
        {
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(html);

            HtmlNode? tablaNode = doc.DocumentNode.SelectSingleNode(fechaInfoPos);


            if (tablaNode != null)
            {

                string pattern = @"\b(\d{2}-\d{2}-\d{4})\b";
                Regex regex = new Regex(pattern);

                Match match = regex.Match(tablaNode.OuterHtml);

                if (match.Success)
                {
                    string dateText = match.Groups[1].Value;

                    return dateText;

                }
                else
                {
                    return "fallo";
                }
            }
            else
            {
                return "fallo";
            }
        }

        public static List<SubastaDetalleRawDTO> ConvertHtmlToSubastaDetalleRaw(string html, string fecha, long subastaid, bool eliminarUltimaFila)
        {
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(html);

            var listSubastaDetalleRaw = new List<SubastaDetalleRawDTO>();

            string? nombreFamilia = string.Empty;

            foreach (HtmlNode filaNode in doc.DocumentNode.SelectNodes("//table//tr[position()>0]"))
            {
                var subastaDetalleRaw = new SubastaDetalleRawDTO();

                subastaDetalleRaw.fecha = DateTime.Parse(fecha);
                subastaDetalleRaw.subastaid = subastaid;
                int indiceColumna = 0;

                foreach (HtmlNode celdaNode in filaNode.ChildNodes)
                {

                    string atributos = celdaNode.GetAttributeValue("class", "");

                    // En el caso de que sea una familia
                    if (atributos.Contains("fam"))
                    {
                        nombreFamilia = celdaNode.InnerText.Trim().ToUpper();
                        break;
                    }

                    
                    // En el caso de que sean datos
                    if (celdaNode.Name == "td")
                    {
                        subastaDetalleRaw.nombre_familia = nombreFamilia;

                        switch (indiceColumna)
                        {
                            case 0:
                                subastaDetalleRaw.nombre_genero = celdaNode.InnerText.Trim().ToUpper();
                                break;
                            case 1:
                                subastaDetalleRaw.corte1 = Util.ToDecimal(celdaNode.InnerText.Trim()) / 100;
                                break;
                            case 2:
                                subastaDetalleRaw.corte2 = Util.ToDecimal(celdaNode.InnerText.Trim()) / 100;
                                break;
                            case 3:
                                subastaDetalleRaw.corte3 = Util.ToDecimal(celdaNode.InnerText.Trim()) / 100;
                                break;
                            case 4:
                                subastaDetalleRaw.corte4 = Util.ToDecimal(celdaNode.InnerText.Trim()) / 100;
                                break;
                            case 5:
                                subastaDetalleRaw.corte5 = Util.ToDecimal(celdaNode.InnerText.Trim()) / 100;
                                break;
                            case 6:
                                subastaDetalleRaw.corte6 = Util.ToDecimal(celdaNode.InnerText.Trim()) / 100;
                                break;
                            case 7:
                                subastaDetalleRaw.corte7 = Util.ToDecimal(celdaNode.InnerText.Trim()) / 100;
                                break;
                            case 8:
                                subastaDetalleRaw.corte8 = Util.ToDecimal(celdaNode.InnerText.Trim()) / 100;
                                break;
                            case 9:
                                subastaDetalleRaw.corte9 = Util.ToDecimal(celdaNode.InnerText.Trim()) / 100;
                                break;
                            case 10:
                                subastaDetalleRaw.corte10 = Util.ToDecimal(celdaNode.InnerText.Trim()) / 100;
                                break;
                        }

                        indiceColumna++;

                    }

                }

                if (!string.IsNullOrEmpty(subastaDetalleRaw.nombre_genero) || subastaDetalleRaw.corte1 > 0)
                {
                    listSubastaDetalleRaw.Add(subastaDetalleRaw);
                }


            }

            if (eliminarUltimaFila)
                listSubastaDetalleRaw.RemoveAt(listSubastaDetalleRaw.Count - 1);

            return listSubastaDetalleRaw;
        }

        #endregion

    }
}
