using System;
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

        /// <summary>
        /// Guardar en memoria (savechanges)
        /// </summary>
        void Guardar();
    }
}
