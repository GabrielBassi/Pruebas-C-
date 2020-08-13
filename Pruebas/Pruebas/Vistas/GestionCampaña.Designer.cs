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
            this.tbControlModificar = new System.Windows.Forms.TabPage();
            this.gBoxInfoCampaña = new System.Windows.Forms.GroupBox();
            this.lblNomAgregarCamp = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tbCtrlAgregar.SuspendLayout();
            this.gBoxInfoCampaña.SuspendLayout();
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
            this.tbCtrlAgregar.Controls.Add(this.gBoxInfoCampaña);
            this.tbCtrlAgregar.Location = new System.Drawing.Point(4, 25);
            this.tbCtrlAgregar.Name = "tbCtrlAgregar";
            this.tbCtrlAgregar.Padding = new System.Windows.Forms.Padding(3);
            this.tbCtrlAgregar.Size = new System.Drawing.Size(1323, 506);
            this.tbCtrlAgregar.TabIndex = 0;
            this.tbCtrlAgregar.Text = "Agregar";
            this.tbCtrlAgregar.UseVisualStyleBackColor = true;
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
            // gBoxInfoCampaña
            // 
            this.gBoxInfoCampaña.Controls.Add(this.lblNomAgregarCamp);
            this.gBoxInfoCampaña.Location = new System.Drawing.Point(4, 7);
            this.gBoxInfoCampaña.Name = "gBoxInfoCampaña";
            this.gBoxInfoCampaña.Size = new System.Drawing.Size(1316, 212);
            this.gBoxInfoCampaña.TabIndex = 0;
            this.gBoxInfoCampaña.TabStop = false;
            this.gBoxInfoCampaña.Text = "Información de campaña";
            // 
            // lblNomAgregarCamp
            // 
            this.lblNomAgregarCamp.AutoSize = true;
            this.lblNomAgregarCamp.Location = new System.Drawing.Point(24, 41);
            this.lblNomAgregarCamp.Name = "lblNomAgregarCamp";
            this.lblNomAgregarCamp.Size = new System.Drawing.Size(62, 17);
            this.lblNomAgregarCamp.TabIndex = 0;
            this.lblNomAgregarCamp.Text = "Nombre ";
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
            this.gBoxInfoCampaña.ResumeLayout(false);
            this.gBoxInfoCampaña.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbCtrlAgregar;
        private System.Windows.Forms.TabPage tbControlModificar;
        private System.Windows.Forms.GroupBox gBoxInfoCampaña;
        private System.Windows.Forms.Label lblNomAgregarCamp;
    }
}