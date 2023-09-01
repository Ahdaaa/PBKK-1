using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_bmi(object sender, EventArgs e)
        {
            double weight, height, bmi;

            weight = int.Parse(textBox1.Text);
            height = int.Parse(textBox2.Text);
            bmi = (weight / height / height) * 10000;

            bmi = Math.Round(bmi, 2);

            if (bmi < 18.5)
            {
                textBox3.Text = bmi + " Underweight";
                label5.Text = "Berat badan anda kurang";
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                textBox3.Text = bmi + " Normal";
                label5.Text = "Berat badan anda normal";
            } 
            else if (bmi >= 25 && bmi <= 29.9)
            {
                textBox3.Text = bmi + " Overweight";
                label5.Text = "Berat badan anda berlebih";
            }
            else if (bmi >= 30)
            {
                textBox3.Text = bmi + " Obesity";
                label5.Text = "Berat badan anda tergolong obesitas";
            }
            
        }
    }
}
