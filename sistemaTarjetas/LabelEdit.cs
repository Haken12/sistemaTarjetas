using System;
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
    public partial class LabelEdit : UserControl
    {
        public LabelEdit()
        {
            InitializeComponent();
        }

        public string LabelText
        { 
            get { return this.label1.Text; }
            set { this.label1.Text = value; }
        }

        public string InnerText
        {
            get { return this.textBox1.Text; }
            set { this.textBox1.Text = value; }
        }

        private void label1_Resize(object sender, EventArgs e)
        {
          
        }

        private void LabelEdit_Resize(object sender, EventArgs e)
        {
            this.label1.Width = this.Width - 20;
        }
    }

   
}
