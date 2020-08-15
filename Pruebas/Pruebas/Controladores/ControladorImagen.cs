using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pruebas.DAL;

namespace Pruebas.Controladores
{
    class ControladorImagen
    {
        private readonly IUnidadDeTrabajo iUdT;
        public ControladorImagen(IUnidadDeTrabajo pUdT)
        {
            this.iUdT = pUdT;
        }
    }
}
