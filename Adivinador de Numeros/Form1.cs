using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adivinador_de_Numeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int contador_oportunidades = 0;
        int oportunidades = 5;

        private void Form1_Load(object sender, EventArgs e)
        {
            generadorNumero();
        }
        private void generadorNumero()
        {
            Random numero = new Random();
            label3.Text = numero.Next(1, 100).ToString();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contador_oportunidades = contador_oportunidades + 1;
            int opo = oportunidades - contador_oportunidades;
            int a = Convert.ToInt32(label3.Text);
            int b = Convert.ToInt32(textBox1.Text);
            if (contador_oportunidades < 10)
            {
                //MessageBox.Show("todavia hay oportunidad");
                if (a == b)
                {
                    MessageBox.Show("Correcto, adivinaste el número en tu intento número " + contador_oportunidades.ToString());
                }
                else {
                    if (a > b)
                    {
                        MessageBox.Show("error, el número introducido es menor, no es correcto tienes " + opo.ToString() + " oportunidades más");
                        textBox1.Clear();
                        textBox1.Focus();
                    }
                    else {
                        MessageBox.Show("error, el número introducido es mayor, no es correcto tienes " + opo.ToString() + " oportunidades más");
                        textBox1.Clear();
                        textBox1.Focus();
                    }
                }
            }
            else {
                MessageBox.Show("lo siento se te acabaron las oportunidades, el número era "+label3.Text);
            }

        }
    }
}
