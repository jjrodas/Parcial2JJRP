namespace CpParcial
{
    partial class FrmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.txtSinopsis = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.dtpFechaEstreno = new System.Windows.Forms.DateTimePicker();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.lblFechaEstreno = new System.Windows.Forms.Label();
            this.nudDuracion = new System.Windows.Forms.NumericUpDown();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblSinopsis = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.gbxLista = new System.Windows.Forms.GroupBox();
            this.dgvListaSeries = new System.Windows.Forms.DataGridView();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.txtParametro = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.erpTitulo = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpSinopsis = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpDirector = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpDuracion = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpFechaEstreno = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuracion)).BeginInit();
            this.pnlAcciones.SuspendLayout();
            this.gbxLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaSeries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpSinopsis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDirector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDuracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpFechaEstreno)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrincipal.Location = new System.Drawing.Point(12, 9);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(909, 30);
            this.lblPrincipal.TabIndex = 0;
            this.lblPrincipal.Text = "Series";
            this.lblPrincipal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.txtSinopsis);
            this.gbxDatos.Controls.Add(this.txtTitulo);
            this.gbxDatos.Controls.Add(this.dtpFechaEstreno);
            this.gbxDatos.Controls.Add(this.txtDirector);
            this.gbxDatos.Controls.Add(this.lblFechaEstreno);
            this.gbxDatos.Controls.Add(this.nudDuracion);
            this.gbxDatos.Controls.Add(this.lblDuracion);
            this.gbxDatos.Controls.Add(this.lblDirector);
            this.gbxDatos.Controls.Add(this.lblSinopsis);
            this.gbxDatos.Controls.Add(this.lblTitulo);
            this.gbxDatos.Controls.Add(this.btnCancelar);
            this.gbxDatos.Controls.Add(this.btnGuardar);
            this.gbxDatos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDatos.Location = new System.Drawing.Point(69, 379);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(790, 141);
            this.gbxDatos.TabIndex = 13;
            this.gbxDatos.TabStop = false;
            this.gbxDatos.Text = "Datos de la Serie";
            // 
            // txtSinopsis
            // 
            this.txtSinopsis.Location = new System.Drawing.Point(140, 53);
            this.txtSinopsis.MaxLength = 250;
            this.txtSinopsis.Name = "txtSinopsis";
            this.txtSinopsis.Size = new System.Drawing.Size(184, 26);
            this.txtSinopsis.TabIndex = 25;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(140, 15);
            this.txtTitulo.MaxLength = 250;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(184, 26);
            this.txtTitulo.TabIndex = 24;
            // 
            // dtpFechaEstreno
            // 
            this.dtpFechaEstreno.Location = new System.Drawing.Point(535, 54);
            this.dtpFechaEstreno.Name = "dtpFechaEstreno";
            this.dtpFechaEstreno.Size = new System.Drawing.Size(200, 26);
            this.dtpFechaEstreno.TabIndex = 23;
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(140, 89);
            this.txtDirector.MaxLength = 250;
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(184, 26);
            this.txtDirector.TabIndex = 22;
            // 
            // lblFechaEstreno
            // 
            this.lblFechaEstreno.AutoSize = true;
            this.lblFechaEstreno.Location = new System.Drawing.Point(350, 56);
            this.lblFechaEstreno.Name = "lblFechaEstreno";
            this.lblFechaEstreno.Size = new System.Drawing.Size(118, 19);
            this.lblFechaEstreno.TabIndex = 20;
            this.lblFechaEstreno.Text = "Fecha de Estreno:";
            // 
            // nudDuracion
            // 
            this.nudDuracion.Location = new System.Drawing.Point(535, 22);
            this.nudDuracion.Name = "nudDuracion";
            this.nudDuracion.Size = new System.Drawing.Size(107, 26);
            this.nudDuracion.TabIndex = 19;
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Location = new System.Drawing.Point(350, 22);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(179, 19);
            this.lblDuracion.TabIndex = 18;
            this.lblDuracion.Text = "Duración (N° de episodios):";
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Location = new System.Drawing.Point(11, 89);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(62, 19);
            this.lblDirector.TabIndex = 16;
            this.lblDirector.Text = "Director:";
            // 
            // lblSinopsis
            // 
            this.lblSinopsis.AutoSize = true;
            this.lblSinopsis.Location = new System.Drawing.Point(11, 54);
            this.lblSinopsis.Name = "lblSinopsis";
            this.lblSinopsis.Size = new System.Drawing.Size(62, 19);
            this.lblSinopsis.TabIndex = 14;
            this.lblSinopsis.Text = "Sinopsis:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(11, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(46, 19);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Título:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::CpParcial.Properties.Resources.icons8_cerrar_ventana_32;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(682, 89);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 42);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::CpParcial.Properties.Resources.icons8_guardar_32;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(581, 89);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(95, 42);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.Controls.Add(this.btnCerrar);
            this.pnlAcciones.Controls.Add(this.btnEliminar);
            this.pnlAcciones.Controls.Add(this.btnEditar);
            this.pnlAcciones.Controls.Add(this.btnNuevo);
            this.pnlAcciones.Location = new System.Drawing.Point(70, 312);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Size = new System.Drawing.Size(789, 48);
            this.pnlAcciones.TabIndex = 12;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Image = global::CpParcial.Properties.Resources.icons8_cerrar_ventana_32;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(501, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(87, 42);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = global::CpParcial.Properties.Resources.icons8_eliminar_32;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(402, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(93, 42);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = global::CpParcial.Properties.Resources.icons8_editar_32;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(309, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(87, 42);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = global::CpParcial.Properties.Resources.icons8_por_nueva_copia_32;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(212, 3);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(91, 42);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // gbxLista
            // 
            this.gbxLista.Controls.Add(this.dgvListaSeries);
            this.gbxLista.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxLista.Location = new System.Drawing.Point(71, 82);
            this.gbxLista.Name = "gbxLista";
            this.gbxLista.Size = new System.Drawing.Size(790, 224);
            this.gbxLista.TabIndex = 11;
            this.gbxLista.TabStop = false;
            this.gbxLista.Text = "Lista de Series";
            // 
            // dgvListaSeries
            // 
            this.dgvListaSeries.AllowUserToAddRows = false;
            this.dgvListaSeries.AllowUserToDeleteRows = false;
            this.dgvListaSeries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListaSeries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaSeries.Location = new System.Drawing.Point(7, 22);
            this.dgvListaSeries.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListaSeries.MultiSelect = false;
            this.dgvListaSeries.Name = "dgvListaSeries";
            this.dgvListaSeries.ReadOnly = true;
            this.dgvListaSeries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaSeries.Size = new System.Drawing.Size(776, 195);
            this.dgvListaSeries.TabIndex = 0;
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.Location = new System.Drawing.Point(71, 35);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(177, 19);
            this.lblBusqueda.TabIndex = 9;
            this.lblBusqueda.Text = "Buscar por título de la Serie";
            // 
            // txtParametro
            // 
            this.txtParametro.Location = new System.Drawing.Point(71, 54);
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(688, 22);
            this.txtParametro.TabIndex = 8;
            this.txtParametro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParametro_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::CpParcial.Properties.Resources.icons8_buscar_32;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(770, 42);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(91, 42);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // erpTitulo
            // 
            this.erpTitulo.ContainerControl = this;
            // 
            // erpSinopsis
            // 
            this.erpSinopsis.ContainerControl = this;
            // 
            // erpDirector
            // 
            this.erpDirector.ContainerControl = this;
            // 
            // erpDuracion
            // 
            this.erpDuracion.ContainerControl = this;
            // 
            // erpFechaEstreno
            // 
            this.erpFechaEstreno.ContainerControl = this;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.gbxDatos);
            this.Controls.Add(this.pnlAcciones);
            this.Controls.Add(this.gbxLista);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.txtParametro);
            this.Controls.Add(this.lblPrincipal);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "::: Parcial2 - Juan José Rodas Paco :::";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuracion)).EndInit();
            this.pnlAcciones.ResumeLayout(false);
            this.gbxLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaSeries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpSinopsis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDirector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDuracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpFechaEstreno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.DateTimePicker dtpFechaEstreno;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.Label lblFechaEstreno;
        private System.Windows.Forms.NumericUpDown nudDuracion;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label lblSinopsis;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox gbxLista;
        private System.Windows.Forms.DataGridView dgvListaSeries;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.TextBox txtParametro;
        private System.Windows.Forms.TextBox txtSinopsis;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.ErrorProvider erpTitulo;
        private System.Windows.Forms.ErrorProvider erpSinopsis;
        private System.Windows.Forms.ErrorProvider erpDirector;
        private System.Windows.Forms.ErrorProvider erpDuracion;
        private System.Windows.Forms.ErrorProvider erpFechaEstreno;
    }
}

