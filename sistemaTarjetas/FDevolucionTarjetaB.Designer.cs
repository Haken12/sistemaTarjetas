
namespace sistemaTarjetas
{
    partial class FDevolucionTarjetaB
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
            this.txtTarjeta = new System.Windows.Forms.TextBox();
            this.txtNombreV = new System.Windows.Forms.TextBox();
            this.txtNombreT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtNombreA = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVenta = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.bsVenta = new System.Windows.Forms.BindingSource(this.components);
            this.dsDevoluciones = new sistemaTarjetas.dsDevoluciones();
            this.datosVentaTableAdapter = new sistemaTarjetas.dsDevolucionesTableAdapters.datosVentaTableAdapter();
            this.txtActual = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDevoluciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tarjeta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vendedor";
            // 
            // txtTarjeta
            // 
            this.txtTarjeta.BackColor = System.Drawing.SystemColors.Info;
            this.txtTarjeta.Location = new System.Drawing.Point(76, 46);
            this.txtTarjeta.Name = "txtTarjeta";
            this.txtTarjeta.ReadOnly = true;
            this.txtTarjeta.Size = new System.Drawing.Size(75, 20);
            this.txtTarjeta.TabIndex = 3;
            // 
            // txtNombreV
            // 
            this.txtNombreV.BackColor = System.Drawing.SystemColors.Info;
            this.txtNombreV.Location = new System.Drawing.Point(162, 79);
            this.txtNombreV.Name = "txtNombreV";
            this.txtNombreV.ReadOnly = true;
            this.txtNombreV.Size = new System.Drawing.Size(231, 20);
            this.txtNombreV.TabIndex = 4;
            // 
            // txtNombreT
            // 
            this.txtNombreT.BackColor = System.Drawing.SystemColors.Info;
            this.txtNombreT.Location = new System.Drawing.Point(162, 46);
            this.txtNombreT.Name = "txtNombreT";
            this.txtNombreT.ReadOnly = true;
            this.txtNombreT.Size = new System.Drawing.Size(231, 20);
            this.txtNombreT.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Articulo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cantidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Precio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(323, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Monto";
            // 
            // txtVendedor
            // 
            this.txtVendedor.BackColor = System.Drawing.SystemColors.Info;
            this.txtVendedor.Location = new System.Drawing.Point(76, 79);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.ReadOnly = true;
            this.txtVendedor.Size = new System.Drawing.Size(75, 20);
            this.txtVendedor.TabIndex = 10;
            // 
            // txtArticulo
            // 
            this.txtArticulo.Location = new System.Drawing.Point(76, 108);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(63, 20);
            this.txtArticulo.TabIndex = 11;
            this.txtArticulo.TextChanged += new System.EventHandler(this.txtArticulo_TextChanged);
            this.txtArticulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(76, 145);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(48, 20);
            this.txtCantidad.TabIndex = 12;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(259, 145);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(58, 20);
            this.txtPrecio.TabIndex = 13;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // txtMonto
            // 
            this.txtMonto.BackColor = System.Drawing.SystemColors.Info;
            this.txtMonto.Location = new System.Drawing.Point(366, 145);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.ReadOnly = true;
            this.txtMonto.Size = new System.Drawing.Size(58, 20);
            this.txtMonto.TabIndex = 14;
            // 
            // txtNombreA
            // 
            this.txtNombreA.BackColor = System.Drawing.SystemColors.Info;
            this.txtNombreA.Location = new System.Drawing.Point(185, 108);
            this.txtNombreA.Name = "txtNombreA";
            this.txtNombreA.Size = new System.Drawing.Size(239, 20);
            this.txtNombreA.TabIndex = 16;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(15, 176);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 17;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(104, 176);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Venta";
            // 
            // txtVenta
            // 
            this.txtVenta.BackColor = System.Drawing.SystemColors.Info;
            this.txtVenta.Location = new System.Drawing.Point(76, 15);
            this.txtVenta.Name = "txtVenta";
            this.txtVenta.ReadOnly = true;
            this.txtVenta.Size = new System.Drawing.Size(75, 20);
            this.txtVenta.TabIndex = 20;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::sistemaTarjetas.Recursos._49;
            this.btnBuscar.Location = new System.Drawing.Point(145, 104);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(34, 27);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            // txtActual
            // 
            this.txtActual.BackColor = System.Drawing.SystemColors.Info;
            this.txtActual.Enabled = false;
            this.txtActual.Location = new System.Drawing.Point(131, 145);
            this.txtActual.Name = "txtActual";
            this.txtActual.ReadOnly = true;
            this.txtActual.Size = new System.Drawing.Size(48, 20);
            this.txtActual.TabIndex = 21;
            // 
            // FDevolucionTarjetaB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 211);
            this.ControlBox = false;
            this.Controls.Add(this.txtActual);
            this.Controls.Add(this.txtVenta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtNombreA);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtArticulo);
            this.Controls.Add(this.txtVendedor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombreT);
            this.Controls.Add(this.txtNombreV);
            this.Controls.Add(this.txtTarjeta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FDevolucionTarjetaB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devolucion de mercancia en tarjeta";
            this.Load += new System.EventHandler(this.FDevolucionTarjetaB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDevoluciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTarjeta;
        private System.Windows.Forms.TextBox txtNombreV;
        private System.Windows.Forms.TextBox txtNombreT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.TextBox txtArticulo;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNombreA;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.BindingSource bsVenta;
        private dsDevoluciones dsDevoluciones;
        private dsDevolucionesTableAdapters.datosVentaTableAdapter datosVentaTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVenta;
        private System.Windows.Forms.TextBox txtActual;
    }
}