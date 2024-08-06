using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp10_Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double operacion = 0;

            if (radioButton1.Checked)
            {
                operacion = double.Parse(textBox2.Text + textBox2.Text);
                label2.Text = operacion.ToString();
            }else if(radioButton2.Checked)
            {
                operacion = double.Parse(textBox2.Text + textBox2.Text);
                label2.Text = operacion.ToString();
            }
            else
            {
                label2.Text = "Ingrese un valor valido.";
            }
        }
    }
}
