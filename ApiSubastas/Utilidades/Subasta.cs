namespace ApiSubastasEntity.Utilidades
{
    public static class Subasta
    {

        private static void AddToDictionary(Dictionary<string, List<string>> dictionary, string key, string value)
        {
            if (dictionary.ContainsKey(key))
            {
                dictionary[key].Add(value);
            }
            else
            {
                dictionary.Add(key, new List<string> { value });
            }
        }


        public static string CompletaFamilia(string NombreGenero)
        {
            string nombreFamilia = "";

            Dictionary<string, List<string>> generosFamilias = new Dictionary<string, List<string>>();


            AddToDictionary(generosFamilias, "ACELGAS", "ACELGAS");

            AddToDictionary(generosFamilias, "ALCACHOFA", "ALCACHOFA");
            AddToDictionary(generosFamilias, "ALCACHOFA", "ALCACHOFA BLANCA PEQUEÑA");
            AddToDictionary(generosFamilias, "ALCACHOFA", "ALCACHOFA BLANCA");
            AddToDictionary(generosFamilias, "ALCACHOFA", "ALCACHOFA GORDA (INDUSTRIA)");
            AddToDictionary(generosFamilias, "ALCACHOFA", "ALCACHOFA HIBRIDA GORDA");
            AddToDictionary(generosFamilias, "ALCACHOFA", "ALCACHOFA HIBRIDA PEQUEÑA");
            AddToDictionary(generosFamilias, "ALCACHOFA", "ALCACHOFA HIBRIDA");
            AddToDictionary(generosFamilias, "ALCACHOFA", "ALCACHOFA PEQUEÑA (INDUSTRIA)");
            AddToDictionary(generosFamilias, "ALCACHOFA", "ALCACHOFA PEQUEÑA (PLAZA)");
            AddToDictionary(generosFamilias, "ALCACHOFA", "ALCACHOFA PEQUEÑA");
            AddToDictionary(generosFamilias, "ALCACHOFA", "ALCACHOFA RECIA");
            AddToDictionary(generosFamilias, "ALCACHOFA", "ALCACHOFA GREEN QUEEN");



            AddToDictionary(generosFamilias, "APIO", "APIO");

            AddToDictionary(generosFamilias, "BERENJENA", "BERENJENA BLANCA");
            AddToDictionary(generosFamilias, "BERENJENA", "BERENJENA LARGA");
            AddToDictionary(generosFamilias, "BERENJENA", "BERENJENA RAYADA");


            AddToDictionary(generosFamilias, "BONIATO", "BONIATO ROJO");

            AddToDictionary(generosFamilias, "BROCOLI", "BROCOLI TALLOS");
            AddToDictionary(generosFamilias, "BROCOLI", "BROCOLI PELLAS");
            AddToDictionary(generosFamilias, "BROCOLI", "BROCOLI");
            AddToDictionary(generosFamilias, "BROCOLI", "BROCOLI ECO");

            AddToDictionary(generosFamilias, "CALABACIN", "CALABACIN BLANCO");
            AddToDictionary(generosFamilias, "CALABACIN", "CALABACIN FINO");
            AddToDictionary(generosFamilias, "CALABACIN", "CALABACIN GORDO");

            AddToDictionary(generosFamilias, "CALABAZA", "CALABAZA CACAHUETE");
            AddToDictionary(generosFamilias, "CALABAZA", "CALABAZA");
            AddToDictionary(generosFamilias, "CALABAZA", "CALABAZA TOTANERA");

            AddToDictionary(generosFamilias, "CHIRIMOYA", "CHIRIMOYAS");

            AddToDictionary(generosFamilias, "COL", "COL RIZADA");
            AddToDictionary(generosFamilias, "COL", "COL LISA");
            AddToDictionary(generosFamilias, "COL", "COL");

            AddToDictionary(generosFamilias, "COLIFLOR", "COLIFLOR");

            AddToDictionary(generosFamilias, "ESPARRAGOS", "ESPARRAGOS");

            AddToDictionary(generosFamilias, "GUISANTE", "GUISANTES");

            AddToDictionary(generosFamilias, "GUISANTE", "TIRABEQUES")
                ;
            AddToDictionary(generosFamilias, "HABAS", "HABAS");
            AddToDictionary(generosFamilias, "HABAS", "HABAS VALENCIANAS");


            AddToDictionary(generosFamilias, "HINOJO", "HINOJO");

            AddToDictionary(generosFamilias, "JUDIAS", "JUDIA EMERITE");
            AddToDictionary(generosFamilias, "JUDIAS", "JUDIA GARRAFON");
            AddToDictionary(generosFamilias, "JUDIAS", "JUDIA PERONA SEMI");
            AddToDictionary(generosFamilias, "JUDIAS", "JUDIA PERONA ROJA");
            AddToDictionary(generosFamilias, "JUDIAS", "JUDIA PERONA");
            AddToDictionary(generosFamilias, "JUDIAS", "JUDIA RASTRA");
            AddToDictionary(generosFamilias, "JUDIAS", "JUDIA STRIKE");
            AddToDictionary(generosFamilias, "JUDIAS", "JUDIA TABELLA");
            AddToDictionary(generosFamilias, "JUDIAS", "JUDIA XERA");
            AddToDictionary(generosFamilias, "JUDIAS", "JUDIA FINA");

            AddToDictionary(generosFamilias, "LIMON", "LIMON");

            AddToDictionary(generosFamilias, "MELON", "MELON CATEGORIA");
            AddToDictionary(generosFamilias, "MELON", "MELON GALIA");
            AddToDictionary(generosFamilias, "MELON", "MELON CANTALOUP");
            AddToDictionary(generosFamilias, "MELON", "MELON AMARILLO");
            AddToDictionary(generosFamilias, "MELON", "MELON VERDE");

            AddToDictionary(generosFamilias, "NARANJA", "NARANJA");

            AddToDictionary(generosFamilias, "NISPERO", "NISPERO");

            AddToDictionary(generosFamilias, "PATATA", "PATATA SPUNTA");
            AddToDictionary(generosFamilias, "PATATA", "PATATA");

            AddToDictionary(generosFamilias, "PEPINO", "PEPINO ALMERIA");
            AddToDictionary(generosFamilias, "PEPINO", "PEPINO BLANCO");
            AddToDictionary(generosFamilias, "PEPINO", "PEPINO ESPAÑOL");
            AddToDictionary(generosFamilias, "PEPINO", "PEPINO FRANCES");

            AddToDictionary(generosFamilias, "PIMIENTO", "PIMIENTO AVENADO");
            AddToDictionary(generosFamilias, "PIMIENTO", "PIMIENTO CALIFORNIA AMARILLO");
            AddToDictionary(generosFamilias, "PIMIENTO", "PIMIENTO CALIFORNIA AMARILLO ECO");
            AddToDictionary(generosFamilias, "PIMIENTO", "PIMIENTO CALIFORNIA ROJO");
            AddToDictionary(generosFamilias, "PIMIENTO", "PIMIENTO CALIFORNIA VERDE");
            AddToDictionary(generosFamilias, "PIMIENTO", "PIMIENTO CALIFORNIA VERDE ECO");
            AddToDictionary(generosFamilias, "PIMIENTO", "PIMIENTO CALIFORNIA AMARILLO 2ª");
            AddToDictionary(generosFamilias, "PIMIENTO", "PIMIENTO CALIFORNIA ROJO 2ª");
            AddToDictionary(generosFamilias, "PIMIENTO", "PIMIENTO CALIFORNIA ROJO ECO");
            AddToDictionary(generosFamilias, "PIMIENTO", "PIMIENTO CALIFORNIA VERDE 2ª");
            AddToDictionary(generosFamilias, "PIMIENTO", "PIMIENTO ITALIANO ROJO");
            AddToDictionary(generosFamilias, "PIMIENTO", "PIMIENTO ITALIANO VERDE");
            AddToDictionary(generosFamilias, "PIMIENTO", "PIMIENTO LAMUYO AMARILLO");
            AddToDictionary(generosFamilias, "PIMIENTO", "PIMIENTO LAMUYO ROJO");
            AddToDictionary(generosFamilias, "PIMIENTO", "PIMIENTO LAMUYO VERDE");
            AddToDictionary(generosFamilias, "PIMIENTO", "PIMIENTO LAMUYO AMARILLO 2ª");
            AddToDictionary(generosFamilias, "PIMIENTO", "PIMIENTO LAMUYO ROJO 2ª");
            AddToDictionary(generosFamilias, "PIMIENTO", "PIMIENTO LAMUYO VERDE 2ª");
            AddToDictionary(generosFamilias, "PIMIENTO", "PIMIENTO PADRON");
            AddToDictionary(generosFamilias, "PIMIENTO", "PIMIENTO PALERMO");
            AddToDictionary(generosFamilias, "PIMIENTO", "PIMIENTO PICANTE ROJO");
            AddToDictionary(generosFamilias, "PIMIENTO", "PIMIENTO PICANTE VERDE");
            AddToDictionary(generosFamilias, "PIMIENTO", "PIMIENTO BOLA VERDE");
            AddToDictionary(generosFamilias, "PIMIENTO", "PIMIENTO CALIFORNIA NARANJA");


            AddToDictionary(generosFamilias, "PUERRO", "PUERRO");

            AddToDictionary(generosFamilias, "SANDIA", "SANDIA BLANCA");
            AddToDictionary(generosFamilias, "SANDIA", "SANDIA NEGRA");


            //TOMATE SIN NORMALIZAR
            AddToDictionary(generosFamilias, "TOMATE SIN NORMALIZAR", "TOMATE ASURCADO");
            AddToDictionary(generosFamilias, "TOMATE SIN NORMALIZAR", "TOMATE ASURCADO 2ª");
            AddToDictionary(generosFamilias, "TOMATE SIN NORMALIZAR", "TOMATE DANIELA");
            AddToDictionary(generosFamilias, "TOMATE SIN NORMALIZAR", "TOMATE DANIELA VERDE");
            AddToDictionary(generosFamilias, "TOMATE SIN NORMALIZAR", "TOMATE DANIELA 2ª");
            AddToDictionary(generosFamilias, "TOMATE SIN NORMALIZAR", "TOMATE LISO");
            AddToDictionary(generosFamilias, "TOMATE SIN NORMALIZAR", "TOMATE LISO 2ª");
            AddToDictionary(generosFamilias, "TOMATE SIN NORMALIZAR", "TOMATE PERA");
            AddToDictionary(generosFamilias, "TOMATE SIN NORMALIZAR", "TOMATE PERA 2ª");
            AddToDictionary(generosFamilias, "TOMATE SIN NORMALIZAR", "TOMATE RAF");
            AddToDictionary(generosFamilias, "TOMATE SIN NORMALIZAR", "TOMATE RAF 2ª");
            AddToDictionary(generosFamilias, "TOMATE SIN NORMALIZAR", "TOMATE RAF 3ª");
            AddToDictionary(generosFamilias, "TOMATE SIN NORMALIZAR", "TOMATE BEEF");
            AddToDictionary(generosFamilias, "TOMATE SIN NORMALIZAR", "TOMATE CHERRY");
            AddToDictionary(generosFamilias, "TOMATE SIN NORMALIZAR", "TOMATE CHERRY PERA");
            AddToDictionary(generosFamilias, "TOMATE SIN NORMALIZAR", "TOMATE CHERRY RAMA");
            AddToDictionary(generosFamilias, "TOMATE SIN NORMALIZAR", "TOMATE LISO");
            AddToDictionary(generosFamilias, "TOMATE SIN NORMALIZAR", "TOMATE LISO 2ª");
            AddToDictionary(generosFamilias, "TOMATE SIN NORMALIZAR", "TOMATE NEGRO");
            AddToDictionary(generosFamilias, "TOMATE SIN NORMALIZAR", "TOMATE PINK");
            AddToDictionary(generosFamilias, "TOMATE SIN NORMALIZAR", "TOMATE PINTON");
            AddToDictionary(generosFamilias, "TOMATE SIN NORMALIZAR", "TOMATE RAMA");
            AddToDictionary(generosFamilias, "TOMATE SIN NORMALIZAR", "TOMATE RAMA");
            AddToDictionary(generosFamilias, "TOMATE SIN NORMALIZAR", "TOMATE RIZADO");
            

            //TOMATE NORMALIZADO
            AddToDictionary(generosFamilias, "TOMATE NORMALIZADO", "TOMATE DANIELA G");
            AddToDictionary(generosFamilias, "TOMATE NORMALIZADO", "TOMATE DANIELA GG");
            AddToDictionary(generosFamilias, "TOMATE NORMALIZADO", "TOMATE DANIELA CORDO");
            AddToDictionary(generosFamilias, "TOMATE NORMALIZADO", "TOMATE DANIELA M");
            AddToDictionary(generosFamilias, "TOMATE NORMALIZADO", "TOMATE DANIELA MM");
            AddToDictionary(generosFamilias, "TOMATE NORMALIZADO", "TOMATE PERA M");
            AddToDictionary(generosFamilias, "TOMATE NORMALIZADO", "TOMATE PERA MM");
            AddToDictionary(generosFamilias, "TOMATE NORMALIZADO", "TOMATE RAF G");
            AddToDictionary(generosFamilias, "TOMATE NORMALIZADO", "TOMATE RAF GG");
            AddToDictionary(generosFamilias, "TOMATE NORMALIZADO", "TOMATE RAF M");
            AddToDictionary(generosFamilias, "TOMATE NORMALIZADO", "TOMATE RAF MADURO");
            AddToDictionary(generosFamilias, "TOMATE NORMALIZADO", "TOMATE RAF MM");
            AddToDictionary(generosFamilias, "TOMATE NORMALIZADO", "TOMATE RAF ROSCOS");
            AddToDictionary(generosFamilias, "TOMATE NORMALIZADO", "TOMATE RAMA C");
            AddToDictionary(generosFamilias, "TOMATE NORMALIZADO", "TOMATE RAMA G");
            AddToDictionary(generosFamilias, "TOMATE NORMALIZADO", "TOMATE RAMA M");
            AddToDictionary(generosFamilias, "TOMATE NORMALIZADO", "TOMATE RAMA MM");
            AddToDictionary(generosFamilias, "TOMATE NORMALIZADO", "TOMATE LISO GG");
            AddToDictionary(generosFamilias, "TOMATE NORMALIZADO", "TOMATE ASURCADO M");
            AddToDictionary(generosFamilias, "TOMATE NORMALIZADO", "TOMATE LARGA VIDA MM");
            AddToDictionary(generosFamilias, "TOMATE NORMALIZADO", "TOMATE LARGA VIDA M");
            AddToDictionary(generosFamilias, "TOMATE NORMALIZADO", "TOMATE LARGA VIDA G");
            AddToDictionary(generosFamilias, "TOMATE NORMALIZADO", "TOMATE LARGA VIDA GG");
            AddToDictionary(generosFamilias, "TOMATE NORMALIZADO", "TOMATE LISO MADURO");


            foreach (var kvp in generosFamilias)
            {

                if (kvp.Value.Contains(NombreGenero.ToUpper()))
                {
                    nombreFamilia = kvp.Key.ToUpper();
                }


            }

            return nombreFamilia;

        }


        public static string AjustaNombreCorrecto(string NombreGenero)
        {
            Dictionary<string, string> diccionario = new Dictionary<string, string>()
            {

                { "ALCACHOFA PEQUEÑA", "ALCACHOFA PEQUEÑA" },
                { "ALCACHOFA GORDA", "ALCACHOFA GORDA" },
                { "ALCACHOFA 1º", "ALCACHOFA" },
                { "ALC.B.G. GREEN QUEEN", "ALCACHOFA GREEN QUEEN" },
                { "ALCACHOFA GREEN QUEEN PEQUEÑA", "ALCACHOFA GREEN QUEEN" },
                { "ALC. HIBRIDA GORDA", "ALCACHOFA HIBRIDA GORDA" },
                { "ALC. HIBRIDA PEQUEÑA", "ALCACHOFA HIBRIDA PEQUEÑA" },
                { "ALCACHOFA HÍBRIDA PEQUEÑA", "ALCACHOFA HIBRIDA PEQUEÑA" },
                { "ALCACHOFA HÍBRIDA", "ALCACHOFA HIBRIDA PEQUEÑA" },

                { "BRÓCOLI PELLAS", "BROCOLI PELLAS" },
                { "BRÓCOLI TALLOS", "BROCOLI TALLOS" },
                { "BROCULI", "BROCOLI" },
                { "BRÓCOLI", "BROCOLI" },
                { "BROCULI ECO", "BROCOLI ECO" },

                { "BERENJENA LARGA", "BERENJENA LARGA" },
                { "BERENJENA", "BERENJENA LARGA" },
                { "BERENJENA BLANCA", "BERENJENA BLANCA" },
                { "BERENJENA RAYADA", "BERENJENA RAYADA" },

                { "CALABACÍN BLANCO", "CALABACIN BLANCO" },
                { "CALABACIN BLANCO", "CALABACIN BLANCO" },
                { "CALABACÍN FINO", "CALABACIN FINO" },
                { "CALABACINES", "CALABACIN FINO" },
                { "CALABACÍN", "CALABACIN FINO" },
                { "CALABACIN", "CALABACIN FINO" },
                { "CALABACÍN GORDO", "CALABACIN GORDO" },
                { "CALABACIN GORDO", "CALABACIN GORDO" },

                { "COLIFLORES", "COLIFLOR" },
                { "COL", "COL" },
                { "COL RIZADA", "COL RIZADA" },
                

                { "CALABAZA TOTANERA", "CALABAZA TOTANERA" },
                { "PATATAS", "PATATA" },

                { "GUISANTES", "GUISANTES" },
                { "TIRABEQUES", "TIRABEQUES" },

                { "HABAS", "HABAS" },
                { "HABAS VALENCIANAS", "HABAS VALENCIANAS" },

                { "JUDÍA EMERITE", "JUDIA EMERITE" },
                { "JUDIA EMERITE", "JUDIA EMERITE" },
                { "JUDÍA GARROFÓN", "JUDIA GARRAFON" },
                { "JUDÍA GARRAFÓN", "JUDIA GARRAFON" },
                { "JUDIA GARRAFON", "JUDIA GARRAFON" },
                { "JUDIAS", "JUDIA PERONA" },
                { "JUDÍAS", "JUDIA PERONA" },
                { "JUDÍA HELDA", "JUDIA PERONA HELDA" },
                { "JUDIA HELDA", "JUDIA PERONA HELDA" },
                { "JUDIA PERONA", "JUDIA PERONA" },
                { "JUDÍA PERONA", "JUDIA PERONA" },
                { "JUDIAS ANCHAS", "JUDIA PERONA" },
                { "JUDÍA PERONA LARGA", "JUDIA PERONA" },
                { "JUDIA PERONA LARGA", "JUDIA PERONA" },
                { "JUDÍA PERONA ROJA", "JUDIA PERONA ROJA" },
                { "JUDIA PERONA ROJA", "JUDIA PERONA ROJA" },
                { "JUDÍA PERONA SEMI", "JUDIA PERONA SEMI" },
                { "JUDIA PERONA SEMI", "JUDIA PERONA SEMI" },
                { "JUDIA RASTRA", "JUDIA RASTRA" },
                { "JUDÍA RASTRA", "JUDIA RASTRA" },
                { "JUDÍA STRYKE", "JUDIA STRIKE" },
                { "JUDIA STRYKE", "JUDIA STRIKE" },
                { "JUDÍA STRIKE", "JUDIA STRIKE" },
                { "JUDIA STRIKE", "JUDIA STRIKE" },
                { "JUDÍA TABELLA", "JUDIA TABELLA" },
                { "JUDIA TABELLA", "JUDIA TABELLA" },
                { "JUDÍA XERA", "JUDIA XERA" },
                { "JUDIA XERA", "JUDIA XERA" },
                { "JUDÍAS FINAS", "JUDIA FINA" },

                { "SANDÍA NEGRA", "SANDIA NEGRA" },
                { "SANDIA NEGRA", "SANDIA NEGRA" },
                { "SANDIA BLANCA", "SANDIA BLANCA" },
                { "SANDÍA BLANCA", "SANDIA BLANCA" },

                { "LIMÓN", "LIMON" },

                { "MELÓN AMARILLO", "MELON AMARILLO" },
                { "MELON AMARILLO", "MELON AMARILLO" },
                { "MELÓN CANTALOUP", "MELON CANTALOUP" },
                { "MELON CANTALOUP", "MELON CANTALOUP" },
                { "MELÓN CATEGORÍA", "MELON CATEGORIA" },
                { "MELON CATEGORIA", "MELON CATEGORIA" },
                { "MELÓN GALIA", "MELON GALIA" },
                { "MELON GALIA", "MELON GALIA" },
                { "MELÓN VERDE", "MELON VERDE" },

                 { "NÍSPERO", "NISPERO" },

                { "PEPINO ALMERIA", "PEPINO ALMERIA" },
                { "PEPINO ALMERÍA", "PEPINO ALMERIA" },
                { "PEPINO BLANCO", "PEPINO BLANCO" },
                { "PEPINO MORITO", "PEPINO ESPAÑOL" },
                { "PEPINO ESPAÑOL", "PEPINO ESPAÑOL" },
                { "PEPINOS", "PEPINO ESPAÑOL" },
                { "PEPINO FRANCES", "PEPINO FRANCES" },
                { "PEPINO FRANCÉS", "PEPINO FRANCES" },


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
                

                //TOMATE NORMALIZADO
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

            if (diccionario.ContainsKey(NombreGenero.ToUpper()))
            {
                return diccionario[NombreGenero.ToUpper().Trim()];
            }
            else
            {
                return NombreGenero;
            }

        }



        public static int DameIdSubasta(string Nombre)
        {

            Dictionary<int, string> empresas = new Dictionary<int, string>()
            {
                { 1, "CASI" },
                { 2, "VEGACAÑADA" },
                { 3, "AGRODOLORES ADRA" },
                { 4, "AGROEJIDO" },
                { 5, "AGRUPAEJIDO" },
                { 6, "AGROPONIENTE PONIENTE" },
                { 7, "LA UNION" },
                { 8, "COSTA DE ALMERIA" },
                { 9, "CEHORPA" },
                { 10, "AGRO SAN ISIDRO" },
                { 11, "LA UNION ADRA" },
                { 12, "AGROPONIENTE EL GOLFO" },
                { 13, "HORTOFRUTICOLA TRES PUENTES" },
                { 14, "AGRO-VERDURAS 2000, S.L." },
                { 15, "LA REDONDA DE LOS HUERTOS" },
                { 16, "FRUTAS EL PORTON (GRANADA)" },
                { 17, "EL POZUELO, AGRUPACION DE LABRADORES" },
                { 18, "MIGUEL GARCIA PUNTALON" },
                { 19, "AGRODEIRE" },
                { 20, "FRUTAS DE CARA MOTRIL" },
                { 21, "AGROCASTELL" },
                { 22, "SOLTIR" },
                { 23, "MERCAGRISA" },
                { 24, "CENTRAMIRSA SAN JAVIER" },
                { 25, "AGRIMESA SAN JAVIER" },
                { 26, "AGROMERCA CIUDAD DEL SOL" },
                { 27, "SUBASUR (TORRE PACHECO)" },
                { 28, "AGRODOLORES DOLORES" },
                { 29, "AGRODOLORES EL MIRADOR" },
                { 30, "ALMERCA" },
                { 31, "AGRIMESA EL MIRADOR" }
            };

            foreach (var empresa in empresas)
            {
                if (empresa.Value.Equals(Nombre.ToUpper()))
                {
                    return empresa.Key;
                }
            }

            return -1;
        }

 

    }
}
