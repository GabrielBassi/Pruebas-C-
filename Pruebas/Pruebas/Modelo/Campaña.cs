using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas.Modelo
{
    public class Campaña
    {
        public Campaña()
        {
            Estado = true;
        }
        //Definicion de propiedades de la clase campaña
        public int CampañaId { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFin { get; set; }
        public int DuracionImagen { get; set; }
        public bool Estado { get; set; }
        public virtual IList<Imagen> ListaImagenes { get; set; }
    }
}
