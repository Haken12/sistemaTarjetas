﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaTarjetas
{
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
        }

        private void FMain_Load(object sender, EventArgs e)
        {

        }

      

        private void btnVendedores_Click(object sender, EventArgs e)
        {
            if (pnlVendedores.Visible == true) 
            {
                pnlVendedores.Visible = false;
            }
            else { pnlVendedores.Visible = true; }
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            if (pnlInventario.Visible == true)
            {
                pnlInventario.Visible = false;
            }
            else { pnlInventario.Visible = true; }
        }

        private void btnAyudantes_Click(object sender, EventArgs e)
        {
            FRegAyudantes fRegAyudantes = new FRegAyudantes();
            fRegAyudantes.ShowDialog();
        }

        private void btnVendedor_Click(object sender, EventArgs e)
        {
            FRegVendedores fRegVendedores = new FRegVendedores();
            fRegVendedores.ShowDialog();
        }

        private void btnControlTarjetas_Click(object sender, EventArgs e)
        {
            FControlTarjetas fControlTarjetas = new FControlTarjetas();
            fControlTarjetas.ShowDialog();
        }

        private void btnZona_Click(object sender, EventArgs e)
        {
            FRegZonas fRegZonas = new FRegZonas();
            fRegZonas.ShowDialog();
        }

        private void pnlLateral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FDespachoVendedores fDespacho = new FDespachoVendedores();
            fDespacho.ShowDialog();
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDevolucion_Click(object sender, EventArgs e)
        {
            FDevolucionVendedor fDevolucion = new FDevolucionVendedor();
            fDevolucion.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            FRegistroArticulos fArticulos = new FRegistroArticulos();
            fArticulos.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnAjusteInventario_Click(object sender, EventArgs e)
        {
            FAjustarInventario fAjustar = new FAjustarInventario();
            fAjustar.ShowDialog();
        }

        private void articulosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FArticulos fArticulos = new FArticulos();
            fArticulos.ShowDialog();
        }
    }
}
