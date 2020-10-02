namespace sistemaTarjetas
{
    partial class FDevolverInventario
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
            this.dgvVendedor = new System.Windows.Forms.DataGridView();
            this._codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._existencias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsInventarioVendedor = new System.Windows.Forms.BindingSource(this.components);
            this.dsSistemaTarjetas = new sistemaTarjetas.dsSistemaTarjetas();
            this.dgvDevolucion = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existencias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queriesTableAdapter1 = new sistemaTarjetas.dsSistemaTarjetasTableAdapters.QueriesTableAdapter();
            this.v_inventario_vendedorTableAdapter = new sistemaTarjetas.dsSistemaTarjetasTableAdapters.v_inventario_vendedorTableAdapter();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.bsVendedor = new System.Windows.Forms.BindingSource(this.components);
            this.dsSistemaTarjetas1 = new sistemaTarjetas.dsSistemaTarjetas();
            this.vVendedoresTableAdapter = new sistemaTarjetas.dsSistemaTarjetasTableAdapters.vVendedoresTableAdapter();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsInventarioVendedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistemaTarjetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolucion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVendedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistemaTarjetas1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVendedor
            // 
            this.dgvVendedor.AllowUserToAddRows = false;
            this.dgvVendedor.AllowUserToDeleteRows = false;
            this.dgvVendedor.AutoGenerateColumns = false;
            this.dgvVendedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._codigo,
            this._descripcion,
            this._existencias,
            this.id_vendedor});
            this.dgvVendedor.DataSource = this.bsInventarioVendedor;
            this.dgvVendedor.Location = new System.Drawing.Point(12, 31);
            this.dgvVendedor.MultiSelect = false;
            this.dgvVendedor.Name = "dgvVendedor";
            this.dgvVendedor.ReadOnly = true;
            this.dgvVendedor.RowHeadersVisible = false;
            this.dgvVendedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVendedor.Size = new System.Drawing.Size(374, 267);
            this.dgvVendedor.TabIndex = 2;
            this.dgvVendedor.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVendedor_CellValueChanged);
            // 
            // _codigo
            // 
            this._codigo.DataPropertyName = "Codigo";
            this._codigo.HeaderText = "Codigo";
            this._codigo.Name = "_codigo";
            this._codigo.ReadOnly = true;
            this._codigo.Width = 50;
            // 
            // _descripcion
            // 
            this._descripcion.DataPropertyName = "Descripcion";
            this._descripcion.HeaderText = "Descripcion";
            this._descripcion.Name = "_descripcion";
            this._descripcion.ReadOnly = true;
            this._descripcion.Width = 150;
            // 
            // _existencias
            // 
            this._existencias.DataPropertyName = "Existencias";
            this._existencias.HeaderText = "Existencias";
            this._existencias.Name = "_existencias";
            this._existencias.ReadOnly = true;
            // 
            // id_vendedor
            // 
            this.id_vendedor.DataPropertyName = "id_vendedor";
            this.id_vendedor.HeaderText = "id_vendedor";
            this.id_vendedor.Name = "id_vendedor";
            this.id_vendedor.ReadOnly = true;
            this.id_vendedor.Visible = false;
            // 
            // bsInventarioVendedor
            // 
            this.bsInventarioVendedor.DataMember = "v_inventario_vendedor";
            this.bsInventarioVendedor.DataSource = this.dsSistemaTarjetas;
            // 
            // dsSistemaTarjetas
            // 
            this.dsSistemaTarjetas.DataSetName = "dsSistemaTarjetas";
            this.dsSistemaTarjetas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvDevolucion
            // 
            this.dgvDevolucion.AllowUserToAddRows = false;
            this.dgvDevolucion.AllowUserToDeleteRows = false;
            this.dgvDevolucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevolucion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.descripcion,
            this.existencias});
            this.dgvDevolucion.Location = new System.Drawing.Point(502, 31);
            this.dgvDevolucion.MultiSelect = false;
            this.dgvDevolucion.Name = "dgvDevolucion";
            this.dgvDevolucion.ReadOnly = true;
            this.dgvDevolucion.RowHeadersVisible = false;
            this.dgvDevolucion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDevolucion.Size = new System.Drawing.Size(374, 267);
            this.dgvDevolucion.TabIndex = 3;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Codigo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 50;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 150;
            // 
            // existencias
            // 
            this.existencias.HeaderText = "Existencias";
            this.existencias.Name = "existencias";
            this.existencias.ReadOnly = true;
            // 
            // v_inventario_vendedorTableAdapter
            // 
            this.v_inventario_vendedorTableAdapter.ClearBeforeFill = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(408, 89);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = ">>";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(408, 130);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 23);
            this.btnQuitar.TabIndex = 5;
            this.btnQuitar.Text = "<<";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(421, 63);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(62, 20);
            this.nudCantidad.TabIndex = 6;
            // 
            // btnGuardar
            // 
            this.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGuardar.Location = new System.Drawing.Point(408, 184);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // bsVendedor
            // 
            this.bsVendedor.DataMember = "vVendedores";
            this.bsVendedor.DataSource = this.dsSistemaTarjetas1;
            // 
            // dsSistemaTarjetas1
            // 
            this.dsSistemaTarjetas1.DataSetName = "dsSistemaTarjetas";
            this.dsSistemaTarjetas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vVendedoresTableAdapter
            // 
            this.vVendedoresTableAdapter.ClearBeforeFill = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(408, 223);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Inventario del Vendedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(418, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(640, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "A Devolver";
            // 
            // FDevolverInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 317);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvDevolucion);
            this.Controls.Add(this.dgvVendedor);
            this.Name = "FDevolverInventario";
            this.Text = "Devolver Inventario";
            this.Load += new System.EventHandler(this.FDevolverInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsInventarioVendedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistemaTarjetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolucion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVendedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistemaTarjetas1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvVendedor;
        private System.Windows.Forms.DataGridView dgvDevolucion;
        private dsSistemaTarjetasTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.BindingSource bsInventarioVendedor;
        private dsSistemaTarjetas dsSistemaTarjetas;
        private dsSistemaTarjetasTableAdapters.v_inventario_vendedorTableAdapter v_inventario_vendedorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn existencias;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.BindingSource bsVendedor;
        private dsSistemaTarjetas dsSistemaTarjetas1;
        private dsSistemaTarjetasTableAdapters.vVendedoresTableAdapter vVendedoresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn _codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn _descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn _existencias;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_vendedor;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}