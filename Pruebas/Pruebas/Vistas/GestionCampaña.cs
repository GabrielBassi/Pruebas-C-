﻿using System;
using Pruebas.Controladores;
using Pruebas.DAL.EntityFramework;
using Pruebas.Modelo;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using Pruebas.Excepciones;

namespace Pruebas.Vistas
{
    public partial class GestionCampaña : Form
    {
        ControladorCampaña iControladorCampaña;
        ControladorImagen iControladorImagen;
        Campaña mCampañaMod, pCampaña;
        IList<Imagen> listaImagenes = new List<Imagen>();
        IList<Imagen> listaImagenesMod = new List<Imagen>();
        int aa = 20;
        int jj = 35;

        public GestionCampaña()
        {
            InitializeComponent();
            iControladorCampaña = new ControladorCampaña(UnidadDeTrabajo.Instancia);
            iControladorImagen = new ControladorImagen(UnidadDeTrabajo.Instancia,aa,jj);           
        }
        
        private void TbCtrlAgregar_Click(object sender, EventArgs e)
        {

        }

        private void BtnAceptarCampaña_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txBoxNombreAgregarCamp.Text) || (string.IsNullOrWhiteSpace(dTPickFechaDesde.Text))
              || (string.IsNullOrWhiteSpace(dTPickFechaHasta.Text)) || (string.IsNullOrWhiteSpace(nUDuracionAgregar.Text))
              || (string.IsNullOrWhiteSpace(nUpDesdeHoraAgregar.Text)) || (string.IsNullOrWhiteSpace(nUpHastaHoraAgregar.Text)))
              

                {
                    throw new FaltanDatosObligatorios("Los campos no pueden quedar vacios");
                }
                //Métodos de control de los campos fechas, horas y duración.
                DateTime pFechaInicio = new DateTime(this.dTPickFechaDesde.Value.Year, this.dTPickFechaDesde.Value.Month, this.dTPickFechaDesde.Value.Day, Convert.ToInt32(this.nUpDesdeHoraAgregar.Text), 0, 0);
                DateTime pFechaFin = new DateTime(this.dTPickFechaHasta.Value.Year, this.dTPickFechaHasta.Value.Month, this.dTPickFechaHasta.Value.Day, Convert.ToInt32(this.nUpHastaHoraAgregar.Text), 0, 0);
                int pHoraInicio = Convert.ToInt32(nUpDesdeHoraAgregar.Value);
                int pHoraFin = Convert.ToInt32(nUpHastaHoraAgregar.Value); ;
                iControladorCampaña.ValidarFecha(pFechaInicio, pFechaFin);
                iControladorCampaña.ValidarHora(pHoraInicio, pHoraFin);
                
                if (listaImagenes.Count==0)
                {
                    throw new FaltanDatosObligatorios("Faltar Cargar Imágenes a la Campaña");
                }
                iControladorCampaña.AgregarCampaña(txBoxNombreAgregarCamp.Text, pFechaInicio, pFechaFin, pFechaInicio.TimeOfDay, pFechaFin.TimeOfDay, Convert.ToInt32(nUDuracionAgregar.Text), listaImagenes);
                MessageBox.Show("Registro Correcto", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarPantallaAlta();
                //iControladorImagen.RestablecerContador(20,35);
            }
            catch(ExcepcionControlFechas msg)
            {
                MessageBox.Show(msg.Message, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FaltanDatosObligatorios ex)
            {
                MessageBox.Show(ex.Message, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarImag_Click(object sender, EventArgs e)
        {
            try
            {
                iControladorImagen.CargarImagenes(listaImagenes, gBoxImagenes);
            }
            catch 
            {
                
            }
                       
        }

        private void BtnVolverCampaña_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnModVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CBoxModCampActivas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                gBoxImagenMod.Controls.Clear();
                mCampañaMod = iControladorCampaña.BuscarCampañaPorNombre(cBoxModCampActivas.Text);
                iControladorCampaña.CargarCampañaModificar(mCampañaMod, txtNomCampañaMod, nUDuracionMod, dTPickFechaDesdeMod, dTPickFechaHastaMod, nUpDesdeHoraMod, nUpHastaHoraMod, gBoxImagenMod);
                //iControladorCampaña.ModificarCampaña(mCampañaMod, txtNomCampañaMod.Text, pFechaInicio, pFechaFin, pFechaInicio.TimeOfDay, pFechaFin.TimeOfDay, Convert.ToInt32(nUDuracionMod.Text), listaImagenes);

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error al cargar", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarImagMod_Click(object sender, EventArgs e)
        {
           // iControladorImagen.CargarImagenes(listaImagenes, gBoxImagenes);
            iControladorImagen.CargarImagenesMod2(mCampañaMod.ListaImagenes,listaImagenesMod, gBoxImagenMod);
        }

        
        private void GestionCampaña_Load(object sender, EventArgs e)
        {
            dTPickFechaDesde.Value = DateTime.Today;
            dTPickFechaHasta.Value = DateTime.Today;
            iControladorCampaña.CargarCampañasActivasComboBox(cBoxModCampActivas);
        }

        private void TabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                LimpiarPantallaAlta();
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                LimpiarPantallaMod();
            }
        }

        private void LimpiarPantallaAlta()
        {
            txBoxNombreAgregarCamp.Text = "";
            nUDuracionAgregar.Text = "5";
            dTPickFechaDesde.Value = DateTime.Now;
            dTPickFechaHasta.Value = DateTime.Now;
            nUpDesdeHoraAgregar.Value = 0;
            nUpHastaHoraAgregar.Value = 0;
            gBoxImagenes.Controls.Clear();
            listaImagenes.Clear();
            listaImagenes = new List<Imagen>();
         //   listaImagenes.Clear();
            //Se limpia el gBox pero no se reinicia el cuadro de las imagenes
        }
        private void LimpiarPantallaMod() 
        {
            cBoxModCampActivas.Text = "";
            txtNomCampañaMod.Text = "";
            nUDuracionMod.Text = "5";
            dTPickFechaDesdeMod.Value = DateTime.Now;
            dTPickFechaHastaMod.Value = DateTime.Now;
            nUpDesdeHoraMod.Value = 0;
            nUpHastaHoraMod.Value = 0;
            gBoxImagenes.Controls.Clear();
            //Se limpia el gBox pero no se reinicia el cuadro de las imagenes
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNomCampañaMod.Text) || (string.IsNullOrWhiteSpace(dTPickFechaDesdeMod.Text))
                 || (string.IsNullOrWhiteSpace(dTPickFechaHastaMod.Text)) || (string.IsNullOrWhiteSpace(nUDuracionMod.Text))
                 || (string.IsNullOrWhiteSpace(nUpDesdeHoraMod.Text)) || (string.IsNullOrWhiteSpace(nUpHastaHoraMod.Text)))

                {
                    throw new FaltanDatosObligatorios("Los campos no pueden quedar vacios");
                }
                DateTime pFechaInicio = new DateTime(this.dTPickFechaDesdeMod.Value.Year, this.dTPickFechaDesdeMod.Value.Month, this.dTPickFechaDesdeMod.Value.Day, Convert.ToInt32(this.nUpDesdeHoraMod.Text), 0, 0);
                DateTime pFechaFin = new DateTime(this.dTPickFechaHastaMod.Value.Year, this.dTPickFechaHastaMod.Value.Month, this.dTPickFechaHastaMod.Value.Day, Convert.ToInt32(this.nUpHastaHoraMod.Text), 0, 0);
                int pHoraInicio = Convert.ToInt32(nUpDesdeHoraMod.Value); 
                int pHoraFin =Convert.ToInt32(nUpHastaHoraMod.Value);
                iControladorCampaña.ValidarFecha(pFechaInicio, pFechaFin);
                iControladorCampaña.ValidarHora(pHoraInicio, pHoraFin);
                //if (listaImagenesMod.Count == 0)
                //{
                //    throw new FaltanDatosObligatorios("Faltar Cargar Imágenes a la Campaña");
                //}
                //if (mCampañaMod.ListaImagenes.Count == 0)
                //{
                //    throw new FaltanDatosObligatorios("Faltar Cargar Imágenes a la Campaña");
                //}

                iControladorCampaña.ModificarCampaña(mCampañaMod, txtNomCampañaMod.Text, pFechaInicio, pFechaFin, pFechaInicio.TimeOfDay, pFechaFin.TimeOfDay, Convert.ToInt32(nUDuracionMod.Text), mCampañaMod.ListaImagenes);
                
                MessageBox.Show("Registro Correcto", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarPantallaAlta();
            }
            catch (ExcepcionControlFechas msg)
            {
                MessageBox.Show(msg.Message, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FaltanDatosObligatorios ex)
            {
                MessageBox.Show(ex.Message, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnModEliminar_Click(object sender, EventArgs e)
        {
            iControladorCampaña.EliminarCampaña(mCampañaMod);
            cBoxModCampActivas.Items.Clear();
            iControladorCampaña.CargarCampañasActivasComboBox(cBoxModCampActivas);
        }
    }
}


