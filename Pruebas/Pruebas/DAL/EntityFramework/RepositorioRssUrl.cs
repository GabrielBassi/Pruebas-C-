using Pruebas.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas.DAL.EntityFramework
{
    class RepositorioRssUrl:RepositorioGeneral<RssUrl, PruebaContext>, IRepositorioRssUrl
    {
        public RepositorioRssUrl(PruebaContext pContext) : base (pContext)
        {

        }
    }
}
