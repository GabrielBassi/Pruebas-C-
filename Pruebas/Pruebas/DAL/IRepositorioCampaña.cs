﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pruebas.Modelo;

namespace Pruebas.DAL
{
    interface IRepositorioCampaña : IRepositorioGeneral<Campaña>
    {
    Campaña ExistenciaCampaña(string pNombre);
        bool ExisteCampañaPorNombre(string pNombre);

    }

}
