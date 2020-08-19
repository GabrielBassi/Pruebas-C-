using System;
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
        IList<Imagen> listaImagenes = new List<Imagen>();

        public GestionCampaña()
        {
            InitializeComponent();
            iControladorCampaña = new ControladorCampaña(UnidadDeTrabajo.Instancia);
            iControladorImagen = new ControladorImagen(UnidadDeTrabajo.Instancia);           
        }
        
        private void tbCtrlAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptarCampaña_Click(object sender, EventArgs e)
        {
            try
            {
                //Métodos de control de los campos fechas, horas y duración.
                DateTime pFechaInicio = new DateTime(this.dTPickFechaDesde.Value.Year, this.dTPickFechaDesde.Value.Month, this.dTPickFechaDesde.Value.Day, Convert.ToInt32(this.nUpDesdeHoraAgregar.Text), 0, 0);
                DateTime pFechaFin = new DateTime(this.dTPickFechaHasta.Value.Year, this.dTPickFechaHasta.Value.Month, this.dTPickFechaHasta.Value.Day, Convert.ToInt32(this.nUpHastaHoraAgregar.Text), 0, 0);
                iControladorCampaña.ValidarFecha(pFechaInicio, pFechaFin); 
                // me salta el error pero lo guarda igual
                //la hora tiene que ser de 00:01 am a 23:59 pm 
                if (string.IsNullOrWhiteSpace(txBoxNombreAgregarCamp.Text) || (string.IsNullOrWhiteSpace(dTPickFechaDesde.Text))
                || (string.IsNullOrWhiteSpace(dTPickFechaHasta.Text)) || (string.IsNullOrWhiteSpace(nUDuracionAgregar.Text))
                || (string.IsNullOrWhiteSpace(nUpDesdeHoraAgregar.Text)) || (string.IsNullOrWhiteSpace(nUpHastaHoraAgregar.Text)))

                {
                    throw new FaltanDatosObligatorios("Los campos no pueden quedar vacios");
                }

                iControladorCampaña.AgregarCampaña(txBoxNombreAgregarCamp.Text, Convert.ToDateTime(dTPickFechaDesde.Text), Convert.ToDateTime(dTPickFechaHasta.Text), Convert.ToDateTime(dTPickFechaDesde.Text), Convert.ToDateTime(dTPickFechaHasta.Text), Convert.ToInt32(nUDuracionAgregar.Text), listaImagenes);
                MessageBox.Show("Registro Correcto", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
           iControladorImagen.CargarImagenes(listaImagenes, gBoxImagenes);            
        }

        private void BtnCancelarCampaña_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarImagMod_Click(object sender, EventArgs e)
        {

        }
    }
}

