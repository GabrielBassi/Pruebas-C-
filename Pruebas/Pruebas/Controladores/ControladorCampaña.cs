﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pruebas.DAL.EntityFramework;
using Pruebas.Modelo;
using System.Windows.Forms;
using Pruebas.Excepciones;

namespace Pruebas.Controladores
{
    class ControladorCampaña
    {
        private readonly UnidadDeTrabajo iUdT;
        private ControladorImagen iControladorImagen;
        int aamod = 20;
        int jjmod = 35;
        int aa = 20;
        int jj = 35;

        public ControladorCampaña(UnidadDeTrabajo pUnidadDeTrabajo)
        {
            this.iUdT = pUnidadDeTrabajo;
            iControladorImagen = new ControladorImagen(iUdT,aa,jj);

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
        public void AgregarCampaña(string pNombre, DateTime pFechaInicio, DateTime pFechaFin, TimeSpan pHoraInicio, TimeSpan pHoraFin, int pDuracion, IList<Imagen> pListaImagen)
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
               throw new ExcepcionControlFechas("La fecha de fin debe ser mayor o igual a la fecha de inicio");
            }
        }

        /// <summary>
        /// M[etodo para validar hira de inicio y fin de una campaña
        /// </summary>
        /// <param name="pHoraInicio"></param>
        /// <param name="pHoraFin"></param>
        public void ValidarHora(int pHoraInicio, int pHoraFin)
        {         
            if (pHoraInicio < pHoraFin)
            {
               throw new ExcepcionControlFechas("La hora de fin debe ser mayor la hora de inicio");
            }
        }

        /// <summary>
        /// Modifica una campaña en el repositorio
        /// </summary>
        /// <param name="pCampaña">Campaña a modificar</param>
        /// 
        public void ModificarCampaña(Campaña pCampaña, string pNombre, DateTime pFechaInicio, DateTime pFechaFin, TimeSpan pHoraInicio, TimeSpan pHoraFin, int pDuracionImagen, IList<Imagen> pListaImagen)
        {
            pCampaña.Nombre = pNombre;
            pCampaña.FechaInicio = pFechaInicio;
            pCampaña.FechaFin = pFechaFin;
            pCampaña.HoraInicio = pHoraInicio;
            pCampaña.HoraFin = pHoraFin;
            pCampaña.DuracionImagen = pDuracionImagen;
            pCampaña.ListaImagenes = pListaImagen;
            this.iUdT.RepositorioCampaña.Modificar(pCampaña);
            iUdT.Guardar();
        }

        //public Campaña CampañasActivasDeHoy(string pNombre)
        //{
        //    Campaña iCampaña;
        //    iCampaña = iUdT.RepositorioCampaña.CampañasActivasDeHoy(pNombre);
        //    return iCampaña;
        //}
        public void CargarCampañasActivasComboBox(ComboBox pCombo)
        {
            IList<Campaña> listaCampañas = iUdT.RepositorioCampaña.ObtenerTodos();
            foreach (Campaña item in listaCampañas)
            {
                pCombo.Items.Add(item.Nombre);
            }
        }
        public Campaña BuscarCampaña(int pId)
        {
            Campaña iCampaña = iUdT.RepositorioCampaña.Obtener(pId);
            return iCampaña;
        }
        public Campaña BuscarCampañaPorNombre(string pCadena)
        {
            Campaña iCampaña = iUdT.RepositorioCampaña.ExistenciaCampaña(pCadena);
            return iCampaña;
        }

        //error al cargar las horas desde y hasta
        public void CargarCampañaModificar(Campaña mCampañaMod, TextBox txtNomCampañaMod, NumericUpDown nUDuracionMod, DateTimePicker dTPickFechaDesdeMod, DateTimePicker dTPickFechaHastaMod, NumericUpDown nUpDesdeHoraMod, NumericUpDown nUpHastaHoraMod, GroupBox gBoxCampañaMod)
        {

            txtNomCampañaMod.Text = mCampañaMod.Nombre;
            nUDuracionMod.Value = mCampañaMod.DuracionImagen;
            dTPickFechaDesdeMod.Value = mCampañaMod.FechaInicio;
            dTPickFechaHastaMod.Value = mCampañaMod.FechaFin;
            nUpDesdeHoraMod.Value = Convert.ToDecimal(mCampañaMod.HoraInicio.Hours);
            nUpHastaHoraMod.Value = Convert.ToDecimal(mCampañaMod.HoraFin.Hours);
            //Falta cargar el GBox imagenes

        } 
        public void EliminarCampaña(Campaña mCampañaMod)
        {
            this.iUdT.RepositorioCampaña.Eliminar(mCampañaMod);
            iUdT.Guardar();
        }
    }
}
