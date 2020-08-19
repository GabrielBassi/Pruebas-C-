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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbCtrlAgregar = new System.Windows.Forms.TabPage();
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
            this.gBoxImagenes = new System.Windows.Forms.GroupBox();
            this.btnAceptarCampaña = new System.Windows.Forms.Button();
            this.BtnCancelarCampaña = new System.Windows.Forms.Button();
            this.tbControlModificar = new System.Windows.Forms.TabPage();
            this.btnModEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnModCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gBoxModCampaña = new System.Windows.Forms.GroupBox();
            this.CargarImagMod = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cBoxModCampActivas = new System.Windows.Forms.ComboBox();
            this.lblModCampañasAct = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tbCtrlAgregar.SuspendLayout();
            this.gBoxInfoCampaña.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDuracionAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpHastaHoraAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDesdeHoraAgregar)).BeginInit();
            this.gBoxImagenes.SuspendLayout();
            this.tbControlModificar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gBoxModCampaña.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbCtrlAgregar);
            this.tabControl1.Controls.Add(this.tbControlModificar);
            this.tabControl1.Location = new System.Drawing.Point(-1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1046, 763);
            this.tabControl1.TabIndex = 0;
            // 
            // tbCtrlAgregar
            // 
            this.tbCtrlAgregar.Controls.Add(this.gBoxInfoCampaña);
            this.tbCtrlAgregar.Controls.Add(this.gBoxImagenes);
            this.tbCtrlAgregar.Location = new System.Drawing.Point(4, 25);
            this.tbCtrlAgregar.Name = "tbCtrlAgregar";
            this.tbCtrlAgregar.Padding = new System.Windows.Forms.Padding(3);
            this.tbCtrlAgregar.Size = new System.Drawing.Size(1038, 734);
            this.tbCtrlAgregar.TabIndex = 0;
            this.tbCtrlAgregar.Text = "Agregar";
            this.tbCtrlAgregar.UseVisualStyleBackColor = true;
            this.tbCtrlAgregar.Click += new System.EventHandler(this.tbCtrlAgregar_Click);
            // 
            // gBoxInfoCampaña
            // 
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
            this.gBoxInfoCampaña.Location = new System.Drawing.Point(10, 7);
            this.gBoxInfoCampaña.Name = "gBoxInfoCampaña";
            this.gBoxInfoCampaña.Size = new System.Drawing.Size(1016, 175);
            this.gBoxInfoCampaña.TabIndex = 0;
            this.gBoxInfoCampaña.TabStop = false;
            this.gBoxInfoCampaña.Text = "Información de campaña";
            // 
            // CargarImag
            // 
            this.CargarImag.Image = global::Pruebas.Properties.Resources._Imagen;
            this.CargarImag.Location = new System.Drawing.Point(938, 21);
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
            this.nUDuracionAgregar.Location = new System.Drawing.Point(219, 128);
            this.nUDuracionAgregar.Name = "nUDuracionAgregar";
            this.nUDuracionAgregar.Size = new System.Drawing.Size(67, 22);
            this.nUDuracionAgregar.TabIndex = 18;
            this.nUDuracionAgregar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Duracion entre imagenes";
            // 
            // nUpHastaHoraAgregar
            // 
            this.nUpHastaHoraAgregar.Location = new System.Drawing.Point(788, 128);
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
            this.nUpDesdeHoraAgregar.Location = new System.Drawing.Point(788, 91);
            this.nUpDesdeHoraAgregar.Name = "nUpDesdeHoraAgregar";
            this.nUpDesdeHoraAgregar.Size = new System.Drawing.Size(67, 22);
            this.nUpDesdeHoraAgregar.TabIndex = 15;
            this.nUpDesdeHoraAgregar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblHastaHoraAgregar
            // 
            this.lblHastaHoraAgregar.AutoSize = true;
            this.lblHastaHoraAgregar.Location = new System.Drawing.Point(713, 130);
            this.lblHastaHoraAgregar.Name = "lblHastaHoraAgregar";
            this.lblHastaHoraAgregar.Size = new System.Drawing.Size(45, 17);
            this.lblHastaHoraAgregar.TabIndex = 14;
            this.lblHastaHoraAgregar.Text = "Hasta";
            // 
            // lblDesdeHoraAgregar
            // 
            this.lblDesdeHoraAgregar.AutoSize = true;
            this.lblDesdeHoraAgregar.Location = new System.Drawing.Point(713, 96);
            this.lblDesdeHoraAgregar.Name = "lblDesdeHoraAgregar";
            this.lblDesdeHoraAgregar.Size = new System.Drawing.Size(49, 17);
            this.lblDesdeHoraAgregar.TabIndex = 13;
            this.lblDesdeHoraAgregar.Text = "Desde";
            // 
            // lblRangoHorasAgregar
            // 
            this.lblRangoHorasAgregar.AutoSize = true;
            this.lblRangoHorasAgregar.Location = new System.Drawing.Point(713, 43);
            this.lblRangoHorasAgregar.Name = "lblRangoHorasAgregar";
            this.lblRangoHorasAgregar.Size = new System.Drawing.Size(112, 17);
            this.lblRangoHorasAgregar.TabIndex = 12;
            this.lblRangoHorasAgregar.Text = "Rango de Horas";
            // 
            // txBoxNombreAgregarCamp
            // 
            this.txBoxNombreAgregarCamp.Location = new System.Drawing.Point(38, 73);
            this.txBoxNombreAgregarCamp.Name = "txBoxNombreAgregarCamp";
            this.txBoxNombreAgregarCamp.Size = new System.Drawing.Size(234, 22);
            this.txBoxNombreAgregarCamp.TabIndex = 11;
            // 
            // dTPickFechaHasta
            // 
            this.dTPickFechaHasta.Checked = false;
            this.dTPickFechaHasta.CustomFormat = "dd/MM/yyyy";
            this.dTPickFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPickFechaHasta.Location = new System.Drawing.Point(489, 128);
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
            this.dTPickFechaDesde.Location = new System.Drawing.Point(489, 91);
            this.dTPickFechaDesde.MinDate = new System.DateTime(2020, 6, 1, 0, 0, 0, 0);
            this.dTPickFechaDesde.Name = "dTPickFechaDesde";
            this.dTPickFechaDesde.Size = new System.Drawing.Size(113, 22);
            this.dTPickFechaDesde.TabIndex = 9;
            this.dTPickFechaDesde.Value = new System.DateTime(2020, 8, 19, 0, 0, 0, 0);
            // 
            // lblHastaFechaAgregar
            // 
            this.lblHastaFechaAgregar.AutoSize = true;
            this.lblHastaFechaAgregar.Location = new System.Drawing.Point(413, 128);
            this.lblHastaFechaAgregar.Name = "lblHastaFechaAgregar";
            this.lblHastaFechaAgregar.Size = new System.Drawing.Size(45, 17);
            this.lblHastaFechaAgregar.TabIndex = 8;
            this.lblHastaFechaAgregar.Text = "Hasta";
            // 
            // lblDesdeFechaAgregar
            // 
            this.lblDesdeFechaAgregar.AutoSize = true;
            this.lblDesdeFechaAgregar.Location = new System.Drawing.Point(413, 96);
            this.lblDesdeFechaAgregar.Name = "lblDesdeFechaAgregar";
            this.lblDesdeFechaAgregar.Size = new System.Drawing.Size(49, 17);
            this.lblDesdeFechaAgregar.TabIndex = 7;
            this.lblDesdeFechaAgregar.Text = "Desde";
            // 
            // lblEntreFechasAgregar
            // 
            this.lblEntreFechasAgregar.AutoSize = true;
            this.lblEntreFechasAgregar.Location = new System.Drawing.Point(413, 43);
            this.lblEntreFechasAgregar.Name = "lblEntreFechasAgregar";
            this.lblEntreFechasAgregar.Size = new System.Drawing.Size(133, 17);
            this.lblEntreFechasAgregar.TabIndex = 6;
            this.lblEntreFechasAgregar.Text = "Rango entre fechas";
            // 
            // lblNomAgregarCamp
            // 
            this.lblNomAgregarCamp.AutoSize = true;
            this.lblNomAgregarCamp.Location = new System.Drawing.Point(35, 43);
            this.lblNomAgregarCamp.Name = "lblNomAgregarCamp";
            this.lblNomAgregarCamp.Size = new System.Drawing.Size(62, 17);
            this.lblNomAgregarCamp.TabIndex = 0;
            this.lblNomAgregarCamp.Text = "Nombre ";
            // 
            // gBoxImagenes
            // 
            this.gBoxImagenes.Controls.Add(this.btnAceptarCampaña);
            this.gBoxImagenes.Controls.Add(this.BtnCancelarCampaña);
            this.gBoxImagenes.Location = new System.Drawing.Point(10, 188);
            this.gBoxImagenes.Name = "gBoxImagenes";
            this.gBoxImagenes.Size = new System.Drawing.Size(1016, 540);
            this.gBoxImagenes.TabIndex = 3;
            this.gBoxImagenes.TabStop = false;
            this.gBoxImagenes.Text = "Imágenes a visualizar";
            // 
            // btnAceptarCampaña
            // 
            this.btnAceptarCampaña.Location = new System.Drawing.Point(307, 473);
            this.btnAceptarCampaña.Name = "btnAceptarCampaña";
            this.btnAceptarCampaña.Size = new System.Drawing.Size(110, 50);
            this.btnAceptarCampaña.TabIndex = 20;
            this.btnAceptarCampaña.Text = "Aceptar";
            this.btnAceptarCampaña.UseVisualStyleBackColor = true;
            this.btnAceptarCampaña.Click += new System.EventHandler(this.btnAceptarCampaña_Click);
            // 
            // BtnCancelarCampaña
            // 
            this.BtnCancelarCampaña.Location = new System.Drawing.Point(615, 473);
            this.BtnCancelarCampaña.Name = "BtnCancelarCampaña";
            this.BtnCancelarCampaña.Size = new System.Drawing.Size(110, 50);
            this.BtnCancelarCampaña.TabIndex = 21;
            this.BtnCancelarCampaña.Text = "Cancelar";
            this.BtnCancelarCampaña.UseVisualStyleBackColor = true;
            this.BtnCancelarCampaña.Click += new System.EventHandler(this.BtnCancelarCampaña_Click);
            // 
            // tbControlModificar
            // 
            this.tbControlModificar.Controls.Add(this.btnModEliminar);
            this.tbControlModificar.Controls.Add(this.btnModificar);
            this.tbControlModificar.Controls.Add(this.btnModCancelar);
            this.tbControlModificar.Controls.Add(this.groupBox1);
            this.tbControlModificar.Controls.Add(this.gBoxModCampaña);
            this.tbControlModificar.Location = new System.Drawing.Point(4, 25);
            this.tbControlModificar.Name = "tbControlModificar";
            this.tbControlModificar.Padding = new System.Windows.Forms.Padding(3);
            this.tbControlModificar.Size = new System.Drawing.Size(1038, 734);
            this.tbControlModificar.TabIndex = 1;
            this.tbControlModificar.Text = "Modificar";
            this.tbControlModificar.UseVisualStyleBackColor = true;
            // 
            // btnModEliminar
            // 
            this.btnModEliminar.Location = new System.Drawing.Point(886, 660);
            this.btnModEliminar.Name = "btnModEliminar";
            this.btnModEliminar.Size = new System.Drawing.Size(110, 50);
            this.btnModEliminar.TabIndex = 24;
            this.btnModEliminar.Text = "Eliminar";
            this.btnModEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(316, 660);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(110, 50);
            this.btnModificar.TabIndex = 22;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnModCancelar
            // 
            this.btnModCancelar.Location = new System.Drawing.Point(561, 660);
            this.btnModCancelar.Name = "btnModCancelar";
            this.btnModCancelar.Size = new System.Drawing.Size(110, 50);
            this.btnModCancelar.TabIndex = 23;
            this.btnModCancelar.Text = "Cancelar";
            this.btnModCancelar.UseVisualStyleBackColor = true;
            this.btnModCancelar.Click += new System.EventHandler(this.btnModCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(9, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1018, 450);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Imágenes a visualizar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 50);
            this.button1.TabIndex = 20;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(615, 473);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 50);
            this.button2.TabIndex = 21;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // gBoxModCampaña
            // 
            this.gBoxModCampaña.Controls.Add(this.CargarImagMod);
            this.gBoxModCampaña.Controls.Add(this.numericUpDown1);
            this.gBoxModCampaña.Controls.Add(this.label2);
            this.gBoxModCampaña.Controls.Add(this.numericUpDown2);
            this.gBoxModCampaña.Controls.Add(this.numericUpDown3);
            this.gBoxModCampaña.Controls.Add(this.label3);
            this.gBoxModCampaña.Controls.Add(this.label4);
            this.gBoxModCampaña.Controls.Add(this.label5);
            this.gBoxModCampaña.Controls.Add(this.textBox1);
            this.gBoxModCampaña.Controls.Add(this.dateTimePicker1);
            this.gBoxModCampaña.Controls.Add(this.dateTimePicker2);
            this.gBoxModCampaña.Controls.Add(this.label6);
            this.gBoxModCampaña.Controls.Add(this.label7);
            this.gBoxModCampaña.Controls.Add(this.label8);
            this.gBoxModCampaña.Controls.Add(this.label9);
            this.gBoxModCampaña.Controls.Add(this.cBoxModCampActivas);
            this.gBoxModCampaña.Controls.Add(this.lblModCampañasAct);
            this.gBoxModCampaña.Location = new System.Drawing.Point(9, 6);
            this.gBoxModCampaña.Name = "gBoxModCampaña";
            this.gBoxModCampaña.Size = new System.Drawing.Size(1013, 175);
            this.gBoxModCampaña.TabIndex = 1;
            this.gBoxModCampaña.TabStop = false;
            this.gBoxModCampaña.Text = "Campañas";
            // 
            // CargarImagMod
            // 
            this.CargarImagMod.Image = global::Pruebas.Properties.Resources._Imagen;
            this.CargarImagMod.Location = new System.Drawing.Point(938, 21);
            this.CargarImagMod.Name = "CargarImagMod";
            this.CargarImagMod.Size = new System.Drawing.Size(60, 60);
            this.CargarImagMod.TabIndex = 22;
            this.CargarImagMod.UseVisualStyleBackColor = true;
            this.CargarImagMod.Click += new System.EventHandler(this.CargarImagMod_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.Location = new System.Drawing.Point(276, 108);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(56, 22);
            this.numericUpDown1.TabIndex = 32;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Duracion entre imagenes";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(847, 108);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(67, 22);
            this.numericUpDown2.TabIndex = 30;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown3.Location = new System.Drawing.Point(847, 71);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(64, 22);
            this.numericUpDown3.TabIndex = 29;
            this.numericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(765, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Hasta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(765, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Desde";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(765, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Rango de Horas";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 22);
            this.textBox1.TabIndex = 25;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(615, 108);
            this.dateTimePicker1.MinDate = new System.DateTime(2020, 6, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(113, 22);
            this.dateTimePicker1.TabIndex = 24;
            this.dateTimePicker1.Value = new System.DateTime(2020, 8, 13, 0, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(615, 71);
            this.dateTimePicker2.MinDate = new System.DateTime(2020, 6, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(113, 22);
            this.dateTimePicker2.TabIndex = 23;
            this.dateTimePicker2.Value = new System.DateTime(2020, 8, 13, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(539, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Hasta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(539, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Desde";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(539, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Rango entre fechas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Nombre ";
            // 
            // cBoxModCampActivas
            // 
            this.cBoxModCampActivas.FormattingEnabled = true;
            this.cBoxModCampActivas.Location = new System.Drawing.Point(199, 29);
            this.cBoxModCampActivas.Name = "cBoxModCampActivas";
            this.cBoxModCampActivas.Size = new System.Drawing.Size(292, 24);
            this.cBoxModCampActivas.TabIndex = 1;
            // 
            // lblModCampañasAct
            // 
            this.lblModCampañasAct.AutoSize = true;
            this.lblModCampañasAct.Location = new System.Drawing.Point(6, 32);
            this.lblModCampañasAct.Name = "lblModCampañasAct";
            this.lblModCampañasAct.Size = new System.Drawing.Size(169, 17);
            this.lblModCampañasAct.TabIndex = 0;
            this.lblModCampañasAct.Text = "Campañas activas del día";
            // 
            // GestionCampaña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 773);
            this.Controls.Add(this.tabControl1);
            this.Name = "GestionCampaña";
            this.Text = "GestiónCampaña";
            this.tabControl1.ResumeLayout(false);
            this.tbCtrlAgregar.ResumeLayout(false);
            this.gBoxInfoCampaña.ResumeLayout(false);
            this.gBoxInfoCampaña.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDuracionAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpHastaHoraAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDesdeHoraAgregar)).EndInit();
            this.gBoxImagenes.ResumeLayout(false);
            this.tbControlModificar.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gBoxModCampaña.ResumeLayout(false);
            this.gBoxModCampaña.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
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
        private System.Windows.Forms.Button btnAceptarCampaña;
        private System.Windows.Forms.GroupBox gBoxImagenes;
        private System.Windows.Forms.Button BtnCancelarCampaña;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox gBoxModCampaña;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cBoxModCampActivas;
        private System.Windows.Forms.Label lblModCampañasAct;
        private System.Windows.Forms.Button btnModEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnModCancelar;
        private System.Windows.Forms.Button CargarImagMod;
    }
}