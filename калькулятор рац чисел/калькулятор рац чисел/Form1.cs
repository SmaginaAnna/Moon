using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace калькулятор_рац_чисел
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void sum_Click(object sender, EventArgs e)
        {
            deistvie.Text = "+";
            Calculate(deistvie.Text);
        }

        private void umnog_Click(object sender, EventArgs e)
        {
            deistvie.Text = "*";
            Calculate(deistvie.Text);
        }

        private void del_Click(object sender, EventArgs e)
        {
            deistvie.Text = "/";
            Calculate(deistvie.Text);
        }

        private void minus_Click(object sender, EventArgs e)
        {
            deistvie.Text = "-";
            Calculate(deistvie.Text);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            ch1.Clear();
            ch2.Clear();
            z1.Clear();
            z2.Clear();
            otv.Clear();
        }

        private void Calculate(string znak)
        {
            int znam_1;
            int znam_2;
            int chisl_1 = Convert.ToInt32(ch2.Text);
            if (z1.Text == "")
                znam_1 = 1;
            else
                znam_1 = Convert.ToInt32(z1.Text);


            int chisl_2 = Convert.ToInt32(ch2.Text);
            if (z2.Text == "")
                znam_2 = 1;
            else
                znam_2 = Convert.ToInt32(z2.Text);

            Rational number1 = new Rational(chisl_1, znam_1);
            Rational number2 = new Rational(chisl_2, znam_2);
            if (z1.Text == "0" || z2.Text == "0")

                MessageBox.Show("на 0 делить нельзя");

            else
            {
                Rational result = null;
                if (znak == "-")
                    result = number1 - number2;
                else if (znak == "+")
                    result = number1 + number2;
                else if (znak == "/")
                    result = number1 / number2;
                else if (znak == "*")
                    result = number1 * number2;
                Rational.Reduction(ref result);
                otv.Text = Rational.ToString(result);
            }

        }

        
    }
}
