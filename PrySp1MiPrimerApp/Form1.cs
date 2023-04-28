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
    public partial class Form1 : Form
    {
        //declaracion de variables
        decimal varAlquiler=0;
        decimal varImpuesto = 0;
        decimal varDeposito = 0;
        decimal varComida = 0;
        decimal varMonto = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            varAlquiler = Convert.ToDecimal(txtAlquiler.Text);
            varComida = Convert.ToDecimal(txtComida.Text);
            varImpuesto = Convert.ToDecimal(txtImpuesto.Text);
            varDeposito= Convert.ToDecimal(txtDeposito.Text);

            varMonto = varDeposito - (varComida + varAlquiler + varImpuesto);

            txtMonto.Text = varMonto.ToString();

            //concatenar-Unir texto
            label4.Text = "Alquiler \n" + varAlquiler.ToString() + "Deposito \n" + varDeposito.ToString() + "Comida \n" + varComida.ToString() + "Impuesto \n" + varImpuesto.ToString() + "Monto \n" + varMonto.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
