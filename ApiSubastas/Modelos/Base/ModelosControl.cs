using System.Reflection;
using System.Text.Json.Serialization;
using ApiSubastasEntity.Modelos.Atributos;
using ApiSubastasEntity.Utilidades;

namespace ApiSubastasEntity.Modelos.Base
{
    public class ModelosControl
    {


        #region Public Method

      
        public void AutoMapper(ModelosControl modeloTraspaso)
        {
            Util.AutoMapper(this, modeloTraspaso);
        }

        /// <summary>
        /// Te devuelve todos los atributos de la clase
        /// </summary>
        /// <returns></returns>
        public string[] GetPropiedadesString()
        {

            PropertyInfo[] propiedades = GetPropiedades();

            List<string> valores = new List<string>();

            foreach (var prop in propiedades)
            {
                valores.Add(prop.Name);
            }

            return valores.ToArray();
        }


        /// <summary>
        /// si pones el valorid en true entonces te devulvera todas las propiedades incluidas el id de la tabla con sus respectivos valores introducidos
        /// </summary>
        /// <param name="valorID"></param>
        /// <returns></returns>
        public Dictionary<string, object?> PropiedadesDic(bool valorID = false)
        {
            PropertyInfo[] propiedades = GetPropiedades();

            var dicValores = new Dictionary<string, object?>();

            foreach (var prop in propiedades)
            {
                if (!valorID)
                {
                    if (GetAtributeValue<PrimaryKey>(prop))
                        continue;
                }

                dicValores.Add(prop.Name, prop.GetValue(this));
                    
            }

            return dicValores;

        }


        public string GetPrimaryKeyID()
        {
            PropertyInfo[] propiedades = GetPropiedades();

            return propiedades.Where(p => GetAtributeValue<PrimaryKey>(p)).Select(p => p.Name).FirstOrDefault() + "";
        }

        public long GetPrimaryKeyValorID()
        {
            PropertyInfo[] propiedades = GetPropiedades();

            return Util.ToLong(propiedades.Where(p => GetAtributeValue<PrimaryKey>(p)).Select(p => p.GetValue(this)).FirstOrDefault());
        }

        #endregion


        #region Private Methods

        private PropertyInfo[] GetPropiedades()
        {
            //con esto de aqui evitamos que coja los parametros de la herencia y solo coja los parametros del objeto instanciado
            return this.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);

        }


        private bool GetAtributeValue<T>(PropertyInfo propiedad)
        {
            return Attribute.IsDefined(propiedad, typeof(T));
        }


        #endregion

    }
}
