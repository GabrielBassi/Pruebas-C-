﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pruebas.Modelo;

namespace Pruebas.DAL.EntityFramework
{
    class RepositorioBanner : RepositorioGeneral<Banner, PruebaContext>, IRepositorioBanner
    {
        public RepositorioBanner(PruebaContext pContext) : base(pContext)
        {

        }
    }
}
