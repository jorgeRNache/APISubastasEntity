using ApiSubastasEntity.Modelos.Error;

namespace ApiSubastasEntity.Modelos.Atributos
{
    [AttributeUsage(AttributeTargets.Field)]
    public class ErrorType : Attribute
    {
        public Type value;
        public ErrorType(Type value)
        {
            this.value = value;
        }

    }
}
