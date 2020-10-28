namespace sistemaTarjetas
{
    partial class FDevolucionTarjeta
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
            this.dgvActuales = new System.Windows.Forms.DataGridView();
            this.bsActual = new System.Windows.Forms.BindingSource(this.components);
            this.dsSistemaTarjetas = new sistemaTarjetas.dsSistemaTarjetas();
            this.dgvDevolver = new System.Windows.Forms.DataGridView();
            this.numeroDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsDevolucion = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.articulos_devolverTableAdapter = new sistemaTarjetas.dsSistemaTarjetasTableAdapters.articulos_devolverTableAdapter();
            this.querys = new sistemaTarjetas.dsSistemaTarjetasTableAdapters.Querys();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActuales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistemaTarjetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDevolucion)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvActuales
            // 
            this.dgvActuales.AllowUserToAddRows = false;
            this.dgvActuales.AllowUserToDeleteRows = false;
            this.dgvActuales.AllowUserToResizeColumns = false;
            this.dgvActuales.AllowUserToResizeRows = false;
            this.dgvActuales.AutoGenerateColumns = false;
            this.dgvActuales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActuales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.Precio});
            this.dgvActuales.DataSource = this.bsActual;
            this.dgvActuales.Location = new System.Drawing.Point(12, 34);
            this.dgvActuales.MultiSelect = false;
            this.dgvActuales.Name = "dgvActuales";
            this.dgvActuales.ReadOnly = true;
            this.dgvActuales.RowHeadersVisible = false;
            this.dgvActuales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActuales.Size = new System.Drawing.Size(313, 232);
            this.dgvActuales.TabIndex = 0;
            // 
            // bsActual
            // 
            this.bsActual.DataMember = "articulos_devolver";
            this.bsActual.DataSource = this.dsSistemaTarjetas;
            // 
            // dsSistemaTarjetas
            // 
            this.dsSistemaTarjetas.DataSetName = "dsSistemaTarjetas";
            this.dsSistemaTarjetas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvDevolver
            // 
            this.dgvDevolver.AllowUserToAddRows = false;
            this.dgvDevolver.AllowUserToDeleteRows = false;
            this.dgvDevolver.AllowUserToResizeColumns = false;
            this.dgvDevolver.AllowUserToResizeRows = false;
            this.dgvDevolver.AutoGenerateColumns = false;
            this.dgvDevolver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevolver.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroDataGridViewTextBoxColumn1,
            this.codigoDataGridViewTextBoxColumn1,
            this.descripcionDataGridViewTextBoxColumn1,
            this.cantidadDataGridViewTextBoxColumn1,
            this.Valor});
            this.dgvDevolver.DataSource = this.bsDevolucion;
            this.dgvDevolver.Location = new System.Drawing.Point(419, 32);
            this.dgvDevolver.MultiSelect = false;
            this.dgvDevolver.Name = "dgvDevolver";
            this.dgvDevolver.ReadOnly = true;
            this.dgvDevolver.RowHeadersVisible = false;
            this.dgvDevolver.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDevolver.Size = new System.Drawing.Size(314, 232);
            this.dgvDevolver.TabIndex = 1;
            // 
            // numeroDataGridViewTextBoxColumn1
            // 
            this.numeroDataGridViewTextBoxColumn1.DataPropertyName = "Numero";
            this.numeroDataGridViewTextBoxColumn1.HeaderText = "Numero";
            this.numeroDataGridViewTextBoxColumn1.Name = "numeroDataGridViewTextBoxColumn1";
            this.numeroDataGridViewTextBoxColumn1.ReadOnly = true;
            this.numeroDataGridViewTextBoxColumn1.Width = 50;
            // 
            // codigoDataGridViewTextBoxColumn1
            // 
            this.codigoDataGridViewTextBoxColumn1.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn1.Name = "codigoDataGridViewTextBoxColumn1";
            this.codigoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.codigoDataGridViewTextBoxColumn1.Width = 50;
            // 
            // descripcionDataGridViewTextBoxColumn1
            // 
            this.descripcionDataGridViewTextBoxColumn1.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn1.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn1.Name = "descripcionDataGridViewTextBoxColumn1";
            this.descripcionDataGridViewTextBoxColumn1.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn1.Width = 150;
            // 
            // cantidadDataGridViewTextBoxColumn1
            // 
            this.cantidadDataGridViewTextBoxColumn1.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn1.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn1.Name = "cantidadDataGridViewTextBoxColumn1";
            this.cantidadDataGridViewTextBoxColumn1.ReadOnly = true;
            this.cantidadDataGridViewTextBoxColumn1.Width = 60;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // bsDevolucion
            // 
            this.bsDevolucion.DataMember = "devolver";
            this.bsDevolucion.DataSource = this.dsSistemaTarjetas;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Articulos Actuales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(523, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Articulos a devolver";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(341, 68);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(60, 20);
            this.txtCantidad.TabIndex = 4;
            this.txtCantidad.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cantidad";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(334, 94);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = ">>";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(334, 136);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 23);
            this.btnQuitar.TabIndex = 7;
            this.btnQuitar.Text = "<<";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(12, 272);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(112, 272);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // articulos_devolverTableAdapter
            // 
            this.articulos_devolverTableAdapter.ClearBeforeFill = true;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Numero";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            this.numeroDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroDataGridViewTextBoxColumn.Width = 50;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoDataGridViewTextBoxColumn.Width = 50;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn.Width = 150;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadDataGridViewTextBoxColumn.Width = 60;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // FDevolucionTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 299);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDevolver);
            this.Controls.Add(this.dgvActuales);
            this.Name = "FDevolucionTarjeta";
            this.Text = "Devolucion de articulos vendidos";
            this.Load += new System.EventHandler(this.FDevolucionTarjeta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActuales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistemaTarjetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDevolucion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvActuales;
        private System.Windows.Forms.DataGridView dgvDevolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bsActual;
        private dsSistemaTarjetas dsSistemaTarjetas;
        private System.Windows.Forms.BindingSource bsDevolucion;
        private dsSistemaTarjetasTableAdapters.articulos_devolverTableAdapter articulos_devolverTableAdapter;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private dsSistemaTarjetasTableAdapters.Querys querys;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}