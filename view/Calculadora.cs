
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora.csharp
{
    public partial class Calculadora : Form
    {
        private int num1;
        private int num2;
        //private string operador;
        public Calculadora()
        {
            InitializeComponent();
            num1 = 0;
            num2 = 0;
            
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {
            txtCalculo.Enabled = true;

        }
        private void btnIgual_Click(object sender, EventArgs e)
        {
            string calculo = txtCalculo.Text;
            checkCalculation(calculo);
        }
        private void checkCalculation(string calculo)
        {
            if(calculo.Contains("+"))
            {
                txtCalculo.Clear();
                txtCalculo.Text = sumCalculation(calculo).ToString(); ;
            }
            if(calculo.Contains("-"))
            {
                txtCalculo.Clear();
                txtCalculo.Text = restCalculation(calculo).ToString();  
            }
            if (calculo.Contains("x"))
            {
                txtCalculo.Clear();
                txtCalculo.Text= multiplicationCalculation(calculo).ToString();
            }
            if(calculo.Contains("/"))
            {
                txtCalculo.Clear();
                txtCalculo.Text = divisionCalculation(calculo).ToString();
            }
            


            
        }

        private double divisionCalculation(string calculo)
        {
            MatchCollection matchesFirst = Regex.Matches(calculo, @"\d+");
            string firstMatch = matchesFirst[0].Value;
            double numero1 = Convert.ToInt32(firstMatch);

            MatchCollection matchesSecond = Regex.Matches(calculo, @"\d+");
            string lastMatch = matchesSecond[matchesSecond.Count - 1].Value;
            double numero2 = Convert.ToInt32(lastMatch);
            return numero1 / numero2;

        }

        private int sumCalculation(string calculo)
        {
            MatchCollection matchesFirst = Regex.Matches(calculo, @"\d+");
            string firstMatch = matchesFirst[0].Value;
            num1 = Convert.ToInt32(firstMatch);

            MatchCollection matchesSecond = Regex.Matches(calculo, @"\d+");
            string lastMatch = matchesSecond[matchesSecond.Count - 1].Value;
            num2 = Convert.ToInt32(lastMatch);
            return num1 + num2;
        }
        private int restCalculation(string calculo)
        {
            MatchCollection matchesFirst = Regex.Matches(calculo, @"\d+");
            string firstMatch = matchesFirst[0].Value;
            num1 = Convert.ToInt32(firstMatch);

            MatchCollection matchesSecond = Regex.Matches(calculo, @"\d+");
            string lastMatch = matchesSecond[matchesSecond.Count - 1].Value;
            num2 = Convert.ToInt32(lastMatch);
            return num1 - num2;
        }
        private int multiplicationCalculation(string calculo)
        {
            MatchCollection matchesFirst = Regex.Matches(calculo, @"\d+");
            string firstMatch = matchesFirst[0].Value;
            num1 = Convert.ToInt32(firstMatch);

            MatchCollection matchesSecond = Regex.Matches(calculo, @"\d+");
            string lastMatch = matchesSecond[matchesSecond.Count - 1].Value;
            num2 = Convert.ToInt32(lastMatch);
            return num1 * num2;
        }






        private void btnMas_Click(object sender, EventArgs e)
        {
            txtCalculo.Text = txtCalculo.Text + "+";
            

        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            txtCalculo.Text = txtCalculo.Text + "-";
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            txtCalculo.Text = txtCalculo.Text + "x";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            txtCalculo.Text = txtCalculo.Text + "/";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtCalculo.Text =  txtCalculo.Text +"7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtCalculo.Text = txtCalculo.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtCalculo.Text = txtCalculo.Text + "9";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtCalculo.Text = txtCalculo.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtCalculo.Text = txtCalculo.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtCalculo.Text = txtCalculo.Text + "6";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtCalculo.Text = txtCalculo.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtCalculo.Text = txtCalculo.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtCalculo.Text = txtCalculo.Text + "3";

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtCalculo.Text = txtCalculo.Text + "0";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtCalculo.Clear();
        }
    }
}
