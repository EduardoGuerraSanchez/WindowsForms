using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaquinaDeRefrescos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            float cocacola = 1.80F;
            float res = 0.00F;
            Form form = new Form2();

            if (float.Parse(dinero.Text) < cocacola)
            {
                form.Show();
            }
            else
            {

                res = float.Parse(dinero.Text) - cocacola;
                cambio.Text = res.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float fanta = 2.40F;
            float res = 0.00F;

            Form form = new Form2();

            if (float.Parse(dinero.Text) < fanta)
            {
                form.Show();
            }
            else
            {

                res = float.Parse(dinero.Text) - fanta;
                cambio.Text = res.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float heineken = 2.80F;
            float res = 0.00F;

            Form form = new Form2();

            if (float.Parse(dinero.Text) < heineken)
            {
                form.Show();
            }
            else
            {

                res = float.Parse(dinero.Text) - heineken;
                cambio.Text = res.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float agua = 5.20F;
            float res = 0.00F;

            Form form = new Form2();

            if (float.Parse(dinero.Text) < agua)
            {
                form.Show();
            }
            else
            {

                res = float.Parse(dinero.Text) - agua;
                cambio.Text = res.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            float monster = 2.00F;
            float res = 0.00F;

            Form form = new Form2();

            if (float.Parse(dinero.Text) < monster)
            {
                form.Show();
            }
            else
            {

                res = float.Parse(dinero.Text) - monster;
                cambio.Text = res.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            float jack = 8.50F;
            float res = 0.00F;

            Form form = new Form2();

            if (float.Parse(dinero.Text) < jack)
            {
                form.Show();
            }
            else
            {

                res = float.Parse(dinero.Text) - jack;
                cambio.Text = res.ToString();
            }
        }
    }
}
