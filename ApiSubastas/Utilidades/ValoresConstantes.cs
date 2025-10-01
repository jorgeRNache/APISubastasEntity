using ApiSubastasEntity.Paginas.AgroPrecios.Detalle;
using ApiSubastasEntity.Paginas.FhAlmeria.Detalle;
using ApiSubastasEntity.Paginas;
using ApiSubastasEntity.Modelos.Atributos;

namespace ApiSubastasEntity.Utilidades
{
    public static class ValoresConstantes
    {
        public static Dictionary<long, SubastasControl> _dicSubastas = new Dictionary<long, SubastasControl>()
        {
            { 1, new AgroEjido() },
            { 2, new Casi() },
            { 3, new VegaCanada() },
            { 4, new AgrodoloresAdra() },
            { 5, new CostaAlmeriaCehorpa() },
            { 6, new AgrupaEjidoLaRedonda() },
            { 7, new AgroPoniendoLaRedonda() },
            { 8, new UnionLaRedonda() },
            { 9, new CostaAlmeriaRoquetas() },
            { 10, new Union4Vientos() },
            { 11, new Agrupa2() },
            { 12, new AgroPonienteAdra() },
            { 13, new Fhalmeria_almeria()}
        };

        /// <summary>
        /// diccionario para saber la subastaid de  la pagina FHalmeria
        /// </summary>
        public static Dictionary<string, string> _dicNombresFHAlmeria = new Dictionary<string, string>()
            {
                { "AGROEJIDO", "https://www.agroprecios.com/es/precios-subasta/1-agroejido-el-ejido"},
                { "AGRO SAN ISIDRO", "https://www.agrosanisidro.com/"},
                { "AGROPONIENTE ADRA", "https://www.agroprecios.com/es/precios-subasta/9-agroponiente-adra"},
                { "COSTA DE ALMERIA", "https://www.agroprecios.com/es/precios-subasta/9-costa-almeria-roquetas"},
                { "AGROPONIENTE PONIENTE", "https://www.agroprecios.com/es/precios-subasta/7-agroponiente-la-redonda"},
                { "CEHORPA", "https://www.agroprecios.com/es/precios-subasta/5-costa-almeria-cehorpa"},
                { "CASI", "https://www.agroprecios.com/es/precios-subasta/2-casi"},
                { "LA UNION", "https://www.agroprecios.com/es/precios-subasta/8-union-la-redonda"},
                { "AGRUPAEJIDO", "https://www.agroprecios.com/es/precios-subasta/6-agrupaejido-la-redonda"},
                { "AGROPONIENTE EL GOLFO", "https://www.preciosdesubasta.com/pizarra/category/almeria/guardias-viejas-el-golfo-agroponiente/"},
                { "VEGACAÑADA", "https://www.agroprecios.com/es/precios-subasta/3-vegacanada"},
                { "AGRUPA2", "https://www.agroprecios.com/es/precios-subasta/8-agrupa2"},
                { "AGRUPA2 PAMPANICO", "https://hortoagrupa2.com/"},
            };

        //el search value tiene que ser el nombre que tiene la subasta en la base de datos
        public enum subastasENUM
        {
            [SearchValue("AgroEjido El Ejido")]
            agroejido_el_ejido,

            [SearchValue("Casi")]
            casi,

            [SearchValue("VegaCañada")]
            vegacanada,

            [SearchValue("AgroDolores Adra")]
            agrodolores_adra,

            [SearchValue("Costa Almeria Cehorpa")]
            costa_almeria_cehorpa,

            [SearchValue("AgrupaEjido La Redonda")]
            agrupaejido_la_redonda,

            [SearchValue("Agroponiente La Redonda")]
            agroponiente_la_redonda,

            [SearchValue("Union La Redonda")]
            union_la_redonda,

            [SearchValue("Costa Almeria Roquetas")]
            costa_almeria_roquetas,

            [SearchValue("Union 4 Vientos")]
            union_4_vientos,

