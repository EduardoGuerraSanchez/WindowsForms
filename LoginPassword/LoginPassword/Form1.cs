using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPassword
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void iniciar_Click(object sender, EventArgs e)
        {
            bool log = false;
            bool pass = false;
            String login = "edu";
            String password = "contraseña";
            if (textoLogin.Text == login)
            {
                log = true;
            }

            if(textoPassword.Text == password)
            {
                pass = true;
            }

            if( log == true && pass == true)
            {
                textoBienvenido.Text = "Bienvenido";
            }
            else
            {
                textoBienvenido.Text = "Error, vuelve a introducir los datos";
            }

        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            textoLogin.Text = "";
            textoPassword.Text = "";
            textoBienvenido.Text = "";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
