﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumaDe1AN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int res = 0;
            List<string> lista = new List<string>();
            int contador = 0;
            for ( contador = 0; contador <= int.Parse(numero.Text); contador++)
            {
                res += contador;
                lista.Add(res.ToString());

            }

            if (check.Checked == true)
            {
                listBox1.DataSource = null;
                listBox1.DataSource = lista;                
            }
        }

        private void numero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