            [SearchValue("Agrupa2")]
            agrupa2,

            [SearchValue("AgroPoniente Adra")]
            agroponiente_adra,

            [SearchValue("FhAlmeria Almeria")]
            fhalmeria_almeria
        }


        public static string GetNombreGeneroNormalizado(string nombre)
        {
            var dicGeneros = GetDicGeneros();

            if (dicGeneros.ContainsKey(nombre.ToUpper()))
                return dicGeneros[nombre.ToUpper().Trim()];


            return string.Empty;

        }

        /// <summary>
        /// este metodo se usa en la parte de extraccion de datos de fh almeria
        /// </summary>
        /// <param name="nombreSubasta"></param>
        /// <returns></returns>
        public static string NormalizacionNombreSubastaFHAlmeria(string nombreSubasta)
        {
            if (_dicNombresFHAlmeria.ContainsKey(nombreSubasta))
                return _dicNombresFHAlmeria[nombreSubasta];
            return string.Empty;
        }




        public static Dictionary<string, string> GetDicGeneros()
        {
            return new Dictionary<string, string>()
            {
               //ALCACHOFAS
                { "ALCACHOFA PEQUEÑA", "ALCACHOFA PEQUEÑA" },
                { "ALCACHOFA GORDA", "ALCACHOFA GORDA" },
                { "ALCACHOFA 1º", "ALCACHOFA" },
                { "ALC. HIBRIDA GORDA", "ALCACHOFA HIBRIDA GORDA" },
                { "ALC. HIBRIDA PEQUEÑA", "ALCACHOFA HIBRIDA PEQUEÑA" },
                { "ALCACHOFA HÍBRIDA PEQUEÑA", "ALCACHOFA HIBRIDA PEQUEÑA" },
                { "ALCACHOFA HÍBRIDA", "ALCACHOFA HIBRIDA PEQUEÑA" },
                { "ALC.B.G. GREEN QUEEN", "ALCACHOFA GREEN QUEEN" },
                { "ALCACHOFA GREEN QUEEN PEQUEÑA", "ALCACHOFA GREEN QUEEN" },
                //BROCOLI
                { "BRÓCOLI PELLAS", "BROCOLI PELLAS" },
                { "BRÓCOLI TALLOS", "BROCOLI TALLOS" },
                { "BROCULI", "BROCOLI" },
                { "BRÓCOLI", "BROCOLI" },
                { "BROCULI ECO", "BROCOLI ECO" },
                //BERENJENA
                { "BERENJENA LARGA", "BERENJENA LARGA" },
                { "BERENJENA", "BERENJENA LARGA" },
                { "BERENJENA BLANCA", "BERENJENA RAYADA" },
                { "BERENJENA RAYADA", "BERENJENA RAYADA" },
                //COLIFLOR
                { "COLIFLORES", "COLIFLOR" },
                { "COL", "COL" },
                { "COL RIZADA", "COL RIZADA" },
                //TIRABEQUES
                { "TIRABEQUES", "TIRABEQUES" },
                //CALABZA
                { "CALABAZA TOTANERA", "CALABAZA TOTANERA" },
                //PATATA
                { "PATATAS", "PATATA" },
                //HABAS
                { "HABAS VALENCIANAS", "HABAS VALENCIANAS" },
                { "HABAS", "HABAS" },
                //GUISANTES
                { "GUISANTES", "GUISANTES" },
                //JUDIAS
                { "JUDÍA EMERITE", "JUDIA EMERITE" },
                { "JUDIA EMERITE", "JUDIA EMERITE" },
                { "JUDÍA GARROFÓN", "JUDIA GARRAFON" },
                { "JUDÍA TABELLA", "JUDIA TABELLA" },
                { "JUDIA TABELLA", "JUDIA TABELLA" },
                { "JUDIAS", "JUDIA PERONA" },
                { "JUDÍAS", "JUDIA PERONA" },
                { "JUDÍA HELDA", "JUDIA PERONA HELDA" },
                { "JUDÍA GARRAFÓN", "JUDIA GARRAFON" },
                { "JUDIA GARRAFON", "JUDIA GARRAFON" },
                { "JUDIA HELDA", "JUDIA PERONA HELDA" },
                { "JUDIA PERONA", "JUDIA PERONA" },
                { "JUDÍA PERONA", "JUDIA PERONA" },
                { "JUDIAS ANCHAS", "JUDIA PERONA" },
                { "JUDÍA PERONA LARGA", "JUDIA PERONA" },
                { "JUDIA PERONA LARGA", "JUDIA PERONA" },
                { "JUDÍA RASTRA", "JUDIA RASTRA" },
                { "JUDÍA STRYKE", "JUDIA STRIKE" },
                { "JUDIA STRYKE", "JUDIA STRIKE" },
                { "JUDÍA STRIKE", "JUDIA STRIKE" },
                { "JUDÍA PERONA ROJA", "JUDIA PERONA ROJA" },
                { "JUDIA PERONA ROJA", "JUDIA PERONA ROJA" },
                { "JUDÍA PERONA SEMI", "JUDIA PERONA SEMI" },
                { "JUDIA PERONA SEMI", "JUDIA PERONA SEMI" },
                { "JUDIA RASTRA", "JUDIA RASTRA" },
                { "JUDIA STRIKE", "JUDIA STRIKE" },
                { "JUDÍA XERA", "JUDIA XERA" },
                { "JUDIA XERA", "JUDIA XERA" },
                { "JUDÍAS FINAS", "JUDIA FINA" },
                //SANDIAS
                { "SANDÍA NEGRA", "SANDIA NEGRA" },
                { "SANDIA NEGRA", "SANDIA NEGRA" },
                { "SANDIA BLANCA", "SANDIA BLANCA" },
                { "SANDÍA BLANCA", "SANDIA BLANCA" },
                //CALABACIN
                { "CALABACÍN BLANCO", "CALABACIN BLANCO" },
                { "CALABACIN BLANCO", "CALABACIN BLANCO" },
                { "CALABACÍN FINO", "CALABACIN FINO" },
                { "CALABACINES", "CALABACIN FINO" },
                { "CALABACÍN", "CALABACIN FINO" },
                { "CALABACIN", "CALABACIN FINO" },
                { "CALABACÍN GORDO", "CALABACIN GORDO" },
                { "CALABACIN GORDO", "CALABACIN GORDO" },
                //LIMON
                { "LIMÓN", "LIMON" },
                //MELON
                { "MELÓN AMARILLO", "MELON AMARILLO" },
                { "MELON AMARILLO", "MELON AMARILLO" },
                { "MELÓN CANTALOUP", "MELON CANTALOUP" },
                { "MELON CANTALOUP", "MELON CANTALOUP" },
                { "MELÓN CATEGORÍA", "MELON CATEGORIA" },
                { "MELON CATEGORIA", "MELON CATEGORIA" },
                { "MELÓN GALIA", "MELON GALIA" },
                { "MELON GALIA", "MELON GALIA" },
                { "MELÓN VERDE", "MELON VERDE" },
                //NISPERO
                 { "NÍSPERO", "NISPERO" },
                 //PEPINO ALMERIA
                { "PEPINO ALMERIA", "PEPINO ALMERIA" },
                { "PEPINO ALMERÍA", "PEPINO ALMERIA" },
                { "PEPINO BLANCO", "PEPINO BLANCO" },
                { "PEPINO MORITO", "PEPINO ESPAÑOL" },
                { "PEPINO ESPAÑOL", "PEPINO ESPAÑOL" },
                { "PEPINOS", "PEPINO ESPAÑOL" },
                { "PEPINO FRANCES", "PEPINO FRANCES" },
                { "PEPINO FRANCÉS", "PEPINO FRANCES" },
                //PIMIENTOS
                { "PIMIENTO AVENADO", "PIMIENTO AVENADO" },
                { "PIMIENTO CALIFORNIA AMARILLO", "PIMIENTO CALIFORNIA AMARILLO" },
                { "PIMIENTO CORTO AMARILLO", "PIMIENTO CALIFORNIA AMARILLO" },
                { "PTO. CORTO AMARILLO", "PIMIENTO CALIFORNIA AMARILLO" },
                { "PTOS AMARILLOS CALIF.1ª", "PIMIENTO CALIFORNIA AMARILLO" },
                { "PTO. CALIF. AMARILLO", "PIMIENTO CALIFORNIA AMARILLO" },
                { "PTO. CALI. AMARILLO ECO.", "PIMIENTO CALIFORNIA AMARILLO ECO" },
                { "PTO. CALIF. AMARILLO ECO", "PIMIENTO CALIFORNIA AMARILLO ECO" },
                { "PIMIENTO CALIFORNIA ROJO", "PIMIENTO CALIFORNIA ROJO" },
                { "PIMIENTO CORTO ROJO", "PIMIENTO CALIFORNIA ROJO" },
                { "PTO. CORTO ROJO", "PIMIENTO CALIFORNIA ROJO" },
                { "PTOS ROJOS CALIF 1ª", "PIMIENTO CALIFORNIA ROJO" },
                { "PTOS ROJOS CALIF 2ª", "PIMIENTO CALIFORNIA ROJO 2ª" },
                { "PTO.CALIF.ROJO", "PIMIENTO CALIFORNIA ROJO ECO" },
                { "PTO.CALIF. ROJO", "PIMIENTO CALIFORNIA ROJO" },
                { "PTOS ROJOS CALIF.1ª", "PIMIENTO CALIFORNIA ROJO" },
                { "PTOS ROJOS CALIF. ECO", "PIMIENTO CALIFORNIA ROJO ECO" },
                { "PTO.CALIF.ROJO ECO.", "PIMIENTO CALIFORNIA ROJO ECO" },
                { "PTOS ROJOS CALIF ECO", "PIMIENTO CALIFORNIA ROJO ECO" },
                { "PIMIENTO CALIFORNIA VERDE", "PIMIENTO CALIFORNIA VERDE" },
                { "PIMIENTO CORTO VERDE", "PIMIENTO CALIFORNIA VERDE" },
                { "PTO. CORTO VERDE", "PIMIENTO CALIFORNIA VERDE" },
                { "PTO. CALIF. VERDE", "PIMIENTO CALIFORNIA VERDE" },
                { "PTO. CALIF. VERDE ECO.", "PIMIENTO CALIFORNIA VERDE ECO" },
                { "PMIENTO CALIFORNIA VERDE", "PIMIENTO CALIFORNIA VERDE" },
                { "PTOS VERDES CALIF.1ª", "PIMIENTO CALIFORNIA VERDE" },
                { "PTOS VERDES CALIF.2ª", "PIMIENTO CALIFORNIA VERDE 2ª" },
                { "PIMIENTO CALIFORNIA VERDE ", "PIMIENTO CALIFORNIA VERDE" },
                { "PTO CALIF. NARANJA", "PIMIENTO CALIFORNIA NARANJA" },
                { "PIMIENTO ITALIANO ROJO", "PIMIENTO ITALIANO ROJO" },
                { "PIMIENTO ITALIANO VERDE", "PIMIENTO ITALIANO VERDE" },
                { "PTO. ITALIANO VERDE", "PIMIENTO ITALIANO VERDE" },
                { "PTO. ITALIANO", "PIMIENTO ITALIANO VERDE" },
                { "PIMIENTO LAMUYO  VERDE", "PIMIENTO LAMUYO VERDE" },
                { "PIMIENTO LAMUYO VERDE", "PIMIENTO LAMUYO VERDE" },
                { "PIMIENTO LARGO VERDE", "PIMIENTO LAMUYO VERDE" },
                { "PTO. LARGO VERDE", "PIMIENTO LAMUYO VERDE" },
                { "PTO. LAMUYO VERDE", "PIMIENTO LAMUYO VERDE" },
                { "PTOS VERDES 1ª", "PIMIENTO LAMUYO VERDE" },
                { "PTOS VERDES 2ª", "PIMIENTO LAMUYO VERDE 2ª" },
                { "PMIENTO LAMUYO VERDE 2ª", "PIMIENTO LAMUYO VERDE 2ª" },
                { "PIMIENTO LAMUYO AMARILLO", "PIMIENTO LAMUYO AMARILLO" },
                { "PTO. LAMUYO AMARILLO", "PIMIENTO LAMUYO AMARILLO" },
                { "PTO. LAMUYO ROJO", "PIMIENTO LAMUYO ROJO" },
                { "PIMIENTO LAMUYO ROJO", "PIMIENTO LAMUYO ROJO" },
                { "PIMIENTO LARGO ROJO", "PIMIENTO LAMUYO ROJO" },
                { "PTO. LARGO ROJO", "PIMIENTO LAMUYO ROJO" },
                { "PTOS ROJOS 1ª", "PIMIENTO LAMUYO ROJO" },
                { "PTOS ROJOS 2ª", "PIMIENTO LAMUYO ROJO 2ª" },
                { "PIMIENTO PADRON", "PIMIENTO PADRON" },
                { "PIMIENTO PADRÓN", "PIMIENTO PADRON" },
                { "PTO. PADRON", "PIMIENTO PADRON" },
                { "PTOS PADRON", "PIMIENTO PADRON" },
                { "PIMIENTO PALERMO", "PIMIENTO PALERMO" },
                { "PTO. PALERMO", "PIMIENTO PALERMO" },
                { "PIMIENTO PICANTE ROJO", "PIMIENTO PICANTE ROJO" },
                { "PIMIENTO PICANTE VERDE", "PIMIENTO PICANTE VERDE" },
                { "PTOS BOLA VERDE", "PIMIENTO BOLA VERDE" },
                //TOMATE SIN NORMALIZAR
                { "T. ASURCADO 1ª", "TOMATE ASURCADO" },
                { "TOMATE ASURCADOª", "TOMATE ASURCADO" },
                { "T. ASURCADO 2ª", "TOMATE ASURCADO 2ª" },
                { "T. DANIELA 1ª", "TOMATE DANIELA" },
                { "TOMATE ENSALADA", "TOMATE DANIELA" },
                { "TOMATE DANIELA", "TOMATE DANIELA" },
                { "TOMATE DANIELA VERDE", "TOMATE DANIELA VERDE" },
                { "T. DANIELA 2ª", "TOMATE DANIELA 2ª" },
                { "T. LISO 1ª", "TOMATE LISO" },
                { "T. LISO 2ª", "TOMATE LISO 2ª" },
                { "T. PERA 1ª", "TOMATE PERA" },
                { "TOMATE PERA", "TOMATE PERA" },
                { "T. PERA 2ª", "TOMATE PERA 2ª" },
                { "TOMATE RAF", "TOMATE RAF" },
                { "T. RAF 1ª", "TOMATE RAF" },
                { "T. RAF 2ª", "TOMATE RAF 2ª" },
                { "T. RAF 3ª", "TOMATE RAF 3ª" },
                { "TOMATE BEEF", "TOMATE BEEF" },
                { "TOMATE CHERRY", "TOMATE CHERRY" },
                { "TOMATE CHERRY PERA", "TOMATE CHERRY PERA" },
                { "TOMATE CHERRY RAMA", "TOMATE CHERRY RAMA" },
                { "TOMATE LISO", "TOMATE LISO" },
                { "TOMATE LISO 1ª", "TOMATE LISO" },
                { "TOMATE LISO 2ª", "TOMATE LISO 2ª" },
                { "TOMATE NEGRO", "TOMATE NEGRO" },
                { "TOMATE PINK", "TOMATE PINK" },
                { "TOMATE ROSA", "TOMATE PINK" },
                { "TOMATE PINTON", "TOMATE PINTON" },
                { "TOMATE PINTÓN", "TOMATE PINTON" },
                { "TOMATE RAMA", "TOMATE RAMA" },
                { "TOMATE RAMO", "TOMATE RAMA" },
                { "TOMATE RAMBO", "TOMATE RAMBO" },
                { "TOMATE RIZADO", "TOMATE RIZADO" },
                //TOMATES
                { "T. DANIELA G", "TOMATE DANIELA G" },
                { "TOMATE DANIELA G", "TOMATE DANIELA G" },
                { "T. DANIELA GG", "TOMATE DANIELA GG" },
                { "TOMATE DANIELA GG", "TOMATE DANIELA GG" },
                { "T. DANIELA GORDO", "TOMATE DANIELA CORDO" },
                { "TOMATE DANIELA GORDO", "TOMATE DANIELA CORDO" },
                { "T. DANIELA M", "TOMATE DANIELA M" },
                { "TOMATE DANIELA M", "TOMATE DANIELA M" },
                { "T. DANIELA MM", "TOMATE DANIELA MM" },
                { "TOMATE DANIELA MM", "TOMATE DANIELA MM" },
                { "TOMATE PERA M", "TOMATE PERA M" },
                { "T. PERA M", "TOMATE PERA M" },
                { "T. PERA MM", "TOMATE PERA MM" },
                { "TOMATE PERA MM", "TOMATE PERA MM" },
                { "T. RAF G", "TOMATE RAF G" },
                { "TOMATE RAF G", "TOMATE RAF G" },
                { "T. RAF GG", "TOMATE RAF GG" },
                { "TOMATE RAF GG", "TOMATE RAF GG" },
                { "T. RAF M", "TOMATE RAF M" },
                { "TOMATE RAF M", "TOMATE RAF M" },
                { "TOMATE RAF MADURO", "TOMATE RAF MADURO" },
                { "T. RAF MADURO", "TOMATE RAF MADURO" },
                { "T. RAF MM", "TOMATE RAF MM" },
                { "TOMATE RAF MM", "TOMATE RAF MM" },
                { "TOMATE RAF ROSCOS", "TOMATE RAF ROSCOS" },
                { "TOMATE RAMA C", "TOMATE RAMA C" },
                { "T. RAMA G", "TOMATE RAMA G" },
                { "TOMATE RAMA G", "TOMATE RAMA G" },
                { "T. RAMA M", "TOMATE RAMA M" },
                { "TOMATE RAMA M", "TOMATE RAMA M" },
                { "T. RAMA MM", "TOMATE RAMA MM" },
                { "TOMATE RAMA MM", "TOMATE RAMA MM" },
                { "LISO GG", "TOMATE LISO GG" },
                { "TOMATE ASUR. L. VIDA 7-M", "TOMATE ASURCADO M" },
                { "TOMATE L. VIDA 6-MM", "TOMATE DANIELA MM" },
                { "TOMATE LARGA VIDA MM", "TOMATE DANIELA MM" },
                { "TOMATE L. VIDA 7-M", "TOMATE DANIELA M" },
                { "TOMATE LARGA VIDA M", "TOMATE DANIELA M" },
                { "TOMATE L. VIDA 8-G", "TOMATE DANIELA G" },
                { "TOMATE LARGA VIDA G", "TOMATE DANIELA G" },
                { "TOMATE L. VIDA 9-GG", "TOMATE DANIELA GG" },
                { "TOMATE LARGA VIDA GG", "TOMATE DANIELA GG" },
                { "TOMATE LISO GG", "TOMATE LISO GG" },
                { "TOMATE LISO MADURO", "TOMATE LISO MADURO" },


            };
        }


    }
}
