﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pruebas.Modelo;

namespace Pruebas.DAL
{
    interface IRepositorioImagen : IRepositorioGeneral<Imagen>
    {
        IList<Imagen> ObtenerTodasLasImagensDeLaCampaña(int pidCampaña);
    }

}
