using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORAKL_NIOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            broj0.Show();
            broj1.Show();
            broj2.Show();
            broj3.Show();
            broj4.Show();
            broj5.Show();
            broj6.Show();
            broj7.Show();
            broj8.Show();
            broj9.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string djelatnik = textBox1.Text;
            string zaporka = textBox2.Text;
            if (djelatnik == "255880" && zaporka == "5880")
            {
                Form2 noviProzor = new Form2();
                noviProzor.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Pogrešno korisničko ime ili lozinka.");
            }
        }

        private void broj0_Click(object sender, EventArgs e)
        {
            if (textBox1.Focused)
            {
                textBox1.Text += "0";
            }
            else if (textBox2.Focused)
            {
                textBox2.Text += "0";
            }
        }

        private void broj1_Click(object sender, EventArgs e)
        {
            if (textBox2.Focused)
            {
                textBox2.AppendText("1");
            }
            if (textBox1.Focused)
            {
                textBox1.AppendText("1");
            }
        }

        private void broj2_Click(object sender, EventArgs e)
        {
            if (textBox2.Focused)
            {
                textBox2.AppendText("2");
            }
            if (textBox1.Focused)
            {
                textBox1.AppendText("2");
            }
        }

        private void broj3_Click(object sender, EventArgs e)
        {
            if (textBox2.Focused)
            {
                textBox2.AppendText("3");
            }
            if (textBox1.Focused)
            {
                textBox1.AppendText("3");
            }
        }

        private void broj4_Click(object sender, EventArgs e)
        {
            if (textBox2.Focused)
            {
                textBox2.AppendText("4");
            }
            if (textBox1.Focused)
            {
                textBox1.AppendText("4");
            }
        }

        private void broj5_Click(object sender, EventArgs e)
        {
            if (textBox2.Focused)
            {
                textBox2.AppendText("5");
            }
            if (textBox1.Focused)
            {
                textBox1.AppendText("5");
            }
        }

        private void broj6_Click(object sender, EventArgs e)
        {
            if (textBox2.Focused)
            {
                textBox2.AppendText("6");
            }
            if (textBox1.Focused)
            {
                textBox1.AppendText("6");
            }
        }

        private void broj7_Click(object sender, EventArgs e)
        {
            if (textBox2.Focused)
            {
                textBox2.AppendText("7");
            }
            if (textBox1.Focused)
            {
                textBox1.AppendText("7");
            }
        }

        private void broj8_Click(object sender, EventArgs e)
        {
            if (textBox2.Focused)
            {
                textBox2.AppendText("8");
            }
            if (textBox1.Focused)
            {
                textBox1.AppendText("8");
            }
        }

        private void broj9_Click(object sender, EventArgs e)
        {
            if (textBox2.Focused)
            {
                textBox2.AppendText("9");
            }
            if (textBox1.Focused)
            {
                textBox1.AppendText("9");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }
        private void numberButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                string number = button.Text;
                if (textBox1.Focused)
                {
                    textBox1.Text += number;
                }
                else if (textBox2.Focused)
                {
                    textBox2.Text += number;
                }
            }
        }

    }
}
