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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvListaVendedores = new System.Windows.Forms.DataGridView();
            this.bsVendedores = new System.Windows.Forms.BindingSource(this.components);
            this.dsSistemaTarjetas = new sistemaTarjetas.dsSistemaTarjetas();
            this.vVendedoresTableAdapter = new sistemaTarjetas.dsSistemaTarjetasTableAdapters.vVendedoresTableAdapter();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idayudanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deduccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ingreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.queriesTableAdapter1 = new sistemaTarjetas.dsSistemaTarjetasTableAdapters.QueriesTableAdapter();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVendedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVendedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistemaTarjetas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
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
            // dgvListaVendedores
            // 
            this.dgvListaVendedores.AllowUserToAddRows = false;
            this.dgvListaVendedores.AllowUserToDeleteRows = false;
            this.dgvListaVendedores.AutoGenerateColumns = false;
            this.dgvListaVendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaVendedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.idayudanteDataGridViewTextBoxColumn,
            this.Cedula,
            this.Direccion,
            this.Telefono,
            this.Celular,
            this.Comision,
            this.Deduccion,
            this.Ingreso});
            this.dgvListaVendedores.DataSource = this.bsVendedores;
            this.dgvListaVendedores.Location = new System.Drawing.Point(12, 133);
            this.dgvListaVendedores.MultiSelect = false;
            this.dgvListaVendedores.Name = "dgvListaVendedores";
            this.dgvListaVendedores.ReadOnly = true;
            this.dgvListaVendedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaVendedores.Size = new System.Drawing.Size(762, 282);
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
            // idayudanteDataGridViewTextBoxColumn
            // 
            this.idayudanteDataGridViewTextBoxColumn.DataPropertyName = "id_ayudante";
            this.idayudanteDataGridViewTextBoxColumn.HeaderText = "Ayudante";
            this.idayudanteDataGridViewTextBoxColumn.Name = "idayudanteDataGridViewTextBoxColumn";
            this.idayudanteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idayudanteDataGridViewTextBoxColumn.Width = 130;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn idayudanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deduccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ingreso;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private dsSistemaTarjetasTableAdapters.QueriesTableAdapter queriesTableAdapter1;
    }
}