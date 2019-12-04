using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1RodriguezAlejandro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void brnCalcular_Click(object sender, EventArgs e)
        {
            int limite = 0, suma = 0;
            limite = int.Parse(this.txtEntero.Text);
            suma = Clases.Examen.sumatoria(limite);
            this.txtPrimo.Text = suma.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



