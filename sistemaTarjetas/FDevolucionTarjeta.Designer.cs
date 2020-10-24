namespace sistemaTarjetas
{
    partial class FDevolucionTarjeta
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
            this.dgvActuales = new System.Windows.Forms.DataGridView();
            this.dgvDevolver = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActuales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolver)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvActuales
            // 
            this.dgvActuales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActuales.Location = new System.Drawing.Point(23, 66);
            this.dgvActuales.Name = "dgvActuales";
            this.dgvActuales.Size = new System.Drawing.Size(348, 232);
            this.dgvActuales.TabIndex = 0;
            // 
            // dgvDevolver
            // 
            this.dgvDevolver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevolver.Location = new System.Drawing.Point(377, 66);
            this.dgvDevolver.Name = "dgvDevolver";
            this.dgvDevolver.Size = new System.Drawing.Size(361, 232);
            this.dgvDevolver.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Articulos Actuales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(505, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Articulos a devolver";
            // 
            // FDevolucionTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 427);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDevolver);
            this.Controls.Add(this.dgvActuales);
            this.Name = "FDevolucionTarjeta";
            this.Text = "Devolucion de articulos vendidos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvActuales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevolver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvActuales;
        private System.Windows.Forms.DataGridView dgvDevolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}