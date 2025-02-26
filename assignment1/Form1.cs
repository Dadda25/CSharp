using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string word1=textBox1.Text;
            string word2=textBox2.Text;
            string word3=textBox3.Text;
            double num1, num2;

            if (!double.TryParse(word1, out num1))
            {
                label4.Text = "操作数1不是有效数字";
                return;
            }

            if (!double.TryParse(word2, out num2))
            {
                label4.Text = "操作数2不是有效数字";
                return;
            }

            double result = 0;
            bool validOperator = true;

            switch (word3)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        label4.Text = "除数不能为零";
                        validOperator = false;
                    }
                    break;
                default:
                    label4.Text = "运算符无效";
                    validOperator = false;
                    break;
            }

            if (validOperator)
            {
                label4.Text = result.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
