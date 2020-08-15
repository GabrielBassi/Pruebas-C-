namespace Pruebas.Vistas
{
    partial class GestionCampaña
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionCampaña));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbCtrlAgregar = new System.Windows.Forms.TabPage();
            this.pBoxImagen1 = new System.Windows.Forms.PictureBox();
            this.lblFotos = new System.Windows.Forms.Label();
            this.imgIList = new System.Windows.Forms.ImageList(this.components);
            this.gBoxInfoCampaña = new System.Windows.Forms.GroupBox();
            this.CargarImag = new System.Windows.Forms.Button();
            this.nUDuracionAgregar = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nUpHastaHoraAgregar = new System.Windows.Forms.NumericUpDown();
            this.nUpDesdeHoraAgregar = new System.Windows.Forms.NumericUpDown();
            this.lblHastaHoraAgregar = new System.Windows.Forms.Label();
            this.lblDesdeHoraAgregar = new System.Windows.Forms.Label();
            this.lblRangoHorasAgregar = new System.Windows.Forms.Label();
            this.txBoxNombreAgregarCamp = new System.Windows.Forms.TextBox();
            this.dTPickFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dTPickFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblHastaFechaAgregar = new System.Windows.Forms.Label();
            this.lblDesdeFechaAgregar = new System.Windows.Forms.Label();
            this.lblEntreFechasAgregar = new System.Windows.Forms.Label();
            this.lblNomAgregarCamp = new System.Windows.Forms.Label();
            this.tbControlModificar = new System.Windows.Forms.TabPage();
            this.btnAceptarCampaña = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tbCtrlAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxImagen1)).BeginInit();
            this.gBoxInfoCampaña.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDuracionAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpHastaHoraAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDesdeHoraAgregar)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbCtrlAgregar);
            this.tabControl1.Controls.Add(this.tbControlModificar);
            this.tabControl1.Location = new System.Drawing.Point(-1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1331, 535);
            this.tabControl1.TabIndex = 0;
            // 
            // tbCtrlAgregar
            // 
            this.tbCtrlAgregar.Controls.Add(this.pBoxImagen1);
            this.tbCtrlAgregar.Controls.Add(this.lblFotos);
            this.tbCtrlAgregar.Controls.Add(this.gBoxInfoCampaña);
            this.tbCtrlAgregar.Location = new System.Drawing.Point(4, 25);
            this.tbCtrlAgregar.Name = "tbCtrlAgregar";
            this.tbCtrlAgregar.Padding = new System.Windows.Forms.Padding(3);
            this.tbCtrlAgregar.Size = new System.Drawing.Size(1323, 506);
            this.tbCtrlAgregar.TabIndex = 0;
            this.tbCtrlAgregar.Text = "Agregar";
            this.tbCtrlAgregar.UseVisualStyleBackColor = true;
            this.tbCtrlAgregar.Click += new System.EventHandler(this.tbCtrlAgregar_Click);
            // 
            // pBoxImagen1
            // 
            this.pBoxImagen1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBoxImagen1.Location = new System.Drawing.Point(310, 207);
            this.pBoxImagen1.Name = "pBoxImagen1";
            this.pBoxImagen1.Size = new System.Drawing.Size(150, 150);
            this.pBoxImagen1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxImagen1.TabIndex = 2;
            this.pBoxImagen1.TabStop = false;
            // 
            // lblFotos
            // 
            this.lblFotos.ImageIndex = 0;
            this.lblFotos.ImageList = this.imgIList;
            this.lblFotos.Location = new System.Drawing.Point(23, 207);
            this.lblFotos.Name = "lblFotos";
            this.lblFotos.Size = new System.Drawing.Size(158, 125);
            this.lblFotos.TabIndex = 1;
            this.lblFotos.Text = "imagen";
            // 
            // imgIList
            // 
            this.imgIList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgIList.ImageStream")));
            this.imgIList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgIList.Images.SetKeyName(0, "Moto C Plus 2.jpg");
            this.imgIList.Images.SetKeyName(1, "Moto E5 play.jpg");
            this.imgIList.Images.SetKeyName(2, "Moto G6.jpg");
            // 
            // gBoxInfoCampaña
            // 
            this.gBoxInfoCampaña.Controls.Add(this.btnAceptarCampaña);
            this.gBoxInfoCampaña.Controls.Add(this.CargarImag);
            this.gBoxInfoCampaña.Controls.Add(this.nUDuracionAgregar);
            this.gBoxInfoCampaña.Controls.Add(this.label1);
            this.gBoxInfoCampaña.Controls.Add(this.nUpHastaHoraAgregar);
            this.gBoxInfoCampaña.Controls.Add(this.nUpDesdeHoraAgregar);
            this.gBoxInfoCampaña.Controls.Add(this.lblHastaHoraAgregar);
            this.gBoxInfoCampaña.Controls.Add(this.lblDesdeHoraAgregar);
            this.gBoxInfoCampaña.Controls.Add(this.lblRangoHorasAgregar);
            this.gBoxInfoCampaña.Controls.Add(this.txBoxNombreAgregarCamp);
            this.gBoxInfoCampaña.Controls.Add(this.dTPickFechaHasta);
            this.gBoxInfoCampaña.Controls.Add(this.dTPickFechaDesde);
            this.gBoxInfoCampaña.Controls.Add(this.lblHastaFechaAgregar);
            this.gBoxInfoCampaña.Controls.Add(this.lblDesdeFechaAgregar);
            this.gBoxInfoCampaña.Controls.Add(this.lblEntreFechasAgregar);
            this.gBoxInfoCampaña.Controls.Add(this.lblNomAgregarCamp);
            this.gBoxInfoCampaña.Location = new System.Drawing.Point(4, 7);
            this.gBoxInfoCampaña.Name = "gBoxInfoCampaña";
            this.gBoxInfoCampaña.Size = new System.Drawing.Size(1313, 175);
            this.gBoxInfoCampaña.TabIndex = 0;
            this.gBoxInfoCampaña.TabStop = false;
            this.gBoxInfoCampaña.Text = "Información de campaña";
            // 
            // CargarImag
            // 
            this.CargarImag.Image = global::Pruebas.Properties.Resources._Imagen;
            this.CargarImag.Location = new System.Drawing.Point(778, 21);
            this.CargarImag.Name = "CargarImag";
            this.CargarImag.Size = new System.Drawing.Size(60, 60);
            this.CargarImag.TabIndex = 19;
            this.CargarImag.UseVisualStyleBackColor = true;
            this.CargarImag.Click += new System.EventHandler(this.CargarImag_Click);
            // 
            // nUDuracionAgregar
            // 
            this.nUDuracionAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nUDuracionAgregar.Location = new System.Drawing.Point(184, 119);
            this.nUDuracionAgregar.Name = "nUDuracionAgregar";
            this.nUDuracionAgregar.Size = new System.Drawing.Size(64, 22);
            this.nUDuracionAgregar.TabIndex = 18;
            this.nUDuracionAgregar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Duracion de Imagen";
            // 
            // nUpHastaHoraAgregar
            // 
            this.nUpHastaHoraAgregar.Location = new System.Drawing.Point(645, 122);
            this.nUpHastaHoraAgregar.Name = "nUpHastaHoraAgregar";
            this.nUpHastaHoraAgregar.Size = new System.Drawing.Size(67, 22);
            this.nUpHastaHoraAgregar.TabIndex = 16;
            this.nUpHastaHoraAgregar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nUpDesdeHoraAgregar
            // 
            this.nUpDesdeHoraAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nUpDesdeHoraAgregar.Location = new System.Drawing.Point(645, 81);
            this.nUpDesdeHoraAgregar.Name = "nUpDesdeHoraAgregar";
            this.nUpDesdeHoraAgregar.Size = new System.Drawing.Size(64, 22);
            this.nUpDesdeHoraAgregar.TabIndex = 15;
            this.nUpDesdeHoraAgregar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblHastaHoraAgregar
            // 
            this.lblHastaHoraAgregar.AutoSize = true;
            this.lblHastaHoraAgregar.Location = new System.Drawing.Point(566, 127);
            this.lblHastaHoraAgregar.Name = "lblHastaHoraAgregar";
            this.lblHastaHoraAgregar.Size = new System.Drawing.Size(45, 17);
            this.lblHastaHoraAgregar.TabIndex = 14;
            this.lblHastaHoraAgregar.Text = "Hasta";
            // 
            // lblDesdeHoraAgregar
            // 
            this.lblDesdeHoraAgregar.AutoSize = true;
            this.lblDesdeHoraAgregar.Location = new System.Drawing.Point(566, 81);
            this.lblDesdeHoraAgregar.Name = "lblDesdeHoraAgregar";
            this.lblDesdeHoraAgregar.Size = new System.Drawing.Size(49, 17);
            this.lblDesdeHoraAgregar.TabIndex = 13;
            this.lblDesdeHoraAgregar.Text = "Desde";
            // 
            // lblRangoHorasAgregar
            // 
            this.lblRangoHorasAgregar.AutoSize = true;
            this.lblRangoHorasAgregar.Location = new System.Drawing.Point(566, 41);
            this.lblRangoHorasAgregar.Name = "lblRangoHorasAgregar";
            this.lblRangoHorasAgregar.Size = new System.Drawing.Size(112, 17);
            this.lblRangoHorasAgregar.TabIndex = 12;
            this.lblRangoHorasAgregar.Text = "Rango de Horas";
            // 
            // txBoxNombreAgregarCamp
            // 
            this.txBoxNombreAgregarCamp.Location = new System.Drawing.Point(101, 79);
            this.txBoxNombreAgregarCamp.Name = "txBoxNombreAgregarCamp";
            this.txBoxNombreAgregarCamp.Size = new System.Drawing.Size(180, 22);
            this.txBoxNombreAgregarCamp.TabIndex = 11;
            // 
            // dTPickFechaHasta
            // 
            this.dTPickFechaHasta.Checked = false;
            this.dTPickFechaHasta.CustomFormat = "dd/MM/yyyy";
            this.dTPickFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPickFechaHasta.Location = new System.Drawing.Point(405, 125);
            this.dTPickFechaHasta.MinDate = new System.DateTime(2020, 6, 1, 0, 0, 0, 0);
            this.dTPickFechaHasta.Name = "dTPickFechaHasta";
            this.dTPickFechaHasta.Size = new System.Drawing.Size(113, 22);
            this.dTPickFechaHasta.TabIndex = 10;
            this.dTPickFechaHasta.Value = new System.DateTime(2020, 8, 13, 0, 0, 0, 0);
            // 
            // dTPickFechaDesde
            // 
            this.dTPickFechaDesde.CustomFormat = "dd/MM/yyyy";
            this.dTPickFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPickFechaDesde.Location = new System.Drawing.Point(405, 81);
            this.dTPickFechaDesde.MinDate = new System.DateTime(2020, 6, 1, 0, 0, 0, 0);
            this.dTPickFechaDesde.Name = "dTPickFechaDesde";
            this.dTPickFechaDesde.Size = new System.Drawing.Size(113, 22);
            this.dTPickFechaDesde.TabIndex = 9;
            this.dTPickFechaDesde.Value = new System.DateTime(2020, 8, 13, 0, 0, 0, 0);
            // 
            // lblHastaFechaAgregar
            // 
            this.lblHastaFechaAgregar.AutoSize = true;
            this.lblHastaFechaAgregar.Location = new System.Drawing.Point(333, 127);
            this.lblHastaFechaAgregar.Name = "lblHastaFechaAgregar";
            this.lblHastaFechaAgregar.Size = new System.Drawing.Size(45, 17);
            this.lblHastaFechaAgregar.TabIndex = 8;
            this.lblHastaFechaAgregar.Text = "Hasta";
            // 
            // lblDesdeFechaAgregar
            // 
            this.lblDesdeFechaAgregar.AutoSize = true;
            this.lblDesdeFechaAgregar.Location = new System.Drawing.Point(333, 83);
            this.lblDesdeFechaAgregar.Name = "lblDesdeFechaAgregar";
            this.lblDesdeFechaAgregar.Size = new System.Drawing.Size(49, 17);
            this.lblDesdeFechaAgregar.TabIndex = 7;
            this.lblDesdeFechaAgregar.Text = "Desde";
            // 
            // lblEntreFechasAgregar
            // 
            this.lblEntreFechasAgregar.AutoSize = true;
            this.lblEntreFechasAgregar.Location = new System.Drawing.Point(329, 41);
            this.lblEntreFechasAgregar.Name = "lblEntreFechasAgregar";
            this.lblEntreFechasAgregar.Size = new System.Drawing.Size(133, 17);
            this.lblEntreFechasAgregar.TabIndex = 6;
            this.lblEntreFechasAgregar.Text = "Rango entre fechas";
            // 
            // lblNomAgregarCamp
            // 
            this.lblNomAgregarCamp.AutoSize = true;
            this.lblNomAgregarCamp.Location = new System.Drawing.Point(32, 79);
            this.lblNomAgregarCamp.Name = "lblNomAgregarCamp";
            this.lblNomAgregarCamp.Size = new System.Drawing.Size(62, 17);
            this.lblNomAgregarCamp.TabIndex = 0;
            this.lblNomAgregarCamp.Text = "Nombre ";
            // 
            // tbControlModificar
            // 
            this.tbControlModificar.Location = new System.Drawing.Point(4, 25);
            this.tbControlModificar.Name = "tbControlModificar";
            this.tbControlModificar.Padding = new System.Windows.Forms.Padding(3);
            this.tbControlModificar.Size = new System.Drawing.Size(1323, 506);
            this.tbControlModificar.TabIndex = 1;
            this.tbControlModificar.Text = "Modificar";
            this.tbControlModificar.UseVisualStyleBackColor = true;
            // 
            // btnAceptarCampaña
            // 
            this.btnAceptarCampaña.Location = new System.Drawing.Point(793, 119);
            this.btnAceptarCampaña.Name = "btnAceptarCampaña";
            this.btnAceptarCampaña.Size = new System.Drawing.Size(109, 50);
            this.btnAceptarCampaña.TabIndex = 20;
            this.btnAceptarCampaña.Text = "Aceptar";
            this.btnAceptarCampaña.UseVisualStyleBackColor = true;
            this.btnAceptarCampaña.Click += new System.EventHandler(this.btnAceptarCampaña_Click);
            // 
            // GestionCampaña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 542);
            this.Controls.Add(this.tabControl1);
            this.Name = "GestionCampaña";
            this.Text = "GestiónCampaña";
            this.tabControl1.ResumeLayout(false);
            this.tbCtrlAgregar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxImagen1)).EndInit();
            this.gBoxInfoCampaña.ResumeLayout(false);
            this.gBoxInfoCampaña.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDuracionAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpHastaHoraAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDesdeHoraAgregar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbCtrlAgregar;
        private System.Windows.Forms.TabPage tbControlModificar;
        private System.Windows.Forms.GroupBox gBoxInfoCampaña;
        private System.Windows.Forms.Label lblNomAgregarCamp;
        private System.Windows.Forms.Label lblHastaHoraAgregar;
        private System.Windows.Forms.Label lblDesdeHoraAgregar;
        private System.Windows.Forms.Label lblRangoHorasAgregar;
        private System.Windows.Forms.TextBox txBoxNombreAgregarCamp;
        private System.Windows.Forms.DateTimePicker dTPickFechaHasta;
        private System.Windows.Forms.DateTimePicker dTPickFechaDesde;
        private System.Windows.Forms.Label lblHastaFechaAgregar;
        private System.Windows.Forms.Label lblDesdeFechaAgregar;
        private System.Windows.Forms.Label lblEntreFechasAgregar;
        private System.Windows.Forms.NumericUpDown nUDuracionAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nUpHastaHoraAgregar;
        private System.Windows.Forms.NumericUpDown nUpDesdeHoraAgregar;
        private System.Windows.Forms.Button CargarImag;
        private System.Windows.Forms.Label lblFotos;
        private System.Windows.Forms.ImageList imgIList;
        private System.Windows.Forms.PictureBox pBoxImagen1;
        private System.Windows.Forms.Button btnAceptarCampaña;
    }
}