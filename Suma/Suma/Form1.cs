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

        private void res_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;
            int res = 0;

            a = int.Parse(texto1.Text);
            b = int.Parse(texto2.Text);
            res = a + b;
            textoResultado.Text = res.ToString();

        }
    }
}
