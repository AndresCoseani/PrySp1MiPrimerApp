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
    public partial class Form2Alacena : Form
    {
        //declaracion de Variables
        String varLugar, varProducto;

        int varCantidad;

        DateTime varFechaDeVencimiento;
            

        public Form2Alacena()
        {
            InitializeComponent();
        }

        private void Form2Alacena_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
            varLugar = cboLugar.Text;
            varProducto = cboProductos .Text;
            varCantidad = Convert.ToInt32 (nudCantidad.Value);
            varFechaDeVencimiento = dtpFechaDeVencimiento.Value;

            lstProductosIngresados.Items.Add ( " " + varLugar + " " + varProducto + " " + varCantidad + " " + varFechaDeVencimiento );

            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {

        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
