namespace sistemaTarjetas
{
    partial class FTarjetas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.bsCliente = new System.Windows.Forms.BindingSource(this.components);
            this.dsSistemaTarjetas = new sistemaTarjetas.dsSistemaTarjetas();
            this.cbxZona = new System.Windows.Forms.ComboBox();
            this.bsZona = new System.Windows.Forms.BindingSource(this.components);
            this.cbxFormaPago = new System.Windows.Forms.ComboBox();
            this.cbxVendedor = new System.Windows.Forms.ComboBox();
            this.bsVendedor = new System.Windows.Forms.BindingSource(this.components);
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.vClientesTableAdapter = new sistemaTarjetas.dsSistemaTarjetasTableAdapters.vClientesTableAdapter();
            this.vZonaTableAdapter = new sistemaTarjetas.dsSistemaTarjetasTableAdapters.vZonaTableAdapter();
            this.vVendedoresTableAdapter = new sistemaTarjetas.dsSistemaTarjetasTableAdapters.vVendedoresTableAdapter();
            this.queriesTableAdapter1 = new sistemaTarjetas.dsSistemaTarjetasTableAdapters.QueriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bsCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistemaTarjetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsZona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVendedor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vendedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Forma de Pago";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Zona";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha";
            // 
            // cbxCliente
            // 
            this.cbxCliente.DataSource = this.bsCliente;
            this.cbxCliente.DisplayMember = "Nombre";
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(79, 17);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(172, 21);
            this.cbxCliente.TabIndex = 5;
            this.cbxCliente.ValueMember = "Codigo";
            // 
            // bsCliente
            // 
            this.bsCliente.DataMember = "vClientes";
            this.bsCliente.DataSource = this.dsSistemaTarjetas;
            // 
            // dsSistemaTarjetas
            // 
            this.dsSistemaTarjetas.DataSetName = "dsSistemaTarjetas";
            this.dsSistemaTarjetas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbxZona
            // 
            this.cbxZona.DataSource = this.bsZona;
            this.cbxZona.DisplayMember = "Descripcion";
            this.cbxZona.FormattingEnabled = true;
            this.cbxZona.Location = new System.Drawing.Point(79, 75);
            this.cbxZona.Name = "cbxZona";
            this.cbxZona.Size = new System.Drawing.Size(172, 21);
            this.cbxZona.TabIndex = 6;
            this.cbxZona.ValueMember = "Id";
            // 
            // bsZona
            // 
            this.bsZona.DataMember = "vZona";
            this.bsZona.DataSource = this.dsSistemaTarjetas;
            // 
            // cbxFormaPago
            // 
            this.cbxFormaPago.FormattingEnabled = true;
            this.cbxFormaPago.Items.AddRange(new object[] {
            "Semanal",
            "Quincenal",
            "Mensual"});
            this.cbxFormaPago.Location = new System.Drawing.Point(354, 17);
            this.cbxFormaPago.Name = "cbxFormaPago";
            this.cbxFormaPago.Size = new System.Drawing.Size(121, 21);
            this.cbxFormaPago.TabIndex = 7;
            // 
            // cbxVendedor
            // 
            this.cbxVendedor.DataSource = this.bsVendedor;
            this.cbxVendedor.DisplayMember = "Nombre";
            this.cbxVendedor.FormattingEnabled = true;
            this.cbxVendedor.Location = new System.Drawing.Point(79, 44);
            this.cbxVendedor.Name = "cbxVendedor";
            this.cbxVendedor.Size = new System.Drawing.Size(172, 21);
            this.cbxVendedor.TabIndex = 8;
            this.cbxVendedor.ValueMember = "Id";
            this.cbxVendedor.SelectedIndexChanged += new System.EventHandler(this.cbxVendedor_SelectedIndexChanged);
            // 
            // bsVendedor
            // 
            this.bsVendedor.DataMember = "vVendedores";
            this.bsVendedor.DataSource = this.dsSistemaTarjetas;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(354, 47);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(91, 20);
            this.dtpFecha.TabIndex = 9;
            // 
            // btnGuardar
            // 
            this.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGuardar.Location = new System.Drawing.Point(15, 122);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 34);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(116, 122);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 34);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // vClientesTableAdapter
            // 
            this.vClientesTableAdapter.ClearBeforeFill = true;
            // 
            // vZonaTableAdapter
            // 
            this.vZonaTableAdapter.ClearBeforeFill = true;
            // 
            // vVendedoresTableAdapter
            // 
            this.vVendedoresTableAdapter.ClearBeforeFill = true;
            // 
            // FTarjetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 185);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cbxVendedor);
            this.Controls.Add(this.cbxFormaPago);
            this.Controls.Add(this.cbxZona);
            this.Controls.Add(this.cbxCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FTarjetas";
            this.Text = "Insertar/Editar Tarjeta";
            this.Load += new System.EventHandler(this.FTarjetas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistemaTarjetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsZona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVendedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.ComboBox cbxZona;
        private System.Windows.Forms.ComboBox cbxFormaPago;
        private System.Windows.Forms.ComboBox cbxVendedor;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.BindingSource bsCliente;
        private dsSistemaTarjetas dsSistemaTarjetas;
        private System.Windows.Forms.BindingSource bsVendedor;
        private System.Windows.Forms.BindingSource bsZona;
        private dsSistemaTarjetasTableAdapters.vClientesTableAdapter vClientesTableAdapter;
        private dsSistemaTarjetasTableAdapters.vZonaTableAdapter vZonaTableAdapter;
        private dsSistemaTarjetasTableAdapters.vVendedoresTableAdapter vVendedoresTableAdapter;
        private dsSistemaTarjetasTableAdapters.QueriesTableAdapter queriesTableAdapter1;
    }
}