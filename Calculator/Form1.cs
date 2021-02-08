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
        private Calculator calculator = new Calculator();
        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            calculator.InputDigit(7);
            textBox1.Text = calculator.displaynumber;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculator.InputDigit(0);
            textBox1.Text = calculator.displaynumber;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            calculator.InputDigit(1);
            textBox1.Text = calculator.displaynumber;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            calculator.InputDigit(2);
            textBox1.Text = calculator.displaynumber;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            calculator.InputDigit(3);
            textBox1.Text = calculator.displaynumber;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            calculator.InputDigit(4);
            textBox1.Text = calculator.displaynumber;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            calculator.InputDigit(5);
            textBox1.Text = calculator.displaynumber;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            calculator.InputDigit(6);
            textBox1.Text = calculator.displaynumber;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            calculator.InputDigit(8);
            textBox1.Text = calculator.displaynumber;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            calculator.InputDigit(9);
            textBox1.Text = calculator.displaynumber;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            calculator.InputOperation('/');
            textBox1.Text = calculator.displaynumber;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            calculator.InputOperation('+');
            textBox1.Text = calculator.displaynumber;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            calculator.InputOperation('-');
            textBox1.Text = calculator.displaynumber;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            calculator.InputOperation('*');
            textBox1.Text = calculator.displaynumber;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            calculator.InputEquel();
            textBox1.Text = calculator.displaynumber;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
