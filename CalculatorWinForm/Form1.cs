using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWinForm
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
        private void btn1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }
        private void button0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(txtResultado.Text);
            operacao = "+";
            txtResultado.Text = "";
        }
        private void btnDiv_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(txtResultado.Text);
            operacao = "/";
            txtResultado.Text = "";
        }
        private void btnSub_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(txtResultado.Text);
            operacao = "-";
            txtResultado.Text = "";
        }
        private void btnMult_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(txtResultado.Text);
            operacao = "*";
            txtResultado.Text = "";
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                valor2 = double.Parse(txtResultado.Text);

                switch (operacao)
                {
                    case "+":
                        txtResultado.Text = (valor1 + valor2).ToString();
                        break;
                    case "-":
                        txtResultado.Text = (valor1 - valor2).ToString();
                        break;
                    case "*":
                        txtResultado.Text = (valor1 * valor2).ToString();
                        break;
                    case "/":
                        if (valor2 != 0)
                        {
                            txtResultado.Text = (valor1 / valor2).ToString();
                        }
                        else
                        {
                            txtResultado.Text = "Erro: Div por 0";
                        }
                        break;
                }

                // Resetar valores após a operação
                valor1 = 0;
                valor2 = 0;
                operacao = "";
            }
            catch (FormatException)
            {
                txtResultado.Text = "Erro: Entrada inválida";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            operacao = "";
        }   

        private double valor1 = 0;
        private double valor2 = 0;
        private string operacao = "";
        
    }
}
