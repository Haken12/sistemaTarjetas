
namespace sistemaTarjetas
{
    partial class FArticulosVentaT
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
            this.dgvBuscar = new System.Windows.Forms.DataGridView();
            this.btnSel = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.bsVenta = new System.Windows.Forms.BindingSource(this.components);
            this.dsDevoluciones = new sistemaTarjetas.dsDevoluciones();
            this.datosVentaTableAdapter = new sistemaTarjetas.dsDevolucionesTableAdapters.datosVentaTableAdapter();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDevoluciones)).BeginInit();
            this.SuspendLayout();
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
            this.productoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn});
            this.dgvBuscar.DataSource = this.bsVenta;
            this.dgvBuscar.Location = new System.Drawing.Point(12, 12);
            this.dgvBuscar.Name = "dgvBuscar";
            this.dgvBuscar.ReadOnly = true;
            this.dgvBuscar.RowHeadersVisible = false;
            this.dgvBuscar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBuscar.Size = new System.Drawing.Size(440, 224);
            this.dgvBuscar.TabIndex = 0;
            // 
            // btnSel
            // 
            this.btnSel.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSel.Location = new System.Drawing.Point(12, 242);
            this.btnSel.Name = "btnSel";
            this.btnSel.Size = new System.Drawing.Size(75, 23);
            this.btnSel.TabIndex = 1;
            this.btnSel.Text = "Seleccionar";
            this.btnSel.UseVisualStyleBackColor = true;
            this.btnSel.Click += new System.EventHandler(this.btnSel_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(93, 242);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // bsVenta
            // 
            this.bsVenta.DataMember = "datosVenta";
            this.bsVenta.DataSource = this.dsDevoluciones;
            // 
            // dsDevoluciones
            // 
            this.dsDevoluciones.DataSetName = "dsDevoluciones";
            this.dsDevoluciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datosVentaTableAdapter
            // 
            this.datosVentaTableAdapter.ClearBeforeFill = true;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Numero";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            this.numeroDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroDataGridViewTextBoxColumn.Visible = false;
            // 
            // productoDataGridViewTextBoxColumn
            // 
            this.productoDataGridViewTextBoxColumn.DataPropertyName = "Producto";
            this.productoDataGridViewTextBoxColumn.HeaderText = "Producto";
            this.productoDataGridViewTextBoxColumn.Name = "productoDataGridViewTextBoxColumn";
            this.productoDataGridViewTextBoxColumn.ReadOnly = true;
            this.productoDataGridViewTextBoxColumn.Width = 75;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn.Width = 200;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadDataGridViewTextBoxColumn.Width = 75;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioDataGridViewTextBoxColumn.Width = 75;
            // 
            // FArticulosVentaT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 282);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSel);
            this.Controls.Add(this.dgvBuscar);
            this.Name = "FArticulosVentaT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FArticulosVentaT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDevoluciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsVenta;
        private dsDevoluciones dsDevoluciones;
        private System.Windows.Forms.Button btnSel;
        private System.Windows.Forms.Button btnCancel;
        private dsDevolucionesTableAdapters.datosVentaTableAdapter datosVentaTableAdapter;
    }
}