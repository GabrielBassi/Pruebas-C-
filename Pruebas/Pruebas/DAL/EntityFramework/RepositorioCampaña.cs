using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pruebas.Modelo;
using Pruebas.Excepciones;

namespace Pruebas.DAL.EntityFramework
{
    class RepositorioCampaña : RepositorioGeneral<Campaña, PruebaContext>, IRepositorioCampaña
    {
        public RepositorioCampaña(PruebaContext pContext) : base(pContext)
        {

        }  
        public Campaña ExistenciaCampaña(string pNombre)
        {
            return iDbContext.Campañas.Where(x => x.Nombre == pNombre).FirstOrDefault();
        }
        public bool ExisteCampañaPorNombre(string pNombre)
        {
            bool valor = false;
            valor = iDbContext.Campañas.Any(x=>x.Nombre==pNombre);
            return valor;
        }
    }
}


