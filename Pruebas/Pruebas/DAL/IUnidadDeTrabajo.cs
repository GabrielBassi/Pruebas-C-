﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Pruebas.DAL
{
    interface IUnidadDeTrabajo : IDisposable
    {
        IRepositorioCampaña RepositorioCampaña { get; }
        IRepositorioImagen RepositorioImagen { get; }
        IRepositorioBanner RepositorioBanner { get; }
        IRepositorioRssUrl RepositorioRssUrl { get; }
        IRepositorioTextoFijo RepositorioTextoFijo { get; }
        IRepositorioFuenteRssUrl RepositorioFuenteRssUrl { get; }

        /// <summary>
        /// Guardar en memoria (savechanges)
        /// </summary>
        void Guardar();
    }
}
