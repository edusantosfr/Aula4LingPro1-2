using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula3lp
{
    public partial class Form1 : Form
    {
        double bas = 0, alt = 0, raio = 0, basma = 0, basme = 0, resu = 0;
        double graus, celsius, far;
        
        //ex1
        private void buttonResposta_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedIndex == 0)
            {
                textBoxBase.Enabled = true;
                textBoxAltura.Enabled = true;

                textBoxRaio.Enabled = false;
                textBoxBaseMaior.Enabled = false;
                textBoxBaseMenor.Enabled = false;
            }

            if (comboBox1.SelectedIndex == 1)
            {
                textBoxBase.Enabled = false;
                textBoxBase.Clear();
                textBoxAltura.Enabled = false;
                textBoxAltura.Clear();

                textBoxRaio.Enabled = true;

                textBoxBaseMaior.Enabled = false;
                textBoxBaseMenor.Enabled = false;
            }

            if (comboBox1.SelectedIndex == 2)
            {
                textBoxBase.Enabled = false;

                textBoxAltura.Enabled = true;

                textBoxRaio.Enabled = false;
                textBoxRaio.Clear();

                textBoxBaseMaior.Enabled = true;
                textBoxBaseMenor.Enabled = true;
            }

            if (comboBox1.SelectedIndex == 3)
            {
                textBoxBase.Enabled = true;
                textBoxAltura.Clear();
                textBoxAltura.Enabled = true;
                textBoxRaio.Enabled = false;
                textBoxBaseMaior.Enabled = false;
                textBoxBaseMaior.Clear();
                textBoxBaseMenor.Enabled = false;
                textBoxBaseMenor.Clear();
            }
        }

        private void textBoxBase_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxAltura_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRaio_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxBaseMaior_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonRespostaG_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {   
                far = double.Parse(textBoxGraus.Text);

                graus = (far * 9 / 5) + 32;

                MessageBox.Show(graus + "F", "RESULTADO");
            }

            if (comboBox2.SelectedIndex == 1)
            {
                celsius = double.Parse(textBoxGraus.Text);

                graus = (celsius - 32) * 5 / 9;

                MessageBox.Show(graus + "G", "RESULTADO");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void textBoxBaseMenor_TextChanged(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                bas = double.Parse(textBoxBase.Text);
                alt = double.Parse(textBoxAltura.Text);

                resu = bas * alt;

                MessageBox.Show(" A área do seu retângulo é de: " + resu.ToString() + ".", "RESULTADO");
            }

            if (comboBox2.SelectedIndex == 1)
            {
                raio = double.Parse(textBoxRaio.Text);
                resu = (Math.Pow(raio,2) * 3.14);

                MessageBox.Show(" A área do seu circulo é de: " + resu.ToString() + ".", "RESULTADO");
            }
               
            if (comboBox1.SelectedIndex == 2)
            {
                basma = double.Parse(textBoxBaseMaior.Text);
                basme = double.Parse(textBoxBaseMenor.Text);
                alt = double.Parse(textBoxAltura.Text);

                resu = (basma + basme) * alt / 2;

                MessageBox.Show(" A área do seu trapézio é de: " + resu.ToString() + ".", "RESULTADO");
            }

            if (comboBox1.SelectedIndex == 3)
            {
                bas = double.Parse(textBoxBase.Text);
                alt = double.Parse(textBoxAltura.Text);

                resu = (1 / 2 * bas * alt) * 5;

                MessageBox.Show(" A área do seu pentágono é de: " + resu.ToString() + ".", "RESULTADO");
            }
        }
    }
}
