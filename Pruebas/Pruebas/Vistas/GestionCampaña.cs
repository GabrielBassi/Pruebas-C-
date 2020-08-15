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
        IList<Imagen> listaImagenes = new List<Imagen>();
        string rutaImagenOrigen = " ";
        string rutaImagenDestino = "C:\\Users\\Harry\\Desktop\\UTN\\Pruebas Taller\\Pruebas\\Pruebas\\ImagenesCampañas";
        string rutaImagen;

        //List <ImageList> imageList = new List<ImageList> ();

        public GestionCampaña()
        {
            InitializeComponent();
            iControladorCampaña = new ControladorCampaña(UnidadDeTrabajo.Instancia);
            
        }
        public object Tag { get; set; }
        private void tbCtrlAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptarCampaña_Click(object sender, EventArgs e)
        {
            try
            {
                

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
        
        private void CargarImagen()
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Imágenes(*.jpg, *.gif, *.bmp)|*.jpg;*.gif;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Imagen iImagen = new Imagen();
                string imagenNoDisponible = Path.Combine(Application.StartupPath, @" ");
                pBoxImagen1.Tag = imagenNoDisponible;
                rutaImagenOrigen = openFileDialog.FileName; //Busca la imagen
                pBoxImagen1.Image = Image.FromFile(rutaImagenOrigen); //carga la imagen en el picturebox
                string rutaImagen = pBoxImagen1.Tag.ToString(); //Recupera la ruta de la imagen
                File.Copy(rutaImagenOrigen, rutaImagenDestino); //Copia la direccion y debria guardar en la bd.!!!!!
                string nombreImagen = Path.GetFileName(rutaImagen); // Persistencia de la ruta en la bd.

            }
        }

        private void gBoxInfoCampaña_Enter(object sender, EventArgs e)
        {

        }

        private void CargarImag_Click(object sender, EventArgs e)
        {
            CargarImagen();

        }

        
    }
}

