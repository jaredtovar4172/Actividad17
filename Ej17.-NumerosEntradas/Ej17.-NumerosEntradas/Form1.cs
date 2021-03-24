using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej17._NumerosEntradas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PositivoNegativo x = new PositivoNegativo();
            int numero = int.Parse(textBox1.Text);
            string cadena = x.CuentaNumeros(numero);
            MessageBox.Show(cadena, "Positivos, Negativos, Ceros", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
