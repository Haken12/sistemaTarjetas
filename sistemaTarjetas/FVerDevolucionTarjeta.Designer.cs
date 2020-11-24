
namespace sistemaTarjetas
{
    partial class FVerDevolucionTarjeta
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
            this.dgvVer = new System.Windows.Forms.DataGridView();
            this.ventaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsVer = new System.Windows.Forms.BindingSource(this.components);
            this.dsSistemaTarjetas = new sistemaTarjetas.dsSistemaTarjetas();
            this.button2 = new System.Windows.Forms.Button();
            this.verDetallesDevolucionTarjetaTableAdapter = new sistemaTarjetas.dsSistemaTarjetasTableAdapters.verDetallesDevolucionTarjetaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistemaTarjetas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVer
            // 
            this.dgvVer.AllowUserToAddRows = false;
            this.dgvVer.AllowUserToDeleteRows = false;
            this.dgvVer.AllowUserToResizeColumns = false;
            this.dgvVer.AllowUserToResizeRows = false;
            this.dgvVer.AutoGenerateColumns = false;
            this.dgvVer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ventaDataGridViewTextBoxColumn,
            this.detalleDataGridViewTextBoxColumn,
            this.productoDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.importeDataGridViewTextBoxColumn});
            this.dgvVer.DataSource = this.bsVer;
            this.dgvVer.Location = new System.Drawing.Point(12, 24);
            this.dgvVer.Name = "dgvVer";
            this.dgvVer.ReadOnly = true;
            this.dgvVer.RowHeadersVisible = false;
            this.dgvVer.Size = new System.Drawing.Size(588, 243);
            this.dgvVer.TabIndex = 0;
            // 
            // ventaDataGridViewTextBoxColumn
            // 
            this.ventaDataGridViewTextBoxColumn.DataPropertyName = "Venta";
            this.ventaDataGridViewTextBoxColumn.HeaderText = "Venta";
            this.ventaDataGridViewTextBoxColumn.Name = "ventaDataGridViewTextBoxColumn";
            this.ventaDataGridViewTextBoxColumn.ReadOnly = true;
            this.ventaDataGridViewTextBoxColumn.Width = 75;
            // 
            // detalleDataGridViewTextBoxColumn
            // 
            this.detalleDataGridViewTextBoxColumn.DataPropertyName = "Detalle";
            this.detalleDataGridViewTextBoxColumn.HeaderText = "Detalle";
            this.detalleDataGridViewTextBoxColumn.Name = "detalleDataGridViewTextBoxColumn";
            this.detalleDataGridViewTextBoxColumn.ReadOnly = true;
            this.detalleDataGridViewTextBoxColumn.Width = 75;
            // 
            // productoDataGridViewTextBoxColumn
            // 
            this.productoDataGridViewTextBoxColumn.DataPropertyName = "Producto";
            this.productoDataGridViewTextBoxColumn.HeaderText = "Producto";
            this.productoDataGridViewTextBoxColumn.Name = "productoDataGridViewTextBoxColumn";
            this.productoDataGridViewTextBoxColumn.ReadOnly = true;
            this.productoDataGridViewTextBoxColumn.Width = 200;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioDataGridViewTextBoxColumn.Width = 75;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadDataGridViewTextBoxColumn.Width = 80;
            // 
            // importeDataGridViewTextBoxColumn
            // 
            this.importeDataGridViewTextBoxColumn.DataPropertyName = "Importe";
            this.importeDataGridViewTextBoxColumn.HeaderText = "Importe";
            this.importeDataGridViewTextBoxColumn.Name = "importeDataGridViewTextBoxColumn";
            this.importeDataGridViewTextBoxColumn.ReadOnly = true;
            this.importeDataGridViewTextBoxColumn.Width = 80;
            // 
            // bsVer
            // 
            this.bsVer.DataMember = "verDetallesDevolucionTarjeta";
            this.bsVer.DataSource = this.dsSistemaTarjetas;
            // 
            // dsSistemaTarjetas
            // 
            this.dsSistemaTarjetas.DataSetName = "dsSistemaTarjetas";
            this.dsSistemaTarjetas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(508, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // verDetallesDevolucionTarjetaTableAdapter
            // 
            this.verDetallesDevolucionTarjetaTableAdapter.ClearBeforeFill = true;
            // 
            // FVerDevolucionTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 343);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvVer);
            this.Name = "FVerDevolucionTarjeta";
            this.Text = "Detalles Devolucion";
            this.Load += new System.EventHandler(this.FVerDevolucionTarjeta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistemaTarjetas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsVer;
        private System.Windows.Forms.DataGridView dgvVer;
        private System.Windows.Forms.Button button2;
        private dsSistemaTarjetas dsSistemaTarjetas;
        private dsSistemaTarjetasTableAdapters.verDetallesDevolucionTarjetaTableAdapter verDetallesDevolucionTarjetaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn importeDataGridViewTextBoxColumn;
    }
}