namespace ApiSubastasEntity.Modelos.Atributos
{
    public class SearchValue : Attribute
    {
        private string value;
        public SearchValue(string value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return value;
        }
        
    }
}
