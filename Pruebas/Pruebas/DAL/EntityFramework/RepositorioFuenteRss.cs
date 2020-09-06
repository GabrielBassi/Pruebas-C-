using Pruebas.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas.DAL.EntityFramework
{
    class RepositorioFuenteRss : RepositorioGeneral <FuenteRss, PruebaContext>, IRepositorioFuenteRssUrl
    {
        public RepositorioFuenteRss (PruebaContext pContext) : base(pContext)
        {

        }
    }
}
