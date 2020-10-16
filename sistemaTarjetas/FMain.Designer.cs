namespace sistemaTarjetas
{
    partial class FMain
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panelTop = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pnlLateral = new System.Windows.Forms.Panel();
            this.pnlVendedores = new System.Windows.Forms.Panel();
            this.btnZona = new System.Windows.Forms.Button();
            this.btnVendedor = new System.Windows.Forms.Button();
            this.btnAyudantes = new System.Windows.Forms.Button();
            this.btnVendedores = new System.Windows.Forms.Button();
            this.pnlInventario = new System.Windows.Forms.Panel();
            this.btnInventario = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.pnlLateral.SuspendLayout();
            this.pnlVendedores.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.menuStrip1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 60);
            this.panelTop.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pnlLateral
            // 
            this.pnlLateral.Controls.Add(this.pnlVendedores);
            this.pnlLateral.Controls.Add(this.btnVendedores);
            this.pnlLateral.Controls.Add(this.pnlInventario);
            this.pnlLateral.Controls.Add(this.btnInventario);
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLateral.Location = new System.Drawing.Point(0, 60);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(123, 368);
            this.pnlLateral.TabIndex = 2;
            // 
            // pnlVendedores
            // 
            this.pnlVendedores.Controls.Add(this.btnZona);
            this.pnlVendedores.Controls.Add(this.btnVendedor);
            this.pnlVendedores.Controls.Add(this.btnAyudantes);
            this.pnlVendedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlVendedores.Location = new System.Drawing.Point(0, 127);
            this.pnlVendedores.Name = "pnlVendedores";
            this.pnlVendedores.Size = new System.Drawing.Size(123, 81);
            this.pnlVendedores.TabIndex = 3;
            this.pnlVendedores.Visible = false;
            // 
            // btnZona
            // 
            this.btnZona.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnZona.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnZona.FlatAppearance.BorderSize = 0;
            this.btnZona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZona.ForeColor = System.Drawing.SystemColors.Control;
            this.btnZona.Location = new System.Drawing.Point(0, 46);
            this.btnZona.Name = "btnZona";
            this.btnZona.Size = new System.Drawing.Size(123, 23);
            this.btnZona.TabIndex = 2;
            this.btnZona.Text = "   Zonas";
            this.btnZona.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZona.UseVisualStyleBackColor = false;
            // 
            // btnVendedor
            // 
            this.btnVendedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnVendedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVendedor.FlatAppearance.BorderSize = 0;
            this.btnVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendedor.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVendedor.Location = new System.Drawing.Point(0, 23);
            this.btnVendedor.Name = "btnVendedor";
            this.btnVendedor.Size = new System.Drawing.Size(123, 23);
            this.btnVendedor.TabIndex = 1;
            this.btnVendedor.Text = "   Vendedores";
            this.btnVendedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVendedor.UseVisualStyleBackColor = false;
            this.btnVendedor.Click += new System.EventHandler(this.btnVendedor_Click);
            // 
            // btnAyudantes
            // 
            this.btnAyudantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAyudantes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAyudantes.FlatAppearance.BorderSize = 0;
            this.btnAyudantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyudantes.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAyudantes.Location = new System.Drawing.Point(0, 0);
            this.btnAyudantes.Name = "btnAyudantes";
            this.btnAyudantes.Size = new System.Drawing.Size(123, 23);
            this.btnAyudantes.TabIndex = 0;
            this.btnAyudantes.Text = "   Ayudantes";
            this.btnAyudantes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyudantes.UseVisualStyleBackColor = false;
            this.btnAyudantes.Click += new System.EventHandler(this.btnAyudantes_Click);
            // 
            // btnVendedores
            // 
            this.btnVendedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnVendedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVendedores.FlatAppearance.BorderSize = 0;
            this.btnVendedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendedores.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVendedores.Location = new System.Drawing.Point(0, 104);
            this.btnVendedores.Name = "btnVendedores";
            this.btnVendedores.Size = new System.Drawing.Size(123, 23);
            this.btnVendedores.TabIndex = 2;
            this.btnVendedores.Text = "Vendedores";
            this.btnVendedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVendedores.UseVisualStyleBackColor = false;
            this.btnVendedores.Click += new System.EventHandler(this.btnVendedores_Click);
            // 
            // pnlInventario
            // 
            this.pnlInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInventario.Location = new System.Drawing.Point(0, 23);
            this.pnlInventario.Name = "pnlInventario";
            this.pnlInventario.Size = new System.Drawing.Size(123, 81);
            this.pnlInventario.TabIndex = 1;
            this.pnlInventario.Visible = false;
            // 
            // btnInventario
            // 
            this.btnInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventario.Location = new System.Drawing.Point(0, 0);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(123, 23);
            this.btnInventario.TabIndex = 0;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlLateral);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla Principal";
            this.Load += new System.EventHandler(this.FMain_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.pnlLateral.ResumeLayout(false);
            this.pnlVendedores.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel pnlLateral;
        private System.Windows.Forms.Panel pnlInventario;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Panel pnlVendedores;
        private System.Windows.Forms.Button btnZona;
        private System.Windows.Forms.Button btnVendedor;
        private System.Windows.Forms.Button btnAyudantes;
        private System.Windows.Forms.Button btnVendedores;
    }
}

