namespace sistemaTarjetas
{
    partial class FListaAyudantes
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
            this.txtBuscarId = new System.Windows.Forms.TextBox();
            this.rbId = new System.Windows.Forms.RadioButton();
            this.rbNombre = new System.Windows.Forms.RadioButton();
            this.txtBuscarNombre = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvListaAyudantes = new System.Windows.Forms.DataGridView();
            this.idayudanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deduccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaingresoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsAyudantes = new System.Windows.Forms.BindingSource(this.components);
            this.dsSistemaTarjetas = new sistemaTarjetas.dsSistemaTarjetas();
            this.ayudanteTableAdapter = new sistemaTarjetas.dsSistemaTarjetasTableAdapters.ayudanteTableAdapter();
            this.queriesTableAdapter1 = new sistemaTarjetas.dsSistemaTarjetasTableAdapters.QueriesTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaAyudantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAyudantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistemaTarjetas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBuscarId);
            this.groupBox1.Controls.Add(this.rbId);
            this.groupBox1.Controls.Add(this.rbNombre);
            this.groupBox1.Controls.Add(this.txtBuscarNombre);
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // txtBuscarId
            // 
            this.txtBuscarId.Enabled = false;
            this.txtBuscarId.Location = new System.Drawing.Point(106, 31);
            this.txtBuscarId.Name = "txtBuscarId";
            this.txtBuscarId.Size = new System.Drawing.Size(68, 20);
            this.txtBuscarId.TabIndex = 4;
            this.txtBuscarId.TextChanged += new System.EventHandler(this.txtBuscarId_TextChanged);
            this.txtBuscarId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumero);
            // 
            // rbId
            // 
            this.rbId.AutoSize = true;
            this.rbId.Location = new System.Drawing.Point(19, 34);
            this.rbId.Name = "rbId";
            this.rbId.Size = new System.Drawing.Size(53, 17);
            this.rbId.TabIndex = 3;
            this.rbId.TabStop = true;
            this.rbId.Text = "Por Id";
            this.rbId.UseVisualStyleBackColor = true;
            this.rbId.CheckedChanged += new System.EventHandler(this.rbId_CheckedChanged);
            // 
            // rbNombre
            // 
            this.rbNombre.AutoSize = true;
            this.rbNombre.Location = new System.Drawing.Point(19, 80);
            this.rbNombre.Name = "rbNombre";
            this.rbNombre.Size = new System.Drawing.Size(81, 17);
            this.rbNombre.TabIndex = 2;
            this.rbNombre.TabStop = true;
            this.rbNombre.Text = "Por Nombre";
            this.rbNombre.UseVisualStyleBackColor = true;
            this.rbNombre.CheckedChanged += new System.EventHandler(this.rbNombre_CheckedChanged);
            // 
            // txtBuscarNombre
            // 
            this.txtBuscarNombre.Enabled = false;
            this.txtBuscarNombre.Location = new System.Drawing.Point(106, 79);
            this.txtBuscarNombre.Name = "txtBuscarNombre";
            this.txtBuscarNombre.Size = new System.Drawing.Size(153, 20);
            this.txtBuscarNombre.TabIndex = 1;
            this.txtBuscarNombre.TextChanged += new System.EventHandler(this.txtBuscarNombre_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnModificar);
            this.groupBox2.Controls.Add(this.btnNuevo);
            this.groupBox2.Location = new System.Drawing.Point(375, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 114);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operaciones";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(126, 31);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Location = new System.Drawing.Point(19, 74);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(19, 31);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvListaAyudantes
            // 
            this.dgvListaAyudantes.AllowUserToAddRows = false;
            this.dgvListaAyudantes.AllowUserToDeleteRows = false;
            this.dgvListaAyudantes.AutoGenerateColumns = false;
            this.dgvListaAyudantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaAyudantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idayudanteDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.cedulaDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.celularDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.comisionDataGridViewTextBoxColumn,
            this.deduccionDataGridViewTextBoxColumn,
            this.fechaingresoDataGridViewTextBoxColumn});
            this.dgvListaAyudantes.DataSource = this.bsAyudantes;
            this.dgvListaAyudantes.Location = new System.Drawing.Point(12, 149);
            this.dgvListaAyudantes.MultiSelect = false;
            this.dgvListaAyudantes.Name = "dgvListaAyudantes";
            this.dgvListaAyudantes.ReadOnly = true;
            this.dgvListaAyudantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaAyudantes.ShowEditingIcon = false;
            this.dgvListaAyudantes.Size = new System.Drawing.Size(776, 262);
            this.dgvListaAyudantes.TabIndex = 2;
            // 
            // idayudanteDataGridViewTextBoxColumn
            // 
            this.idayudanteDataGridViewTextBoxColumn.DataPropertyName = "id_ayudante";
            this.idayudanteDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idayudanteDataGridViewTextBoxColumn.Name = "idayudanteDataGridViewTextBoxColumn";
            this.idayudanteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idayudanteDataGridViewTextBoxColumn.Width = 50;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 150;
            // 
            // cedulaDataGridViewTextBoxColumn
            // 
            this.cedulaDataGridViewTextBoxColumn.DataPropertyName = "cedula";
            this.cedulaDataGridViewTextBoxColumn.HeaderText = "Cédula";
            this.cedulaDataGridViewTextBoxColumn.Name = "cedulaDataGridViewTextBoxColumn";
            this.cedulaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Dirección";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // celularDataGridViewTextBoxColumn
            // 
            this.celularDataGridViewTextBoxColumn.DataPropertyName = "celular";
            this.celularDataGridViewTextBoxColumn.HeaderText = "Celular";
            this.celularDataGridViewTextBoxColumn.Name = "celularDataGridViewTextBoxColumn";
            this.celularDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Teléfono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // comisionDataGridViewTextBoxColumn
            // 
            this.comisionDataGridViewTextBoxColumn.DataPropertyName = "comision";
            this.comisionDataGridViewTextBoxColumn.HeaderText = "Comision";
            this.comisionDataGridViewTextBoxColumn.Name = "comisionDataGridViewTextBoxColumn";
            this.comisionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deduccionDataGridViewTextBoxColumn
            // 
            this.deduccionDataGridViewTextBoxColumn.DataPropertyName = "deduccion";
            this.deduccionDataGridViewTextBoxColumn.HeaderText = "Deduccion";
            this.deduccionDataGridViewTextBoxColumn.Name = "deduccionDataGridViewTextBoxColumn";
            this.deduccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaingresoDataGridViewTextBoxColumn
            // 
            this.fechaingresoDataGridViewTextBoxColumn.DataPropertyName = "fecha_ingreso";
            this.fechaingresoDataGridViewTextBoxColumn.HeaderText = "Ingreso";
            this.fechaingresoDataGridViewTextBoxColumn.Name = "fechaingresoDataGridViewTextBoxColumn";
            this.fechaingresoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsAyudantes
            // 
            this.bsAyudantes.DataMember = "ayudante";
            this.bsAyudantes.DataSource = this.dsSistemaTarjetas;
            // 
            // dsSistemaTarjetas
            // 
            this.dsSistemaTarjetas.DataSetName = "dsSistemaTarjetas";
            this.dsSistemaTarjetas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ayudanteTableAdapter
            // 
            this.ayudanteTableAdapter.ClearBeforeFill = true;
            // 
            // FListaAyudantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvListaAyudantes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FListaAyudantes";
            this.Text = "Lista de Ayudantes";
            this.Load += new System.EventHandler(this.FListaAyudantes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaAyudantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAyudantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistemaTarjetas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBuscarId;
        private System.Windows.Forms.RadioButton rbId;
        private System.Windows.Forms.RadioButton rbNombre;
        private System.Windows.Forms.TextBox txtBuscarNombre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvListaAyudantes;
        private System.Windows.Forms.BindingSource bsAyudantes;
        private dsSistemaTarjetas dsSistemaTarjetas;
        private dsSistemaTarjetasTableAdapters.ayudanteTableAdapter ayudanteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idayudanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deduccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaingresoDataGridViewTextBoxColumn;
        private dsSistemaTarjetasTableAdapters.QueriesTableAdapter queriesTableAdapter1;
    }
}