using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pruebas.Modelo;

namespace Pruebas.DAL.EntityFramework
{
    class RepositorioImagen : RepositorioGeneral<Imagen, PruebaContext>, IRepositorioImagen
    {
        public RepositorioImagen(PruebaContext pContext) : base(pContext)
        {
        }
    }
}
