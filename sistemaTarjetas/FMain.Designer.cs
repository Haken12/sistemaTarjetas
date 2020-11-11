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
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventanasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlLateral = new System.Windows.Forms.Panel();
            this.pnlVendedores = new System.Windows.Forms.Panel();
            this.btnDevolucion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnControlTarjetas = new System.Windows.Forms.Button();
            this.btnZona = new System.Windows.Forms.Button();
            this.btnVendedor = new System.Windows.Forms.Button();
            this.btnAyudantes = new System.Windows.Forms.Button();
            this.btnVendedores = new System.Windows.Forms.Button();
            this.pnlInventario = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnArticulos = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnlLateral.SuspendLayout();
            this.pnlVendedores.SuspendLayout();
            this.pnlInventario.SuspendLayout();
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
            this.panelTop.Size = new System.Drawing.Size(800, 29);
            this.panelTop.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.registrosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.ventanasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(91, 22);
            this.verToolStripMenuItem.Text = "Ver";
            this.verToolStripMenuItem.Click += new System.EventHandler(this.verToolStripMenuItem_Click);
            // 
            // ventanasToolStripMenuItem
            // 
            this.ventanasToolStripMenuItem.Name = "ventanasToolStripMenuItem";
            this.ventanasToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ventanasToolStripMenuItem.Text = "Ventanas";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // pnlLateral
            // 
            this.pnlLateral.Controls.Add(this.pnlVendedores);
            this.pnlLateral.Controls.Add(this.btnVendedores);
            this.pnlLateral.Controls.Add(this.pnlInventario);
            this.pnlLateral.Controls.Add(this.btnInventario);
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLateral.Location = new System.Drawing.Point(0, 29);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(175, 399);
            this.pnlLateral.TabIndex = 2;
            this.pnlLateral.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLateral_Paint);
            // 
            // pnlVendedores
            // 
            this.pnlVendedores.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlVendedores.Controls.Add(this.btnDevolucion);
            this.pnlVendedores.Controls.Add(this.button1);
            this.pnlVendedores.Controls.Add(this.btnControlTarjetas);
            this.pnlVendedores.Controls.Add(this.btnZona);
            this.pnlVendedores.Controls.Add(this.btnVendedor);
            this.pnlVendedores.Controls.Add(this.btnAyudantes);
            this.pnlVendedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlVendedores.Location = new System.Drawing.Point(0, 115);
            this.pnlVendedores.Name = "pnlVendedores";
            this.pnlVendedores.Size = new System.Drawing.Size(175, 140);
            this.pnlVendedores.TabIndex = 3;
            this.pnlVendedores.Visible = false;
            // 
            // btnDevolucion
            // 
            this.btnDevolucion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnDevolucion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDevolucion.FlatAppearance.BorderSize = 0;
            this.btnDevolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevolucion.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDevolucion.Location = new System.Drawing.Point(0, 115);
            this.btnDevolucion.Name = "btnDevolucion";
            this.btnDevolucion.Size = new System.Drawing.Size(175, 23);
            this.btnDevolucion.TabIndex = 5;
            this.btnDevolucion.Text = "   Devolucion de Vendedores";
            this.btnDevolucion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDevolucion.UseVisualStyleBackColor = false;
            this.btnDevolucion.Click += new System.EventHandler(this.btnDevolucion_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(0, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "   Despacho a Vendedores";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnControlTarjetas
            // 
            this.btnControlTarjetas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnControlTarjetas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnControlTarjetas.FlatAppearance.BorderSize = 0;
            this.btnControlTarjetas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControlTarjetas.ForeColor = System.Drawing.SystemColors.Control;
            this.btnControlTarjetas.Location = new System.Drawing.Point(0, 69);
            this.btnControlTarjetas.Name = "btnControlTarjetas";
            this.btnControlTarjetas.Size = new System.Drawing.Size(175, 23);
            this.btnControlTarjetas.TabIndex = 3;
            this.btnControlTarjetas.Text = "   Control de Tarjetas";
            this.btnControlTarjetas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnControlTarjetas.UseVisualStyleBackColor = false;
            this.btnControlTarjetas.Click += new System.EventHandler(this.btnControlTarjetas_Click);
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
            this.btnZona.Size = new System.Drawing.Size(175, 23);
            this.btnZona.TabIndex = 2;
            this.btnZona.Text = "   Zonas";
            this.btnZona.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZona.UseVisualStyleBackColor = false;
            this.btnZona.Click += new System.EventHandler(this.btnZona_Click);
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
            this.btnVendedor.Size = new System.Drawing.Size(175, 23);
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
            this.btnAyudantes.Size = new System.Drawing.Size(175, 23);
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
            this.btnVendedores.Location = new System.Drawing.Point(0, 92);
            this.btnVendedores.Name = "btnVendedores";
            this.btnVendedores.Size = new System.Drawing.Size(175, 23);
            this.btnVendedores.TabIndex = 2;
            this.btnVendedores.Text = "Vendedores";
            this.btnVendedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVendedores.UseVisualStyleBackColor = false;
            this.btnVendedores.Click += new System.EventHandler(this.btnVendedores_Click);
            // 
            // pnlInventario
            // 
            this.pnlInventario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlInventario.Controls.Add(this.button2);
            this.pnlInventario.Controls.Add(this.btnArticulos);
            this.pnlInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInventario.Location = new System.Drawing.Point(0, 23);
            this.pnlInventario.Name = "pnlInventario";
            this.pnlInventario.Size = new System.Drawing.Size(175, 69);
            this.pnlInventario.TabIndex = 1;
            this.pnlInventario.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(0, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "   Ajuste de Inventario";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnArticulos
            // 
            this.btnArticulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnArticulos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnArticulos.FlatAppearance.BorderSize = 0;
            this.btnArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArticulos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnArticulos.Location = new System.Drawing.Point(0, 0);
            this.btnArticulos.Name = "btnArticulos";
            this.btnArticulos.Size = new System.Drawing.Size(175, 23);
            this.btnArticulos.TabIndex = 1;
            this.btnArticulos.Text = "   Articulos";
            this.btnArticulos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArticulos.UseVisualStyleBackColor = false;
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInventario.Location = new System.Drawing.Point(0, 0);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(175, 23);
            this.btnInventario.TabIndex = 0;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.UseVisualStyleBackColor = false;
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlLateral.ResumeLayout(false);
            this.pnlVendedores.ResumeLayout(false);
            this.pnlInventario.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventanasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.Button btnControlTarjetas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnArticulos;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.Button btnDevolucion;
    }
}

