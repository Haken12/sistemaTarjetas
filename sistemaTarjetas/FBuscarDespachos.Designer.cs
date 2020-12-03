namespace sistemaTarjetas
{
    partial class FBuscarDespachos
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
            this.btnSel = new System.Windows.Forms.Button();
            this.btnCan = new System.Windows.Forms.Button();
            this.dgvBuscar = new System.Windows.Forms.DataGridView();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articulosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsBuscar = new System.Windows.Forms.BindingSource(this.components);
            this.dsDespachos = new sistemaTarjetas.dsDespachos();
            this.verDespachosTableAdapter = new sistemaTarjetas.dsDespachosTableAdapters.verDespachosTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpFecha2 = new System.Windows.Forms.DateTimePicker();
            this.dtpFecha1 = new System.Windows.Forms.DateTimePicker();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.rbFecha = new System.Windows.Forms.RadioButton();
            this.rbVendedor = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDespachos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSel
            // 
            this.btnSel.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSel.Image = global::sistemaTarjetas.Recursos._02__3_;
            this.btnSel.Location = new System.Drawing.Point(12, 335);
            this.btnSel.Name = "btnSel";
            this.btnSel.Size = new System.Drawing.Size(118, 38);
            this.btnSel.TabIndex = 0;
            this.btnSel.Text = "&Seleccionar";
            this.btnSel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSel.UseVisualStyleBackColor = true;
            this.btnSel.Click += new System.EventHandler(this.btnSel_Click);
            // 
            // btnCan
            // 
            this.btnCan.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCan.Image = global::sistemaTarjetas.Recursos._50__3_;
            this.btnCan.Location = new System.Drawing.Point(529, 335);
            this.btnCan.Name = "btnCan";
            this.btnCan.Size = new System.Drawing.Size(108, 38);
            this.btnCan.TabIndex = 1;
            this.btnCan.Text = "&Cancelar";
            this.btnCan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCan.UseVisualStyleBackColor = true;
            // 
            // dgvBuscar
            // 
            this.dgvBuscar.AllowUserToAddRows = false;
            this.dgvBuscar.AllowUserToDeleteRows = false;
            this.dgvBuscar.AllowUserToResizeColumns = false;
            this.dgvBuscar.AllowUserToResizeRows = false;
            this.dgvBuscar.AutoGenerateColumns = false;
            this.dgvBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroDataGridViewTextBoxColumn,
            this.vendedorDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.articulosDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dgvBuscar.DataSource = this.bsBuscar;
            this.dgvBuscar.Location = new System.Drawing.Point(12, 108);
            this.dgvBuscar.MultiSelect = false;
            this.dgvBuscar.Name = "dgvBuscar";
            this.dgvBuscar.ReadOnly = true;
            this.dgvBuscar.RowHeadersVisible = false;
            this.dgvBuscar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBuscar.Size = new System.Drawing.Size(625, 221);
            this.dgvBuscar.TabIndex = 2;
            this.dgvBuscar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuscar_CellContentClick);
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Numero";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            this.numeroDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroDataGridViewTextBoxColumn.Width = 80;
            // 
            // vendedorDataGridViewTextBoxColumn
            // 
            this.vendedorDataGridViewTextBoxColumn.DataPropertyName = "Vendedor";
            this.vendedorDataGridViewTextBoxColumn.HeaderText = "Vendedor";
            this.vendedorDataGridViewTextBoxColumn.Name = "vendedorDataGridViewTextBoxColumn";
            this.vendedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.vendedorDataGridViewTextBoxColumn.Width = 250;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // articulosDataGridViewTextBoxColumn
            // 
            this.articulosDataGridViewTextBoxColumn.DataPropertyName = "Articulos";
            this.articulosDataGridViewTextBoxColumn.HeaderText = "Articulos";
            this.articulosDataGridViewTextBoxColumn.Name = "articulosDataGridViewTextBoxColumn";
            this.articulosDataGridViewTextBoxColumn.ReadOnly = true;
            this.articulosDataGridViewTextBoxColumn.Width = 80;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsBuscar
            // 
            this.bsBuscar.DataMember = "verDespachos";
            this.bsBuscar.DataSource = this.dsDespachos;
            // 
            // dsDespachos
            // 
            this.dsDespachos.DataSetName = "dsDespachos";
            this.dsDespachos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // verDespachosTableAdapter
            // 
            this.verDespachosTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpFecha2);
            this.groupBox1.Controls.Add(this.dtpFecha1);
            this.groupBox1.Controls.Add(this.txtVendedor);
            this.groupBox1.Controls.Add(this.rbFecha);
            this.groupBox1.Controls.Add(this.rbVendedor);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 90);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // dtpFecha2
            // 
            this.dtpFecha2.CustomFormat = "";
            this.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha2.Location = new System.Drawing.Point(255, 53);
            this.dtpFecha2.Name = "dtpFecha2";
            this.dtpFecha2.Size = new System.Drawing.Size(112, 24);
            this.dtpFecha2.TabIndex = 8;
            this.dtpFecha2.ValueChanged += new System.EventHandler(this.dtpFecha2_ValueChanged);
            // 
            // dtpFecha1
            // 
            this.dtpFecha1.CustomFormat = "";
            this.dtpFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha1.Location = new System.Drawing.Point(137, 53);
            this.dtpFecha1.Name = "dtpFecha1";
            this.dtpFecha1.Size = new System.Drawing.Size(112, 24);
            this.dtpFecha1.TabIndex = 7;
            this.dtpFecha1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtVendedor
            // 
            this.txtVendedor.Location = new System.Drawing.Point(137, 23);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(256, 24);
            this.txtVendedor.TabIndex = 6;
            this.txtVendedor.TextChanged += new System.EventHandler(this.txtVendedor_TextChanged);
            // 
            // rbFecha
            // 
            this.rbFecha.AutoSize = true;
            this.rbFecha.Location = new System.Drawing.Point(6, 51);
            this.rbFecha.Name = "rbFecha";
            this.rbFecha.Size = new System.Drawing.Size(99, 22);
            this.rbFecha.TabIndex = 5;
            this.rbFecha.TabStop = true;
            this.rbFecha.Text = "Por Fecha:";
            this.rbFecha.UseVisualStyleBackColor = true;
            this.rbFecha.CheckedChanged += new System.EventHandler(this.rbFecha_CheckedChanged);
            // 
            // rbVendedor
            // 
            this.rbVendedor.AutoSize = true;
            this.rbVendedor.Location = new System.Drawing.Point(6, 23);
            this.rbVendedor.Name = "rbVendedor";
            this.rbVendedor.Size = new System.Drawing.Size(125, 22);
            this.rbVendedor.TabIndex = 4;
            this.rbVendedor.TabStop = true;
            this.rbVendedor.Text = "Por Vendedor:";
            this.rbVendedor.UseVisualStyleBackColor = true;
            this.rbVendedor.CheckedChanged += new System.EventHandler(this.rbVendedor_CheckedChanged);
            // 
            // FBuscarDespachos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(67)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(649, 385);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvBuscar);
            this.Controls.Add(this.btnCan);
            this.Controls.Add(this.btnSel);
            this.Font = new System.Drawing.Font("Meiryo UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FBuscarDespachos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Despacho";
            this.Load += new System.EventHandler(this.FBuscarDespachos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDespachos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSel;
        private System.Windows.Forms.Button btnCan;
        private System.Windows.Forms.DataGridView dgvBuscar;
        private System.Windows.Forms.BindingSource bsBuscar;
        private dsDespachos dsDespachos;
        private dsDespachosTableAdapters.verDespachosTableAdapter verDespachosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn articulosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.RadioButton rbFecha;
        private System.Windows.Forms.RadioButton rbVendedor;
        private System.Windows.Forms.DateTimePicker dtpFecha1;
        private System.Windows.Forms.DateTimePicker dtpFecha2;
    }
}

