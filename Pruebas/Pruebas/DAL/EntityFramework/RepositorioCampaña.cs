using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pruebas.Modelo;

namespace Pruebas.DAL.EntityFramework
{
    class RepositorioCampaña : RepositorioGeneral<Campaña, PruebaContext>, IRepositorioCampaña
    {
        public RepositorioCampaña(PruebaContext pContext) : base(pContext)
        {

        }
        public Campaña BuscarCampañaPorNombre(string pNombre)
        {
            return iDbContext.Campañas.Where(x => x.Nombre == pNombre).FirstOrDefault();
        }


    }

}


