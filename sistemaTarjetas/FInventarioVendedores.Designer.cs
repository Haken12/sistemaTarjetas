namespace sistemaTarjetas
{
    partial class FInventarioVendedores
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxNombre = new System.Windows.Forms.ComboBox();
            this.bsVendedor = new System.Windows.Forms.BindingSource(this.components);
            this.dsSistemaTarjetas = new sistemaTarjetas.dsSistemaTarjetas();
            this.Nombre = new System.Windows.Forms.Label();
            this.dgvInventarioVendedor = new System.Windows.Forms.DataGridView();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existenciasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsInventarioVendedor = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDevolucion = new System.Windows.Forms.Button();
            this.btnIrDespacho = new System.Windows.Forms.Button();
            this.v_inventario_vendedorTableAdapter = new sistemaTarjetas.dsSistemaTarjetasTableAdapters.v_inventario_vendedorTableAdapter();
            this.vVendedoresTableAdapter = new sistemaTarjetas.dsSistemaTarjetasTableAdapters.vVendedoresTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsVendedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistemaTarjetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventarioVendedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsInventarioVendedor)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxNombre);
            this.groupBox1.Controls.Add(this.Nombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 107);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info Vendedor";
            // 
            // cbxNombre
            // 
            this.cbxNombre.DataSource = this.bsVendedor;
            this.cbxNombre.DisplayMember = "Nombre";
            this.cbxNombre.FormattingEnabled = true;
            this.cbxNombre.Location = new System.Drawing.Point(6, 54);
            this.cbxNombre.Name = "cbxNombre";
            this.cbxNombre.Size = new System.Drawing.Size(209, 21);
            this.cbxNombre.TabIndex = 1;
            this.cbxNombre.ValueMember = "Id";
            this.cbxNombre.SelectedIndexChanged += new System.EventHandler(this.cbxNombre_SelectedIndexChanged);
            // 
            // bsVendedor
            // 
            this.bsVendedor.DataMember = "vVendedores";
            this.bsVendedor.DataSource = this.dsSistemaTarjetas;
            // 
            // dsSistemaTarjetas
            // 
            this.dsSistemaTarjetas.DataSetName = "dsSistemaTarjetas";
            this.dsSistemaTarjetas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(6, 26);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "Nombre";
            // 
            // dgvInventarioVendedor
            // 
            this.dgvInventarioVendedor.AllowUserToAddRows = false;
            this.dgvInventarioVendedor.AllowUserToDeleteRows = false;
            this.dgvInventarioVendedor.AutoGenerateColumns = false;
            this.dgvInventarioVendedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventarioVendedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.existenciasDataGridViewTextBoxColumn});
            this.dgvInventarioVendedor.DataSource = this.bsInventarioVendedor;
            this.dgvInventarioVendedor.Location = new System.Drawing.Point(12, 154);
            this.dgvInventarioVendedor.Name = "dgvInventarioVendedor";
            this.dgvInventarioVendedor.ReadOnly = true;
            this.dgvInventarioVendedor.Size = new System.Drawing.Size(547, 257);
            this.dgvInventarioVendedor.TabIndex = 1;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn.Width = 200;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // existenciasDataGridViewTextBoxColumn
            // 
            this.existenciasDataGridViewTextBoxColumn.DataPropertyName = "Existencias";
            this.existenciasDataGridViewTextBoxColumn.HeaderText = "Existencias";
            this.existenciasDataGridViewTextBoxColumn.Name = "existenciasDataGridViewTextBoxColumn";
            this.existenciasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsInventarioVendedor
            // 
            this.bsInventarioVendedor.DataMember = "v_inventario_vendedor";
            this.bsInventarioVendedor.DataSource = this.dsSistemaTarjetas;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDevolucion);
            this.groupBox2.Controls.Add(this.btnIrDespacho);
            this.groupBox2.Location = new System.Drawing.Point(366, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 107);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // btnDevolucion
            // 
            this.btnDevolucion.Enabled = false;
            this.btnDevolucion.Location = new System.Drawing.Point(18, 65);
            this.btnDevolucion.Name = "btnDevolucion";
            this.btnDevolucion.Size = new System.Drawing.Size(115, 23);
            this.btnDevolucion.TabIndex = 1;
            this.btnDevolucion.Text = "Ir a Devoluciones";
            this.btnDevolucion.UseVisualStyleBackColor = true;
            this.btnDevolucion.Click += new System.EventHandler(this.btnDevolucion_Click);
            // 
            // btnIrDespacho
            // 
            this.btnIrDespacho.Enabled = false;
            this.btnIrDespacho.Location = new System.Drawing.Point(18, 26);
            this.btnIrDespacho.Name = "btnIrDespacho";
            this.btnIrDespacho.Size = new System.Drawing.Size(115, 23);
            this.btnIrDespacho.TabIndex = 0;
            this.btnIrDespacho.Text = "Ir a Despachar";
            this.btnIrDespacho.UseVisualStyleBackColor = true;
            this.btnIrDespacho.Click += new System.EventHandler(this.irDespacho_Click);
            // 
            // v_inventario_vendedorTableAdapter
            // 
            this.v_inventario_vendedorTableAdapter.ClearBeforeFill = true;
            // 
            // vVendedoresTableAdapter
            // 
            this.vVendedoresTableAdapter.ClearBeforeFill = true;
            // 
            // FInventarioVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvInventarioVendedor);
            this.Controls.Add(this.groupBox1);
            this.Name = "FInventarioVendedores";
            this.Text = "FInventarioVendedores";
            this.Load += new System.EventHandler(this.FInventarioVendedores_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsVendedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistemaTarjetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventarioVendedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsInventarioVendedor)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvInventarioVendedor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource bsInventarioVendedor;
        private dsSistemaTarjetas dsSistemaTarjetas;
        private dsSistemaTarjetasTableAdapters.v_inventario_vendedorTableAdapter v_inventario_vendedorTableAdapter;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn existenciasDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsVendedor;
        private dsSistemaTarjetasTableAdapters.vVendedoresTableAdapter vVendedoresTableAdapter;
        private System.Windows.Forms.ComboBox cbxNombre;
        private System.Windows.Forms.Button btnIrDespacho;
        private System.Windows.Forms.Button btnDevolucion;
    }
}