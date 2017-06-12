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
    public partial class FormMain : Form
    {
        String totalValue = String.Empty;
        String firstValue = String.Empty;
        public FormMain()
        {
            InitializeComponent();
            txtDisplay.Text = "0";

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            totalValue += "1";
            txtDisplay.Text = totalValue;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            totalValue += "2";
            txtDisplay.Text = totalValue;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            totalValue += "3";
            txtDisplay.Text = totalValue;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            totalValue += "4";
            txtDisplay.Text = totalValue;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            totalValue += "5";
            txtDisplay.Text = totalValue;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            totalValue += "6";
            txtDisplay.Text = totalValue;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            totalValue += "7";
            txtDisplay.Text = totalValue;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            totalValue += "8";
            txtDisplay.Text = totalValue;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            totalValue += "9";
            txtDisplay.Text = totalValue;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if(totalValue.Equals("0"))
            {
                totalValue = "0";
                txtDisplay.Text = totalValue;
            }
            else
            {
                totalValue += "0";
                txtDisplay.Text = totalValue;
            }
            
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            totalValue = "0";
            txtDisplay.Text = totalValue;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            totalValue = "0";
            txtDisplay.Text = totalValue;
        }

        private void btbBack_Click(object sender, EventArgs e)
        {
            totalValue=totalValue.Remove(totalValue.Length-1, 1);
            txtDisplay.Text = totalValue;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
           
            if(!String.IsNullOrEmpty(firstValue))
            {
                Double val1 = Double.Parse(firstValue);
                Double val2 = Double.Parse(totalValue);
                Double res = val1 + val2;
                totalValue = res.ToString();
                txtDisplay.Text = totalValue;

            }else
            {
                firstValue = totalValue;
                totalValue = String.Empty;
                txtDisplay.Text = "";
            }
        }
    }
}
