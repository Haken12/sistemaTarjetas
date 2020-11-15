namespace sistemaTarjetas
{
    partial class FControlTarjetas
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbxZona = new System.Windows.Forms.ComboBox();
            this.bsZonas = new System.Windows.Forms.BindingSource(this.components);
            this.dsSistemaTarjetas = new sistemaTarjetas.dsSistemaTarjetas();
            this.cbxVendedor = new System.Windows.Forms.ComboBox();
            this.bsVendedores = new System.Windows.Forms.BindingSource(this.components);
            this.cbxFormaPago = new System.Windows.Forms.ComboBox();
            this.btnNueva = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtCedula = new System.Windows.Forms.MaskedTextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.noDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debitoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsDetalles = new System.Windows.Forms.BindingSource(this.components);
            this.pnlOp = new System.Windows.Forms.Panel();
            this.btnAsentar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtCredito = new System.Windows.Forms.TextBox();
            this.txtDebito = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.querys = new sistemaTarjetas.dsSistemaTarjetasTableAdapters.Querys();
            this.v_vendedorTableAdapter = new sistemaTarjetas.dsSistemaTarjetasTableAdapters.v_vendedorTableAdapter();
            this.v_zonaTableAdapter = new sistemaTarjetas.dsSistemaTarjetasTableAdapters.v_zonaTableAdapter();
            this.v_detalles_tarjetaTableAdapter = new sistemaTarjetas.dsSistemaTarjetasTableAdapters.v_detalles_tarjetaTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsZonas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistemaTarjetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVendedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDetalles)).BeginInit();
            this.pnlOp.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.cbxZona);
            this.groupBox1.Controls.Add(this.cbxVendedor);
            this.groupBox1.Controls.Add(this.cbxFormaPago);
            this.groupBox1.Controls.Add(this.btnNueva);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtCedula);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtReferencia);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione o Cree la Tarjeta";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(9, 89);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(53, 23);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(68, 89);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(63, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cbxZona
            // 
            this.cbxZona.DataSource = this.bsZonas;
            this.cbxZona.DisplayMember = "Descripcion";
            this.cbxZona.Enabled = false;
            this.cbxZona.FormattingEnabled = true;
            this.cbxZona.Location = new System.Drawing.Point(601, 62);
            this.cbxZona.Name = "cbxZona";
            this.cbxZona.Size = new System.Drawing.Size(161, 21);
            this.cbxZona.TabIndex = 7;
            this.cbxZona.ValueMember = "Id";
            this.cbxZona.Enter += new System.EventHandler(this.entrar);
            this.cbxZona.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxTipo_KeyPress);
            this.cbxZona.Leave += new System.EventHandler(this.salir);
            // 
            // bsZonas
            // 
            this.bsZonas.DataMember = "v_zona";
            this.bsZonas.DataSource = this.dsSistemaTarjetas;
            // 
            // dsSistemaTarjetas
            // 
            this.dsSistemaTarjetas.DataSetName = "dsSistemaTarjetas";
            this.dsSistemaTarjetas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbxVendedor
            // 
            this.cbxVendedor.DataSource = this.bsVendedores;
            this.cbxVendedor.DisplayMember = "Nombre";
            this.cbxVendedor.Enabled = false;
            this.cbxVendedor.FormattingEnabled = true;
            this.cbxVendedor.Location = new System.Drawing.Point(351, 62);
            this.cbxVendedor.Name = "cbxVendedor";
            this.cbxVendedor.Size = new System.Drawing.Size(206, 21);
            this.cbxVendedor.TabIndex = 6;
            this.cbxVendedor.ValueMember = "Id";
            this.cbxVendedor.SelectedIndexChanged += new System.EventHandler(this.cbxVendedor_SelectedIndexChanged);
            this.cbxVendedor.Enter += new System.EventHandler(this.entrar);
            this.cbxVendedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxTipo_KeyPress);
            this.cbxVendedor.Leave += new System.EventHandler(this.salir);
            // 
            // bsVendedores
            // 
            this.bsVendedores.DataMember = "v_vendedor";
            this.bsVendedores.DataSource = this.dsSistemaTarjetas;
            // 
            // cbxFormaPago
            // 
            this.cbxFormaPago.Enabled = false;
            this.cbxFormaPago.FormattingEnabled = true;
            this.cbxFormaPago.ItemHeight = 13;
            this.cbxFormaPago.Items.AddRange(new object[] {
            "Semanal",
            "Quincenal",
            "Mensual"});
            this.cbxFormaPago.Location = new System.Drawing.Point(207, 62);
            this.cbxFormaPago.MaxDropDownItems = 3;
            this.cbxFormaPago.Name = "cbxFormaPago";
            this.cbxFormaPago.Size = new System.Drawing.Size(82, 21);
            this.cbxFormaPago.TabIndex = 5;
            this.cbxFormaPago.Enter += new System.EventHandler(this.entrar);
            this.cbxFormaPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxTipo_KeyPress);
            this.cbxFormaPago.Leave += new System.EventHandler(this.salir);
            // 
            // btnNueva
            // 
            this.btnNueva.Location = new System.Drawing.Point(9, 60);
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Size = new System.Drawing.Size(53, 23);
            this.btnNueva.TabIndex = 8;
            this.btnNueva.Text = "Nueva";
            this.btnNueva.UseVisualStyleBackColor = true;
            this.btnNueva.Click += new System.EventHandler(this.btnNueva_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Location = new System.Drawing.Point(68, 60);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(63, 23);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(80, 30);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(25, 23);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "B";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Location = new System.Drawing.Point(663, 30);
            this.txtTelefono.Mask = "000-000-0000";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PromptChar = ' ';
            this.txtTelefono.Size = new System.Drawing.Size(99, 20);
            this.txtTelefono.TabIndex = 4;
            this.txtTelefono.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.txtTelefono.Enter += new System.EventHandler(this.entrar);
            this.txtTelefono.Leave += new System.EventHandler(this.salir);
            // 
            // txtCedula
            // 
            this.txtCedula.Enabled = false;
            this.txtCedula.Location = new System.Drawing.Point(554, 30);
            this.txtCedula.Mask = "000-0000000-0";
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.PromptChar = ' ';
            this.txtCedula.Size = new System.Drawing.Size(100, 20);
            this.txtCedula.TabIndex = 3;
            this.txtCedula.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.txtCedula.Enter += new System.EventHandler(this.entrar);
            this.txtCedula.Leave += new System.EventHandler(this.salir);
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(118, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(236, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Enter += new System.EventHandler(this.entrar);
            this.txtNombre.Leave += new System.EventHandler(this.salir);
            // 
            // txtReferencia
            // 
            this.txtReferencia.Enabled = false;
            this.txtReferencia.Location = new System.Drawing.Point(372, 30);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(176, 20);
            this.txtReferencia.TabIndex = 2;
            this.txtReferencia.Enter += new System.EventHandler(this.entrar);
            this.txtReferencia.Leave += new System.EventHandler(this.salir);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(9, 32);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(65, 20);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.Enter += new System.EventHandler(this.entrar);
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            this.txtCodigo.Leave += new System.EventHandler(this.salir);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(551, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Cedula";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(137, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Forma Pago";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(293, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Vendedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(563, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Zona";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(660, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Referencia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.AllowUserToResizeColumns = false;
            this.dgvDetalles.AllowUserToResizeRows = false;
            this.dgvDetalles.AutoGenerateColumns = false;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.debitoDataGridViewTextBoxColumn,
            this.creditoDataGridViewTextBoxColumn,
            this.referenciaDataGridViewTextBoxColumn});
            this.dgvDetalles.DataSource = this.bsDetalles;
            this.dgvDetalles.Location = new System.Drawing.Point(12, 143);
            this.dgvDetalles.MultiSelect = false;
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.RowHeadersVisible = false;
            this.dgvDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalles.Size = new System.Drawing.Size(776, 298);
            this.dgvDetalles.TabIndex = 1;
            this.dgvDetalles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDetalles_KeyDown);
            // 
            // noDataGridViewTextBoxColumn
            // 
            this.noDataGridViewTextBoxColumn.DataPropertyName = "No.";
            this.noDataGridViewTextBoxColumn.HeaderText = "No.";
            this.noDataGridViewTextBoxColumn.Name = "noDataGridViewTextBoxColumn";
            this.noDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // debitoDataGridViewTextBoxColumn
            // 
            this.debitoDataGridViewTextBoxColumn.DataPropertyName = "Debito";
            this.debitoDataGridViewTextBoxColumn.HeaderText = "Debito";
            this.debitoDataGridViewTextBoxColumn.Name = "debitoDataGridViewTextBoxColumn";
            this.debitoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // creditoDataGridViewTextBoxColumn
            // 
            this.creditoDataGridViewTextBoxColumn.DataPropertyName = "Credito";
            this.creditoDataGridViewTextBoxColumn.HeaderText = "Credito";
            this.creditoDataGridViewTextBoxColumn.Name = "creditoDataGridViewTextBoxColumn";
            this.creditoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // referenciaDataGridViewTextBoxColumn
            // 
            this.referenciaDataGridViewTextBoxColumn.DataPropertyName = "Referencia";
            this.referenciaDataGridViewTextBoxColumn.HeaderText = "Referencia";
            this.referenciaDataGridViewTextBoxColumn.Name = "referenciaDataGridViewTextBoxColumn";
            this.referenciaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsDetalles
            // 
            this.bsDetalles.DataMember = "v_detalles_tarjeta";
            this.bsDetalles.DataSource = this.dsSistemaTarjetas;
            // 
            // pnlOp
            // 
            this.pnlOp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlOp.Controls.Add(this.btnAsentar);
            this.pnlOp.Controls.Add(this.txtValor);
            this.pnlOp.Controls.Add(this.dtpFecha);
            this.pnlOp.Controls.Add(this.cbxTipo);
            this.pnlOp.Controls.Add(this.label11);
            this.pnlOp.Controls.Add(this.label10);
            this.pnlOp.Controls.Add(this.label9);
            this.pnlOp.Location = new System.Drawing.Point(12, 470);
            this.pnlOp.Name = "pnlOp";
            this.pnlOp.Size = new System.Drawing.Size(406, 61);
            this.pnlOp.TabIndex = 2;
            // 
            // btnAsentar
            // 
            this.btnAsentar.Enabled = false;
            this.btnAsentar.Location = new System.Drawing.Point(311, 22);
            this.btnAsentar.Name = "btnAsentar";
            this.btnAsentar.Size = new System.Drawing.Size(75, 23);
            this.btnAsentar.TabIndex = 6;
            this.btnAsentar.Text = "Asentar";
            this.btnAsentar.UseVisualStyleBackColor = true;
            this.btnAsentar.Click += new System.EventHandler(this.btnAsentar_Click);
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(205, 25);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 5;
            this.txtValor.Enter += new System.EventHandler(this.entrar);
            this.txtValor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValor_KeyDown);
            this.txtValor.Leave += new System.EventHandler(this.salir);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(116, 26);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(78, 20);
            this.dtpFecha.TabIndex = 4;
            this.dtpFecha.Enter += new System.EventHandler(this.entrar);
            this.dtpFecha.Leave += new System.EventHandler(this.salir);
            // 
            // cbxTipo
            // 
            this.cbxTipo.Enabled = false;
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "Venta",
            "Cobro",
            "Descuento",
            "Devolución"});
            this.cbxTipo.Location = new System.Drawing.Point(7, 25);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(96, 21);
            this.cbxTipo.TabIndex = 3;
            this.cbxTipo.Enter += new System.EventHandler(this.entrar);
            this.cbxTipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxTipo_KeyPress);
            this.cbxTipo.Leave += new System.EventHandler(this.salir);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(113, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Fecha";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(202, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Valor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tipo";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(424, 481);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 3;
            this.btnImprimir.TabStop = false;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtBalance);
            this.panel2.Controls.Add(this.txtCredito);
            this.panel2.Controls.Add(this.txtDebito);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(505, 470);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 61);
            this.panel2.TabIndex = 4;
            // 
            // txtBalance
            // 
            this.txtBalance.BackColor = System.Drawing.SystemColors.Info;
            this.txtBalance.Location = new System.Drawing.Point(188, 26);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(88, 20);
            this.txtBalance.TabIndex = 5;
            this.txtBalance.TabStop = false;
            // 
            // txtCredito
            // 
            this.txtCredito.BackColor = System.Drawing.SystemColors.Info;
            this.txtCredito.Location = new System.Drawing.Point(98, 26);
            this.txtCredito.Name = "txtCredito";
            this.txtCredito.ReadOnly = true;
            this.txtCredito.Size = new System.Drawing.Size(84, 20);
            this.txtCredito.TabIndex = 4;
            this.txtCredito.TabStop = false;
            // 
            // txtDebito
            // 
            this.txtDebito.BackColor = System.Drawing.SystemColors.Info;
            this.txtDebito.Location = new System.Drawing.Point(3, 26);
            this.txtDebito.Name = "txtDebito";
            this.txtDebito.ReadOnly = true;
            this.txtDebito.Size = new System.Drawing.Size(89, 20);
            this.txtDebito.TabIndex = 3;
            this.txtDebito.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(185, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Balance";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(95, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Credito";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Debito";
            // 
            // v_vendedorTableAdapter
            // 
            this.v_vendedorTableAdapter.ClearBeforeFill = true;
            // 
            // v_zonaTableAdapter
            // 
            this.v_zonaTableAdapter.ClearBeforeFill = true;
            // 
            // v_detalles_tarjetaTableAdapter
            // 
            this.v_detalles_tarjetaTableAdapter.ClearBeforeFill = true;
            // 
            // FControlTarjetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 558);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.pnlOp);
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.groupBox1);
            this.Name = "FControlTarjetas";
            this.Text = "Control de Tarjetas";
            this.Load += new System.EventHandler(this.FControlTarjetas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsZonas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistemaTarjetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVendedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDetalles)).EndInit();
            this.pnlOp.ResumeLayout(false);
            this.pnlOp.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxFormaPago;
        private System.Windows.Forms.Button btnNueva;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private System.Windows.Forms.MaskedTextBox txtCedula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxZona;
        private System.Windows.Forms.ComboBox cbxVendedor;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.Panel pnlOp;
        private System.Windows.Forms.Button btnAsentar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtCredito;
        private System.Windows.Forms.TextBox txtDebito;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private dsSistemaTarjetasTableAdapters.Querys querys;
        private System.Windows.Forms.BindingSource bsVendedores;
        private System.Windows.Forms.BindingSource bsZonas;
        private dsSistemaTarjetas dsSistemaTarjetas;
        private dsSistemaTarjetasTableAdapters.v_vendedorTableAdapter v_vendedorTableAdapter;
        private dsSistemaTarjetasTableAdapters.v_zonaTableAdapter v_zonaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn debitoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsDetalles;
        private dsSistemaTarjetasTableAdapters.v_detalles_tarjetaTableAdapter v_detalles_tarjetaTableAdapter;
    }
}