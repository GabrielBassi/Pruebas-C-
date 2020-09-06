using Pruebas.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas.DAL.EntityFramework
{
    class RepositorioTextoFijo:RepositorioGeneral<TextoFijo, PruebaContext>,IRepositorioTextoFijo 
    {
         public RepositorioTextoFijo(PruebaContext pContext) : base(pContext)
         {
         }
    }
}
