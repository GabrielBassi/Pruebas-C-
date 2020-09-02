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
        int aa = 0;
        int jj = 0;
        public ControladorImagen(UnidadDeTrabajo pUnidadDeTrabajo, int pAa, int pjj)
        {
            this.iUdT = pUnidadDeTrabajo;
            aa = pAa;
            jj = pjj;
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
        public void CargarImagenes(IList<Imagen> listaImagenes, GroupBox gBoxImagen)
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
        
        public void CargoPictureBoxModificar(IList<Imagen> pLista, GroupBox gBoxImagenMod, int aa, int jj)
        {
            if (pLista.Count <= 4)
            {
                foreach (var item in pLista)
                {
                    PictureBox imagPic = new PictureBox();
                    gBoxImagenMod.Controls.Add(imagPic);
                    imagPic.Size = new Size(150, 150);
                    imagPic.SizeMode = PictureBoxSizeMode.StretchImage;
                    imagPic.Location = new Point(aa, jj);
                    imagPic.Image = Image.FromFile(item.RutaImagen);
                    aa = aa + 190;
                }

            }
            else
            {
                if (pLista.Count >= 5)
                {
                    int contador = 0;
                    foreach (var item in pLista)
                    {
                        PictureBox imagPic = new PictureBox();
                        gBoxImagenMod.Controls.Add(imagPic);
                        imagPic.Size = new Size(150, 150);
                        imagPic.SizeMode = PictureBoxSizeMode.StretchImage;
                        imagPic.Location = new Point(aa, jj);
                        imagPic.Image = Image.FromFile(item.RutaImagen);
                        aa = aa + 190;
                        contador = contador + 1;
                        if (contador == 5)
                        {
                            aa = aa + 190; // imagen5
                            jj = jj + 180;
                            gBoxImagenMod.Controls.Add(imagPic);
                            imagPic.Size = new Size(150, 150);
                            imagPic.SizeMode = PictureBoxSizeMode.StretchImage;
                            imagPic.Location = new Point(20, jj);
                            imagPic.Image = Image.FromFile(item.RutaImagen);
                        }

                        if (contador == 6)
                        {
                            // aa = aa - 200; // imagen6
                            //jj = jj + 180;
                            gBoxImagenMod.Controls.Add(imagPic);
                            imagPic.Size = new Size(150, 150);
                            imagPic.SizeMode = PictureBoxSizeMode.StretchImage;
                            imagPic.Location = new Point(210, jj);
                            imagPic.Image = Image.FromFile(item.RutaImagen);
                        }
                        if (contador == 7)
                        {
                            // aa = aa + 190; // imagen7
                            gBoxImagenMod.Controls.Add(imagPic);
                            imagPic.Size = new Size(150, 150);
                            imagPic.SizeMode = PictureBoxSizeMode.StretchImage;
                            imagPic.Location = new Point(400, jj);
                            imagPic.Image = Image.FromFile(item.RutaImagen);
                        }

                        if (contador == 8)
                        {
                            //  aa = aa + 190; // imagen 8
                            gBoxImagenMod.Controls.Add(imagPic);
                            imagPic.Size = new Size(150, 150);
                            imagPic.SizeMode = PictureBoxSizeMode.StretchImage;
                            imagPic.Location = new Point(590, jj);
                            imagPic.Image = Image.FromFile(item.RutaImagen);
                            //   CargoPictureBox(CargarImagen, listaImagenes, gBoxImagen, aa, jj);
                        }
                        //else
                        //{
                        //    MessageBox.Show("Límite de imágenes alcanzado por campaña", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //}

                    }
                }
            }
        }

        public void CargarImagenesMod(IList<Imagen> listaImagenes, GroupBox gBoxImagenMod)
        {

            contador = contador + 1;
            OpenFileDialog CargarImagenMod = new OpenFileDialog();
            CargarImagenMod.Filter = "Imágenes(*.jpg, *.gif, *.bmp)|*.jpg;*.gif;*.png";


            if (CargarImagenMod.ShowDialog() == DialogResult.OK)

            {
                if (contador == 1)
                {
                    CargoPictureBoxModificar(listaImagenes, gBoxImagenMod, aa, jj);
                }
                else
                {
                    if (contador == 2)
                    {
                        aa = aa + 190;
                        CargoPictureBoxModificar(listaImagenes, gBoxImagenMod, aa, jj);
                    }
                    else
                    {
                        if (contador == 3)
                        {
                            aa = aa + 190;
                            CargoPictureBoxModificar(listaImagenes, gBoxImagenMod, aa, jj);
                        }
                        else
                        {
                            if (contador == 4)
                            {
                                aa = aa + 190;
                                CargoPictureBoxModificar(listaImagenes, gBoxImagenMod, aa, jj);
                            }
                            else
                            {
                                if (contador == 5)
                                {
                                    aa = aa - 570; // imagen5
                                    jj = jj + 180;
                                    CargoPictureBoxModificar(listaImagenes, gBoxImagenMod, aa, jj);
                                }
                                else
                                {
                                    if (contador == 6)
                                    {
                                        aa = aa + 190; // imagen6
                                        CargoPictureBoxModificar(listaImagenes, gBoxImagenMod, aa, jj);
                                    }
                                    else
                                    {
                                        if (contador == 7)
                                        {
                                            aa = aa + 190; // imagen7
                                            CargoPictureBoxModificar(listaImagenes, gBoxImagenMod, aa, jj);
                                        }
                                        else
                                        {
                                            if (contador == 8)
                                            {
                                                aa = aa + 190; // imagen 8
                                                CargoPictureBoxModificar(listaImagenes, gBoxImagenMod, aa, jj);
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
    }
}
