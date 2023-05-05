using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrySp1MiPrimerApp
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2Alacena VentanaAlacena = new Form2Alacena();
            VentanaAlacena.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1GestionDeGastos VentanaIngreso = new Form1GestionDeGastos();
            VentanaIngreso.ShowDialog();

        }
    }
}
