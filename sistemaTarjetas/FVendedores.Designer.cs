namespace sistemaTarjetas
{
    partial class FVendedores
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.mtxtCelular = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCedula = new System.Windows.Forms.MaskedTextBox();
            this.mtxtDeduccion = new System.Windows.Forms.MaskedTextBox();
            this.mtxtComision = new System.Windows.Forms.MaskedTextBox();
            this.cbxAyudante = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cedula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Deduccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Comision";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Celular";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(323, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Direccion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(323, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Telefono";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(323, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ayudante";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Fecha de Ingreso";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(117, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(399, 29);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(189, 20);
            this.txtDireccion.TabIndex = 10;
            // 
            // mtxtCelular
            // 
            this.mtxtCelular.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mtxtCelular.Location = new System.Drawing.Point(117, 103);
            this.mtxtCelular.Mask = "000-000-0000";
            this.mtxtCelular.Name = "mtxtCelular";
            this.mtxtCelular.PromptChar = '0';
            this.mtxtCelular.Size = new System.Drawing.Size(100, 20);
            this.mtxtCelular.TabIndex = 11;
            // 
            // mtxtTelefon
            // 
            this.mtxtTelefon.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mtxtTelefon.Location = new System.Drawing.Point(399, 73);
            this.mtxtTelefon.Mask = "000-000-0000";
            this.mtxtTelefon.Name = "mtxtTelefon";
            this.mtxtTelefon.PromptChar = '0';
            this.mtxtTelefon.Size = new System.Drawing.Size(100, 20);
            this.mtxtTelefon.TabIndex = 12;
            // 
            // mtxtCedula
            // 
            this.mtxtCedula.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mtxtCedula.Location = new System.Drawing.Point(117, 70);
            this.mtxtCedula.Mask = "000-0000000-0";
            this.mtxtCedula.Name = "mtxtCedula";
            this.mtxtCedula.PromptChar = '0';
            this.mtxtCedula.Size = new System.Drawing.Size(100, 20);
            this.mtxtCedula.TabIndex = 13;
            // 
            // mtxtDeduccion
            // 
            this.mtxtDeduccion.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mtxtDeduccion.Location = new System.Drawing.Point(117, 139);
            this.mtxtDeduccion.Mask = "000.00";
            this.mtxtDeduccion.Name = "mtxtDeduccion";
            this.mtxtDeduccion.PromptChar = '0';
            this.mtxtDeduccion.Size = new System.Drawing.Size(100, 20);
            this.mtxtDeduccion.TabIndex = 14;
            // 
            // mtxtComision
            // 
            this.mtxtComision.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mtxtComision.Location = new System.Drawing.Point(399, 116);
            this.mtxtComision.Mask = "000.00";
            this.mtxtComision.Name = "mtxtComision";
            this.mtxtComision.PromptChar = '0';
            this.mtxtComision.Size = new System.Drawing.Size(100, 20);
            this.mtxtComision.TabIndex = 16;
            // 
            // cbxAyudante
            // 
            this.cbxAyudante.FormattingEnabled = true;
            this.cbxAyudante.Location = new System.Drawing.Point(399, 153);
            this.cbxAyudante.Name = "cbxAyudante";
            this.cbxAyudante.Size = new System.Drawing.Size(121, 21);
            this.cbxAyudante.TabIndex = 17;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(117, 169);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(118, 20);
            this.dtpFecha.TabIndex = 18;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(26, 225);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 32);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(160, 225);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 32);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 274);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cbxAyudante);
            this.Controls.Add(this.mtxtComision);
            this.Controls.Add(this.mtxtDeduccion);
            this.Controls.Add(this.mtxtCedula);
            this.Controls.Add(this.mtxtTelefon);
            this.Controls.Add(this.mtxtCelular);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FVendedores";
            this.Text = "FVendedores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.MaskedTextBox mtxtCelular;
        private System.Windows.Forms.MaskedTextBox mtxtTelefon;
        private System.Windows.Forms.MaskedTextBox mtxtCedula;
        private System.Windows.Forms.MaskedTextBox mtxtDeduccion;
        private System.Windows.Forms.MaskedTextBox mtxtComision;
        private System.Windows.Forms.ComboBox cbxAyudante;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}