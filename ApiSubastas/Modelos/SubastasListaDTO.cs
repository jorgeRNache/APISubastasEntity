using ApiSubastasEntity.Modelos.Extras;

namespace ApiSubastasEntity.Modelos
{
    public class SubastasListaDTO
    {
        public string? nombre_subasta;
        private DateTime fechaSubasta;

        public string fecha_subasta
        {
            get { return fechaSubasta.ToString("yyyy-MM-dd"); }
            set 
            { 
                DateTime dateTime = DateTime.Now;
                DateTime.TryParse(value, out dateTime);
                this.fechaSubasta = dateTime;
            }
        }

        public List<SubastaDetalleRawDTO>? listCortes;

        

    }
}
