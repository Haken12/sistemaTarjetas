namespace sistemaTarjetas
{
    partial class FListaVendedores
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
            this.txtBuscarNombre = new System.Windows.Forms.TextBox();
            this.txtBuscarId = new System.Windows.Forms.TextBox();
            this.rbNombre = new System.Windows.Forms.RadioButton();
            this.rbId = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvListaVendedores = new System.Windows.Forms.DataGridView();
            this.bsVendedores = new System.Windows.Forms.BindingSource(this.components);
            this.dsSistemaTarjetas = new sistemaTarjetas.dsSistemaTarjetas();
            this.vVendedoresTableAdapter = new sistemaTarjetas.dsSistemaTarjetasTableAdapters.vVendedoresTableAdapter();
            this.queriesTableAdapter1 = new sistemaTarjetas.dsSistemaTarjetasTableAdapters.QueriesTableAdapter();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ayudante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deduccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ingreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idayudanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVendedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVendedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistemaTarjetas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBuscarNombre);
            this.groupBox1.Controls.Add(this.txtBuscarId);
            this.groupBox1.Controls.Add(this.rbNombre);
            this.groupBox1.Controls.Add(this.rbId);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // txtBuscarNombre
            // 
            this.txtBuscarNombre.Enabled = false;
            this.txtBuscarNombre.Location = new System.Drawing.Point(112, 72);
            this.txtBuscarNombre.Name = "txtBuscarNombre";
            this.txtBuscarNombre.Size = new System.Drawing.Size(169, 20);
            this.txtBuscarNombre.TabIndex = 3;
            this.txtBuscarNombre.TextChanged += new System.EventHandler(this.txtBuscarNombre_TextChanged);
            // 
            // txtBuscarId
            // 
            this.txtBuscarId.Enabled = false;
            this.txtBuscarId.Location = new System.Drawing.Point(112, 33);
            this.txtBuscarId.Name = "txtBuscarId";
            this.txtBuscarId.Size = new System.Drawing.Size(56, 20);
            this.txtBuscarId.TabIndex = 2;
            this.txtBuscarId.TextChanged += new System.EventHandler(this.txtBuscarId_TextChanged);
            this.txtBuscarId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarId_KeyPress);
            // 
            // rbNombre
            // 
            this.rbNombre.AutoSize = true;
            this.rbNombre.Location = new System.Drawing.Point(25, 72);
            this.rbNombre.Name = "rbNombre";
            this.rbNombre.Size = new System.Drawing.Size(81, 17);
            this.rbNombre.TabIndex = 1;
            this.rbNombre.TabStop = true;
            this.rbNombre.Text = "Por Nombre";
            this.rbNombre.UseVisualStyleBackColor = true;
            this.rbNombre.CheckedChanged += new System.EventHandler(this.rbNombre_CheckedChanged);
            // 
            // rbId
            // 
            this.rbId.AutoSize = true;
            this.rbId.Location = new System.Drawing.Point(25, 36);
            this.rbId.Name = "rbId";
            this.rbId.Size = new System.Drawing.Size(53, 17);
            this.rbId.TabIndex = 0;
            this.rbId.TabStop = true;
            this.rbId.Text = "Por Id";
            this.rbId.UseVisualStyleBackColor = true;
            this.rbId.CheckedChanged += new System.EventHandler(this.rbId_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnModificar);
            this.groupBox2.Controls.Add(this.btnNuevo);
            this.groupBox2.Location = new System.Drawing.Point(457, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(118, 60);
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
            this.btnModificar.Location = new System.Drawing.Point(19, 60);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(19, 19);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvListaVendedores
            // 
            this.dgvListaVendedores.AllowUserToAddRows = false;
            this.dgvListaVendedores.AllowUserToDeleteRows = false;
            this.dgvListaVendedores.AutoGenerateColumns = false;
            this.dgvListaVendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaVendedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Ayudante,
            this.Cedula,
            this.Direccion,
            this.Telefono,
            this.Celular,
            this.Comision,
            this.Deduccion,
            this.Ingreso,
            this.idayudanteDataGridViewTextBoxColumn});
            this.dgvListaVendedores.DataSource = this.bsVendedores;
            this.dgvListaVendedores.Location = new System.Drawing.Point(12, 133);
            this.dgvListaVendedores.MultiSelect = false;
            this.dgvListaVendedores.Name = "dgvListaVendedores";
            this.dgvListaVendedores.ReadOnly = true;
            this.dgvListaVendedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaVendedores.Size = new System.Drawing.Size(776, 282);
            this.dgvListaVendedores.TabIndex = 2;
            // 
            // bsVendedores
            // 
            this.bsVendedores.DataMember = "vVendedores";
            this.bsVendedores.DataSource = this.dsSistemaTarjetas;
            // 
            // dsSistemaTarjetas
            // 
            this.dsSistemaTarjetas.DataSetName = "dsSistemaTarjetas";
            this.dsSistemaTarjetas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vVendedoresTableAdapter
            // 
            this.vVendedoresTableAdapter.ClearBeforeFill = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 130;
            // 
            // Ayudante
            // 
            this.Ayudante.DataPropertyName = "Ayudante";
            this.Ayudante.HeaderText = "Ayudante";
            this.Ayudante.Name = "Ayudante";
            this.Ayudante.ReadOnly = true;
            // 
            // Cedula
            // 
            this.Cedula.DataPropertyName = "Cedula";
            this.Cedula.HeaderText = "Cedula";
            this.Cedula.Name = "Cedula";
            this.Cedula.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Celular
            // 
            this.Celular.DataPropertyName = "Celular";
            this.Celular.HeaderText = "Celular";
            this.Celular.Name = "Celular";
            this.Celular.ReadOnly = true;
            // 
            // Comision
            // 
            this.Comision.DataPropertyName = "Comision";
            this.Comision.HeaderText = "Comision";
            this.Comision.Name = "Comision";
            this.Comision.ReadOnly = true;
            // 
            // Deduccion
            // 
            this.Deduccion.DataPropertyName = "Deduccion";
            this.Deduccion.HeaderText = "Deduccion";
            this.Deduccion.Name = "Deduccion";
            this.Deduccion.ReadOnly = true;
            // 
            // Ingreso
            // 
            this.Ingreso.DataPropertyName = "Ingreso";
            this.Ingreso.HeaderText = "Ingreso";
            this.Ingreso.Name = "Ingreso";
            this.Ingreso.ReadOnly = true;
            // 
            // idayudanteDataGridViewTextBoxColumn
            // 
            this.idayudanteDataGridViewTextBoxColumn.DataPropertyName = "id_ayudante";
            this.idayudanteDataGridViewTextBoxColumn.HeaderText = "id_ayudante";
            this.idayudanteDataGridViewTextBoxColumn.Name = "idayudanteDataGridViewTextBoxColumn";
            this.idayudanteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FListaVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvListaVendedores);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FListaVendedores";
            this.Text = "FListaVendedores";
            this.Load += new System.EventHandler(this.FListaVendedores_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVendedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVendedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistemaTarjetas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvListaVendedores;
        private System.Windows.Forms.BindingSource bsVendedores;
        private dsSistemaTarjetas dsSistemaTarjetas;
        private dsSistemaTarjetasTableAdapters.vVendedoresTableAdapter vVendedoresTableAdapter;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private dsSistemaTarjetasTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.TextBox txtBuscarNombre;
        private System.Windows.Forms.TextBox txtBuscarId;
        private System.Windows.Forms.RadioButton rbNombre;
        private System.Windows.Forms.RadioButton rbId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ayudante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deduccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ingreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn idayudanteDataGridViewTextBoxColumn;
    }
}