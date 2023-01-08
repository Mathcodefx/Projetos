using System;
using System.Globalization;
using System.Collections;

namespace calculadora2
{

    public partial class Calculadora : Form
    {


        public Calculadora()
        {
            InitializeComponent();
        }


        decimal valor1 = 0;
        decimal valor2 = 0;
        String soma = "";
        String num = "";



        /* comando basico */

        private void button10_Click(object sender, EventArgs e)
        {
            textBox.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox.Text += "7";
        }

        private void ponto_Click(object sender, EventArgs e)
        {
            textBox.Text += ".";
        }

        private void num3_Click(object sender, EventArgs e)
        {
            textBox.Text += "3";
        }

        private void num2_Click(object sender, EventArgs e)
        {
            textBox.Text += "2";
        }

        private void num1_Click(object sender, EventArgs e)
        {
            textBox.Text += "1";
        }

        private void num6_Click(object sender, EventArgs e)
        {
            textBox.Text += "6";
        }

        private void num5_Click(object sender, EventArgs e)
        {
            textBox.Text += "5";
        }

        private void num4_Click(object sender, EventArgs e)
        {
            textBox.Text += "4";
        }

        private void num9_Click(object sender, EventArgs e)
        {
            textBox.Text += "9";
        }

        private void num8_Click(object sender, EventArgs e)
        {
            textBox.Text += "8";
        }

        private void numplus_Click(object sender, EventArgs e)
        {
            num = textBox.Text;
            soma = "+";

            /*if para não dar bug caso o operador seja digitado antes */
            if (num != "")
            {
             valor1 = decimal.Parse(textBox.Text, CultureInfo.InvariantCulture);
             textBox.Text = "";
            }
            else
            textBox.Text = "";
            operacao.Text = "+";


        }

        private void numless_Click(object sender, EventArgs e)
        {
            num = textBox.Text;
            soma = "-";

            /*if para não dar bug caso o operador seja digitado antes */
            if (num != "")
            {
             valor1 = decimal.Parse(textBox.Text, CultureInfo.InvariantCulture);
             textBox.Text = "";
            }
            else
            textBox.Text = "";
            operacao.Text = "-";
        }

        private void divisao_Click(object sender, EventArgs e)
        {
            num = textBox.Text;
            soma = "÷";

            /*if para não dar bug caso o operador seja digitado antes */
            if (num != "")
            {
             valor1 = decimal.Parse(textBox.Text, CultureInfo.InvariantCulture);
             textBox.Text = "";
            }
            else
            textBox.Text = "";
            operacao.Text = "÷";


        }

        private void multiplicacao_Click(object sender, EventArgs e)
        {
            num = textBox.Text;
            soma = "x";

            /*if para não dar bug caso o operador seja digitado antes */
            if (num != "")
            {
             valor1 = decimal.Parse(textBox.Text, CultureInfo.InvariantCulture);
             textBox.Text = "";
            }
            else
            textBox.Text = "";
            operacao.Text = "x";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /* logica para os resultados */
            valor2 = decimal.Parse(textBox.Text, CultureInfo.InvariantCulture);
            if (soma == "+")
            {
                textBox.Text = Convert.ToString(valor1 + valor2);
            }
            else if (soma == "-")
            {
                textBox.Text = Convert.ToString(valor1 - valor2);
            }
            else if (soma == "x")
            {
                textBox.Text = Convert.ToString(valor1 * valor2);
            }
            else if (soma == "÷")
            {
                textBox.Text = Convert.ToString(valor1 / valor2);
            } 
            else textBox.Text = "";

        }

   

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbloperacao(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            operacao.Text = "";
            valor1 = 0;
            valor2 = 0;
        }
    }
}