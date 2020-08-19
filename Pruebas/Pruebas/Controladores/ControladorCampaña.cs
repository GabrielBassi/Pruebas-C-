using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pruebas.DAL.EntityFramework;
using Pruebas.Modelo;
using System.Windows.Forms;

namespace Pruebas.Controladores
{
    class ControladorCampaña
    {
        private readonly UnidadDeTrabajo iUdT;
        public ControladorCampaña(UnidadDeTrabajo pUnidadDeTrabajo)
        {
            this.iUdT = pUnidadDeTrabajo;

        }
        /// <summary>
        /// Se agrega una nueva campaña al repositorio
        /// </summary>
        /// <param name="pFechaFin"></param>
        /// <param name="pFechaInicio"></param>
        /// <param name="pHoraFin"></param>
        /// <param name="pHoraInicio"></param>
        /// <param name="pDuracion"></param>
        /// <param name="pNombre"></param>
        public void AgregarCampaña(string pNombre, DateTime pFechaInicio, DateTime pFechaFin, DateTime pHoraInicio, DateTime pHoraFin, int pDuracion, IList<Imagen> pListaImagen)
        {
            Campaña iCampaña = new Campaña()
            {
                Nombre = pNombre,
                FechaInicio = pFechaInicio,
                FechaFin = pFechaFin,
                HoraInicio = pHoraInicio,
                HoraFin = pHoraFin,
                DuracionImagen = pDuracion,
                ListaImagenes = pListaImagen,
            };

            iUdT.RepositorioCampaña.Agregar(iCampaña);
            iUdT.Guardar();
        }

        /// <summary>
        /// Método para validar la fecha de inicio y fin de una campaña
        /// </summary>
        /// <param name="pFechaInicio"></param>
        /// <param name="pFechaFin"></param>
        public void ValidarFecha(DateTime pFechaInicio, DateTime pFechaFin)
        {
            if (pFechaInicio >= pFechaFin)
            {
                System.Windows.Forms.MessageBox.Show("la fecha de inicio debe ser menor o igual a la fecha de fin", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
