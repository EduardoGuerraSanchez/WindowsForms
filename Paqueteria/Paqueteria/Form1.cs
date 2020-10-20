using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paqueteria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float correoPrecio = 2.50F;
            float normalPrecio = 3.50F;
            float urgentePrecio = 5.00F;
            float pedido = 17.80F;
            float res = 0.00F;

            if (comboBox1.SelectedIndex == 0)
            {
                res = pedido - correoPrecio;

            }
            if (comboBox1.SelectedIndex == 1)
            {
                res = pedido - normalPrecio;
            }
            if (comboBox1.SelectedIndex== 2)
            {
                res = pedido - urgentePrecio;
            }
            textBox1.Text = res.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
