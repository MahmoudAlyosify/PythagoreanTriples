using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pythagorean_Triples___Windows_Form
{

    public partial class Form1 : Form
    {
        public static string statment = "";
        static int x1=0;
        static int x2=0;
     public static void Pythagorean_Triples()
        {
            for (int i = x1; i <= x2; i++)
            {
                for (int j = x1; j <= x2; j++)
                {
                    for (int k = x1; k <= x2; k++)
                    {
                        if (i * i + j * j == k * k)
                        {

                            statment += "(" + (i.ToString() + "," + j.ToString() + "," + k.ToString() + ")" + "      ");

                        }
                    }
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            x1 = int.Parse(textBox1.Text);
            x2 = int.Parse(textBox2.Text);
            if (x1 > 0 && x2 > 0)
            {       
                Pythagorean_Triples();
                richTextBox1.Text = statment;
            }
            else
            {
                richTextBox1.Text = "Crazy User Try Again !!";
            }
        }


        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
