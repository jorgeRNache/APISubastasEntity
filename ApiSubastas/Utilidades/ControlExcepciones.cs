namespace ApiSubastasEntity.Utilidades
{
    public class ControlExcepciones
    {
        private static readonly Lazy<ControlExcepciones> instancia =
        new Lazy<ControlExcepciones>(() => new ControlExcepciones());

        public static ControlExcepciones Instancia => instancia.Value;

        public ControlExcepciones()
        {

        }

        public void ResolveException()
        {

        }
    }
}
