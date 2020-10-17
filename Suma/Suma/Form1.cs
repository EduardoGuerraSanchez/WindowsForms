using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            texto1.Text = "";
            texto2.Text = "";
            textoResultado.Text = "";
        }

        private void resultado_Click(object sender, EventArgs e)
        {
            double a = 0;
            double b = 0;
            double res = 0;

            a = double.Parse(texto1.Text);
            b = double.Parse(texto2.Text);
            res = a + b;
            textoResultado.Text = res.ToString();
        }
    }
}
