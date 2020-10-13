namespace sistemaTarjetas
{
    partial class FListaTarjetas
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
            this.rbCliente = new System.Windows.Forms.RadioButton();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnDetalles = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNueva = new System.Windows.Forms.Button();
            this.dgvTarjetas = new System.Windows.Forms.DataGridView();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formaDePagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsTarjetas = new System.Windows.Forms.BindingSource(this.components);
            this.dsSistemaTarjetas = new sistemaTarjetas.dsSistemaTarjetas();
            this.vTarjetasTableAdapter = new sistemaTarjetas.dsSistemaTarjetasTableAdapters.vTarjetasTableAdapter();
            this.queriesTableAdapter1 = new sistemaTarjetas.dsSistemaTarjetasTableAdapters.QueriesTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarjetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTarjetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistemaTarjetas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCliente);
            this.groupBox1.Controls.Add(this.rbCodigo);
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // rbCliente
            // 
            this.rbCliente.AutoSize = true;
            this.rbCliente.Location = new System.Drawing.Point(6, 59);
            this.rbCliente.Name = "rbCliente";
            this.rbCliente.Size = new System.Drawing.Size(76, 17);
            this.rbCliente.TabIndex = 5;
            this.rbCliente.TabStop = true;
            this.rbCliente.Text = "Por Cliente";
            this.rbCliente.UseVisualStyleBackColor = true;
            this.rbCliente.CheckedChanged += new System.EventHandler(this.rbCliente_CheckedChanged);
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Location = new System.Drawing.Point(6, 25);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(77, 17);
            this.rbCodigo.TabIndex = 4;
            this.rbCodigo.TabStop = true;
            this.rbCodigo.Text = "Por Codigo";
            this.rbCodigo.UseVisualStyleBackColor = true;
            this.rbCodigo.CheckedChanged += new System.EventHandler(this.rbCodigo_CheckedChanged);
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(87, 58);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(158, 20);
            this.txtCliente.TabIndex = 3;
            this.txtCliente.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(88, 22);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 2;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnDetalles);
            this.groupBox2.Controls.Add(this.btnModificar);
            this.groupBox2.Controls.Add(this.btnNueva);
            this.groupBox2.Location = new System.Drawing.Point(442, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(6, 61);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnDetalles
            // 
            this.btnDetalles.Enabled = false;
            this.btnDetalles.Location = new System.Drawing.Point(114, 61);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(75, 23);
            this.btnDetalles.TabIndex = 2;
            this.btnDetalles.Text = "Detalles";
            this.btnDetalles.UseVisualStyleBackColor = true;
            this.btnDetalles.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(114, 19);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNueva
            // 
            this.btnNueva.Location = new System.Drawing.Point(6, 19);
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Size = new System.Drawing.Size(75, 23);
            this.btnNueva.TabIndex = 0;
            this.btnNueva.Text = "Nueva";
            this.btnNueva.UseVisualStyleBackColor = true;
            this.btnNueva.Click += new System.EventHandler(this.btnNueva_Click);
            // 
            // dgvTarjetas
            // 
            this.dgvTarjetas.AllowUserToAddRows = false;
            this.dgvTarjetas.AllowUserToDeleteRows = false;
            this.dgvTarjetas.AutoGenerateColumns = false;
            this.dgvTarjetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarjetas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.clienteDataGridViewTextBoxColumn,
            this.vendedorDataGridViewTextBoxColumn,
            this.zonaDataGridViewTextBoxColumn,
            this.formaDePagoDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn});
            this.dgvTarjetas.DataSource = this.bsTarjetas;
            this.dgvTarjetas.Location = new System.Drawing.Point(12, 141);
            this.dgvTarjetas.MultiSelect = false;
            this.dgvTarjetas.Name = "dgvTarjetas";
            this.dgvTarjetas.ReadOnly = true;
            this.dgvTarjetas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTarjetas.Size = new System.Drawing.Size(714, 292);
            this.dgvTarjetas.TabIndex = 2;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoDataGridViewTextBoxColumn.Width = 50;
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            this.clienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente";
            this.clienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            this.clienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.clienteDataGridViewTextBoxColumn.Width = 150;
            // 
            // vendedorDataGridViewTextBoxColumn
            // 
            this.vendedorDataGridViewTextBoxColumn.DataPropertyName = "Vendedor";
            this.vendedorDataGridViewTextBoxColumn.HeaderText = "Vendedor";
            this.vendedorDataGridViewTextBoxColumn.Name = "vendedorDataGridViewTextBoxColumn";
            this.vendedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.vendedorDataGridViewTextBoxColumn.Width = 150;
            // 
            // zonaDataGridViewTextBoxColumn
            // 
            this.zonaDataGridViewTextBoxColumn.DataPropertyName = "Zona";
            this.zonaDataGridViewTextBoxColumn.HeaderText = "Zona";
            this.zonaDataGridViewTextBoxColumn.Name = "zonaDataGridViewTextBoxColumn";
            this.zonaDataGridViewTextBoxColumn.ReadOnly = true;
            this.zonaDataGridViewTextBoxColumn.Width = 150;
            // 
            // formaDePagoDataGridViewTextBoxColumn
            // 
            this.formaDePagoDataGridViewTextBoxColumn.DataPropertyName = "Forma de Pago";
            this.formaDePagoDataGridViewTextBoxColumn.HeaderText = "Forma de Pago";
            this.formaDePagoDataGridViewTextBoxColumn.Name = "formaDePagoDataGridViewTextBoxColumn";
            this.formaDePagoDataGridViewTextBoxColumn.ReadOnly = true;
            this.formaDePagoDataGridViewTextBoxColumn.Width = 70;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsTarjetas
            // 
            this.bsTarjetas.DataMember = "vTarjetas";
            this.bsTarjetas.DataSource = this.dsSistemaTarjetas;
            // 
            // dsSistemaTarjetas
            // 
            this.dsSistemaTarjetas.DataSetName = "dsSistemaTarjetas";
            this.dsSistemaTarjetas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vTarjetasTableAdapter
            // 
            this.vTarjetasTableAdapter.ClearBeforeFill = true;
            // 
            // FListaTarjetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 470);
            this.Controls.Add(this.dgvTarjetas);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FListaTarjetas";
            this.Text = "Lista de Tarjetas";
            this.Load += new System.EventHandler(this.FListaTarjetas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarjetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTarjetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistemaTarjetas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvTarjetas;
        private System.Windows.Forms.BindingSource bsTarjetas;
        private dsSistemaTarjetas dsSistemaTarjetas;
        private dsSistemaTarjetasTableAdapters.vTarjetasTableAdapter vTarjetasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formaDePagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnDetalles;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNueva;
        private dsSistemaTarjetasTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.RadioButton rbCliente;
        private System.Windows.Forms.RadioButton rbCodigo;
    }
}