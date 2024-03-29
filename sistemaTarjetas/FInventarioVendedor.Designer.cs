﻿namespace sistemaTarjetas
{
    partial class FInventarioVendedor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dgvInventarioVendedor = new System.Windows.Forms.DataGridView();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gananciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existenciasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsInventario = new System.Windows.Forms.BindingSource(this.components);
            this.dsInventario = new sistemaTarjetas.dsInventario();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbNombre = new System.Windows.Forms.ComboBox();
            this.bsVendedores = new System.Windows.Forms.BindingSource(this.components);
            this.dsSistemaTarjetas = new sistemaTarjetas.dsSistemaTarjetas();
            this.txtId = new System.Windows.Forms.TextBox();
            this.rbNombre = new System.Windows.Forms.RadioButton();
            this.rbId = new System.Windows.Forms.RadioButton();
            this.querys = new sistemaTarjetas.dsSistemaTarjetasTableAdapters.Querys();
            this.v_vendedorTableAdapter = new sistemaTarjetas.dsSistemaTarjetasTableAdapters.v_vendedorTableAdapter();
            this.v_inventario_vendedorTableAdapter = new sistemaTarjetas.dsInventarioTableAdapters.v_inventario_vendedorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventarioVendedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInventario)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsVendedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistemaTarjetas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(563, 418);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(86, 43);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.ClickCerrar);
            // 
            // dgvInventarioVendedor
            // 
            this.dgvInventarioVendedor.AllowUserToAddRows = false;
            this.dgvInventarioVendedor.AllowUserToDeleteRows = false;
            this.dgvInventarioVendedor.AllowUserToOrderColumns = true;
            this.dgvInventarioVendedor.AllowUserToResizeColumns = false;
            this.dgvInventarioVendedor.AllowUserToResizeRows = false;
            this.dgvInventarioVendedor.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventarioVendedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventarioVendedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventarioVendedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.costoDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.gananciaDataGridViewTextBoxColumn,
            this.existenciasDataGridViewTextBoxColumn});
            this.dgvInventarioVendedor.DataSource = this.bsInventario;
            this.dgvInventarioVendedor.Location = new System.Drawing.Point(15, 97);
            this.dgvInventarioVendedor.MultiSelect = false;
            this.dgvInventarioVendedor.Name = "dgvInventarioVendedor";
            this.dgvInventarioVendedor.ReadOnly = true;
            this.dgvInventarioVendedor.RowHeadersVisible = false;
            this.dgvInventarioVendedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventarioVendedor.Size = new System.Drawing.Size(634, 300);
            this.dgvInventarioVendedor.TabIndex = 2;
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
            // 
            // costoDataGridViewTextBoxColumn
            // 
            this.costoDataGridViewTextBoxColumn.DataPropertyName = "Costo";
            this.costoDataGridViewTextBoxColumn.HeaderText = "Costo";
            this.costoDataGridViewTextBoxColumn.Name = "costoDataGridViewTextBoxColumn";
            this.costoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gananciaDataGridViewTextBoxColumn
            // 
            this.gananciaDataGridViewTextBoxColumn.DataPropertyName = "Ganancia";
            this.gananciaDataGridViewTextBoxColumn.HeaderText = "Ganancia";
            this.gananciaDataGridViewTextBoxColumn.Name = "gananciaDataGridViewTextBoxColumn";
            this.gananciaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // existenciasDataGridViewTextBoxColumn
            // 
            this.existenciasDataGridViewTextBoxColumn.DataPropertyName = "Existencias";
            this.existenciasDataGridViewTextBoxColumn.HeaderText = "Existencias";
            this.existenciasDataGridViewTextBoxColumn.Name = "existenciasDataGridViewTextBoxColumn";
            this.existenciasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsInventario
            // 
            this.bsInventario.DataMember = "v_inventario_vendedor";
            this.bsInventario.DataSource = this.dsInventario;
            // 
            // dsInventario
            // 
            this.dsInventario.DataSetName = "dsInventario";
            this.dsInventario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbNombre);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.rbNombre);
            this.groupBox1.Controls.Add(this.rbId);
            this.groupBox1.Location = new System.Drawing.Point(15, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 83);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por:";
            // 
            // cbNombre
            // 
            this.cbNombre.DataSource = this.bsVendedores;
            this.cbNombre.DisplayMember = "Nombre";
            this.cbNombre.FormattingEnabled = true;
            this.cbNombre.Location = new System.Drawing.Point(90, 48);
            this.cbNombre.Name = "cbNombre";
            this.cbNombre.Size = new System.Drawing.Size(327, 21);
            this.cbNombre.TabIndex = 3;
            this.cbNombre.ValueMember = "Id";
            this.cbNombre.SelectedIndexChanged += new System.EventHandler(this.cbNombre_SelectedIndexChanged);
            // 
            // bsVendedores
            // 
            this.bsVendedores.DataMember = "v_vendedor";
            this.bsVendedores.DataSource = this.dsSistemaTarjetas;
            // 
            // dsSistemaTarjetas
            // 
            this.dsSistemaTarjetas.DataSetName = "dsSistemaTarjetas";
            this.dsSistemaTarjetas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(91, 19);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 2;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // rbNombre
            // 
            this.rbNombre.AutoSize = true;
            this.rbNombre.Location = new System.Drawing.Point(19, 49);
            this.rbNombre.Name = "rbNombre";
            this.rbNombre.Size = new System.Drawing.Size(65, 17);
            this.rbNombre.TabIndex = 1;
            this.rbNombre.TabStop = true;
            this.rbNombre.Text = "Nombre:";
            this.rbNombre.UseVisualStyleBackColor = true;
            // 
            // rbId
            // 
            this.rbId.AutoSize = true;
            this.rbId.Location = new System.Drawing.Point(19, 20);
            this.rbId.Name = "rbId";
            this.rbId.Size = new System.Drawing.Size(37, 17);
            this.rbId.TabIndex = 0;
            this.rbId.TabStop = true;
            this.rbId.Text = "Id:";
            this.rbId.UseVisualStyleBackColor = true;
            this.rbId.CheckedChanged += new System.EventHandler(this.rbId_CheckedChanged);
            // 
            // v_vendedorTableAdapter
            // 
            this.v_vendedorTableAdapter.ClearBeforeFill = true;
            // 
            // v_inventario_vendedorTableAdapter
            // 
            this.v_inventario_vendedorTableAdapter.ClearBeforeFill = true;
            // 
            // FInventarioVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 473);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvInventarioVendedor);
            this.Controls.Add(this.btnCerrar);
            this.Name = "FInventarioVendedor";
            this.Load += new System.EventHandler(this.FInventarioVendedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventarioVendedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInventario)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsVendedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistemaTarjetas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvInventarioVendedor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.RadioButton rbNombre;
        private System.Windows.Forms.RadioButton rbId;
        private System.Windows.Forms.ComboBox cbNombre;
        private dsSistemaTarjetasTableAdapters.Querys querys;
        private dsSistemaTarjetasTableAdapters.v_vendedorTableAdapter v_vendedorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gananciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn existenciasDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsInventario;
        private dsInventario dsInventario;
        private System.Windows.Forms.BindingSource bsVendedores;
        private dsInventarioTableAdapters.v_inventario_vendedorTableAdapter v_inventario_vendedorTableAdapter;
        private dsSistemaTarjetas dsSistemaTarjetas;
    }
}