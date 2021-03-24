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
    public partial class DialogBoxCaptura : Form
    {
        public DialogBoxCaptura()
        {
            InitializeComponent();
        }
        public string numero
        {
            get
            {
                return (textBox1.Text);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void DialogBoxCaptura_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
        }
    }
}
