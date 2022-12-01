using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cmostransmissiongatesmultiplexor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "1";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = "1";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox3.Text = "0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Text = "1";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                if (textBox2.Text == "0")
                {
                    if (textBox3.Text == "0")
                    {
                        textBox4.Text = "0";
                    }
                    else
                    {
                        textBox4.Text = "0";
                    }
                }
                else
                {
                    if (textBox3.Text == "0")
                    {
                        textBox4.Text = "1";
                    }
                    else
                    {
                        textBox4.Text = "1";
                    }
                }
            }
            else
            {
                if (textBox2.Text == "1")
                {
                    if (textBox3.Text == "0")
                    {
                        textBox4.Text = "0";
                    }
                    else
                    {
                        textBox4.Text = "1";
                    }
                }
                else
                {
                    if (textBox3.Text == "0")
                    {
                        textBox4.Text = "0";
                    }
                    else
                    {
                        textBox4.Text = "1";
                    }
                }
            }

        }
    }
}
