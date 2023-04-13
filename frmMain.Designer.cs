namespace pry.AUTOCARsp1SEMESTRE2
{
    partial class frmAutocar
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mrcRepuestos = new System.Windows.Forms.GroupBox();
            this.optNacional = new System.Windows.Forms.RadioButton();
            this.optImportado = new System.Windows.Forms.RadioButton();
            this.cmdMarca = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblorigen = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lstRepuestos = new System.Windows.Forms.ListView();
            this.mrcRepuestos.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcRepuestos
            // 
            this.mrcRepuestos.Controls.Add(this.optNacional);
            this.mrcRepuestos.Controls.Add(this.optImportado);
            this.mrcRepuestos.Controls.Add(this.cmdMarca);
            this.mrcRepuestos.Controls.Add(this.txtNombre);
            this.mrcRepuestos.Controls.Add(this.txtPrecio);
            this.mrcRepuestos.Controls.Add(this.txtCodigo);
            this.mrcRepuestos.Controls.Add(this.lblorigen);
            this.mrcRepuestos.Controls.Add(this.lblPrecio);
            this.mrcRepuestos.Controls.Add(this.lblNombre);
            this.mrcRepuestos.Controls.Add(this.lblMarca);
            this.mrcRepuestos.Controls.Add(this.lblCodigo);
            this.mrcRepuestos.Location = new System.Drawing.Point(207, 12);
            this.mrcRepuestos.Name = "mrcRepuestos";
            this.mrcRepuestos.Size = new System.Drawing.Size(384, 426);
            this.mrcRepuestos.TabIndex = 0;
            this.mrcRepuestos.TabStop = false;
            this.mrcRepuestos.Text = "Repuestos";
         //   this.mrcRepuestos.Enter += new System.EventHandler(this.mrcRepuestos_Enter);
            // 
            // optNacional
            // 
            this.optNacional.AutoSize = true;
            this.optNacional.Location = new System.Drawing.Point(140, 310);
            this.optNacional.Name = "optNacional";
            this.optNacional.Size = new System.Drawing.Size(67, 17);
            this.optNacional.TabIndex = 10;
            this.optNacional.TabStop = true;
            this.optNacional.Text = "Nacional";
            this.optNacional.UseVisualStyleBackColor = true;
            // 
            // optImportado
            // 
            this.optImportado.AutoSize = true;
            this.optImportado.Location = new System.Drawing.Point(250, 310);
            this.optImportado.Name = "optImportado";
            this.optImportado.Size = new System.Drawing.Size(72, 17);
            this.optImportado.TabIndex = 9;
            this.optImportado.TabStop = true;
            this.optImportado.Text = "Importado";
            this.optImportado.UseVisualStyleBackColor = true;
            // 
            // cmdMarca
            // 
            this.cmdMarca.FormattingEnabled = true;
            this.cmdMarca.Items.AddRange(new object[] {
            "Ford",
            "Fiat",
            "Citroen"});
            this.cmdMarca.Location = new System.Drawing.Point(140, 178);
            this.cmdMarca.Name = "cmdMarca";
            this.cmdMarca.Size = new System.Drawing.Size(121, 21);
            this.cmdMarca.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(140, 110);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(140, 240);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(121, 20);
            this.txtPrecio.TabIndex = 6;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(140, 39);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(121, 20);
            this.txtCodigo.TabIndex = 5;
            // 
            // lblorigen
            // 
            this.lblorigen.AutoSize = true;
            this.lblorigen.Location = new System.Drawing.Point(63, 310);
            this.lblorigen.Name = "lblorigen";
            this.lblorigen.Size = new System.Drawing.Size(38, 13);
            this.lblorigen.TabIndex = 4;
            this.lblorigen.Text = "Origen";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(63, 243);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 3;
            this.lblPrecio.Text = "Precio";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(63, 113);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(63, 181);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "Marca";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(63, 42);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(662, 119);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(662, 183);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(662, 255);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 13;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(662, 322);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lstRepuestos
            // 
            this.lstRepuestos.HideSelection = false;
            this.lstRepuestos.Location = new System.Drawing.Point(12, 12);
            this.lstRepuestos.Name = "lstRepuestos";
            this.lstRepuestos.Size = new System.Drawing.Size(189, 113);
            this.lstRepuestos.TabIndex = 15;
            this.lstRepuestos.UseCompatibleStateImageBehavior = false;
            // 
            // frmAutocar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstRepuestos);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.mrcRepuestos);
            this.Name = "frmAutocar";
            this.Text = "AUTOCAR - REPUESTOS";
//            this.Load += new System.EventHandler(this.frmAutocar_Load);
            this.mrcRepuestos.ResumeLayout(false);
            this.mrcRepuestos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcRepuestos;
        private System.Windows.Forms.RadioButton optNacional;
        private System.Windows.Forms.RadioButton optImportado;
        private System.Windows.Forms.ComboBox cmdMarca;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblorigen;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ListView lstRepuestos;
    }
}

