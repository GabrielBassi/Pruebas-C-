using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pruebas.DAL.EntityFramework;
using Pruebas.Modelo;
namespace Pruebas.Controladores
{
    class ControladorImagen
    {
        private readonly UnidadDeTrabajo iUdT;
        int contador = 0;
        int aa = 20;
        int jj = 35;
        public ControladorImagen(UnidadDeTrabajo pUnidadDeTrabajo)
        {
            this.iUdT = pUnidadDeTrabajo;
        }

       public IList<Imagen> AgregarImagen(string pNombre, string pRutaImagen, IList<Imagen> pListaImagenes)
        {
            Imagen iImagen = new Imagen()
            {
                Nombre = pNombre,
                RutaImagen = pRutaImagen,
            };
            pListaImagenes.Add(iImagen);
            return pListaImagenes;
        }
        public void CargarImagenes(IList<Imagen> listaImagenes, GroupBox gBoxImagen) // este metodo debe hacerse en el controlador imagen?
        {

            contador = contador + 1;
            OpenFileDialog CargarImagen = new OpenFileDialog();
            CargarImagen.Filter = "Imágenes(*.jpg, *.gif, *.bmp)|*.jpg;*.gif;*.png";


            if (CargarImagen.ShowDialog() == DialogResult.OK)

            {
                if (contador == 1)
                {
                    CargoPictureBox(CargarImagen, listaImagenes, gBoxImagen, aa, jj);
                }
                else
                {
                    if (contador == 2)
                    {
                        aa = aa + 190;
                        CargoPictureBox(CargarImagen, listaImagenes, gBoxImagen, aa, jj);
                    }
                    else
                    {
                        if (contador == 3)
                        {
                            aa = aa + 190;
                            CargoPictureBox(CargarImagen, listaImagenes, gBoxImagen, aa, jj);
                        }
                        else
                        {
                            if (contador == 4)
                            {
                                aa = aa + 190;
                                CargoPictureBox(CargarImagen, listaImagenes, gBoxImagen, aa, jj);
                            }
                            else
                            {
                                if (contador == 5)
                                {
                                    aa = aa - 570; // imagen5
                                    jj = jj + 180;
                                    CargoPictureBox(CargarImagen, listaImagenes, gBoxImagen, aa, jj);
                                }
                                else
                                {
                                    if (contador == 6)
                                    {
                                        aa = aa + 190; // imagen6
                                        CargoPictureBox(CargarImagen, listaImagenes, gBoxImagen, aa, jj);
                                    }
                                    else
                                    {
                                        if (contador == 7)
                                        {
                                            aa = aa + 190; // imagen7
                                            CargoPictureBox(CargarImagen, listaImagenes, gBoxImagen, aa, jj);
                                        }
                                        else
                                        {
                                            if (contador == 8)
                                            {
                                                aa = aa + 190; // imagen 8
                                                CargoPictureBox(CargarImagen, listaImagenes, gBoxImagen, aa,jj);
                                            }
                                            else
                                            {
                                                MessageBox.Show("Límite de imágenes alcanzado por campaña", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        public void CargoPictureBox(OpenFileDialog CargarImagen, IList<Imagen> pLista, GroupBox gBoxImagen, int aa, int jj)
        {
            PictureBox imagPic = new PictureBox();
            gBoxImagen.Controls.Add(imagPic);
            imagPic.Size = new Size(150, 150);
            imagPic.SizeMode = PictureBoxSizeMode.StretchImage;
            imagPic.Location = new Point(aa, jj);
            string RutaImagen = CargarImagen.FileName;
            imagPic.ImageLocation = RutaImagen;
            imagPic.Image = Image.FromFile(CargarImagen.FileName);
            imagPic.Tag = CargarImagen.FileName;
            string nombre = Path.GetFileName(imagPic.Tag.ToString());
            AgregarImagen(nombre, RutaImagen, pLista);
        }
    }
}
