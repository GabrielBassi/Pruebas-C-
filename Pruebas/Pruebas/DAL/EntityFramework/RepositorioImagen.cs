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

        //public Imagen ObtenerRutaImagen(string pRutaImagen)
        //{
        //    return iDbContext.Imagenes.Where(x => x.RutaImagen == pRutaImagen).FirstOrDefault();
        //}
    }

 }


    

