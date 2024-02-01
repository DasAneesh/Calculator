using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        CalculusViewModel vm;
        public Form1()
        {
            InitializeComponent();
            vm = new CalculusViewModel();
        }

        //Событие на кнопку равно -- vm.evaluate(); помещаем результат в текстобк ответа


        private void button0_Click(object sender, EventArgs e)
        {
            textBox_input.Text += "0 ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_input.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox_input.Text += "2 ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox_input.Text += "3 ";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox_input.Text += "4 ";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox_input.Text += "5 ";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox_input.Text += "6 ";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox_input.Text += "7 ";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox_input.Text += "8 ";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox_input.Text += "9 ";
        }

        private void buttonLbrackets_Click(object sender, EventArgs e)
        {
            textBox_input.Text += "( ";
        }

        private void buttonRbrackets_Click(object sender, EventArgs e)
        {
            textBox_input.Text += ") ";
        }
        private void buttondivision_Click(object sender, EventArgs e)
        {
            textBox_input.Text += "/ ";
        }

        private void buttonmultiplication_Click(object sender, EventArgs e)
        {
            textBox_input.Text += "* ";
        }

        private void buttonplus_Click(object sender, EventArgs e)
        {
            textBox_input.Text += "+ ";
        }

        private void buttonminus_Click(object sender, EventArgs e)
        {
            textBox_input.Text += "- ";
        }

        private void buttonalldel_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonevaluation_Click(object sender, EventArgs e)
        {
            textBox_output.Text = vm.Evaluate(textBox_input.Text.TrimEnd());
        }

       
    }
}
