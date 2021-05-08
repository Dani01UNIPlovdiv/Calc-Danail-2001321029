using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc_Danail
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }
        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(textBox1.Text)));
        }
        private void buttonPow_Click(object sender, EventArgs e)
        {
            textBox1.Text += "^";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }
        private void buttonPlusMinus_Click(object sender, EventArgs e)
        {
            
            if (!textBox1.Text.Contains("-"))
            {
                textBox1.Text = textBox1.Text.Insert(0, "-");
            }
            else
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
            }

        }
        private void buttonEqu_Click(object sender, EventArgs e)
        {
            try {
                int t = 0;
                if (textBox1.Text.Contains("+"))
                {
                    t = textBox1.Text.IndexOf("+");
                }
                else if (textBox1.Text.Contains("-"))
                {
                    t = textBox1.Text.IndexOf("-");
                }
                else if (textBox1.Text.Contains("*"))
                {
                    t = textBox1.Text.IndexOf("*");
                }
                else if (textBox1.Text.Contains("/"))
                {
                    t = textBox1.Text.IndexOf("/");
                }
                else if (textBox1.Text.Contains("^"))
                {
                    t = textBox1.Text.IndexOf("^");
                }
                string x = textBox1.Text.Substring(t, 1);
                double x1 = Convert.ToDouble(textBox1.Text.Substring(0, t));
                double x2 = Convert.ToDouble(textBox1.Text.Substring(t + 1, textBox1.Text.Length - t - 1));
                if (x == "+")
                {
                    listBox1.Items.Add(textBox1.Text + "=" + (x1 + x2));
                    textBox1.Text = (x1 + x2).ToString();
                }
                else if (x == "-")
                {
                    listBox1.Items.Add(textBox1.Text + "=" + (x1 - x2));
                    textBox1.Text = (x1 - x2).ToString();
                }
                else if (x == "*")
                {
                    listBox1.Items.Add(textBox1.Text + "=" + (x1 * x2));
                    textBox1.Text = (x1 * x2).ToString();
                }
                else if (x == "/")
                {
                    listBox1.Items.Add(textBox1.Text + "=" + (x1 / x2));
                    textBox1.Text = (x1 / x2).ToString();
                }
                else if (x == "^")
                {
                    listBox1.Items.Add(textBox1.Text + "=" + Math.Pow(x1,x2));
                    textBox1.Text = Math.Pow(x1,x2).ToString();
                }
            }
            catch
            {
                textBox1.Text = "error";
            }
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }