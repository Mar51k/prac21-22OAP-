﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form1 Main = this.Owner as Form1;

            if (textBox1.Text != "")
            {
                if((radioButton1.Checked == true) || (radioButton2.Checked == true))
                {
                    if (radioButton1.Checked == true)
                    {
                        Main.razdel1.Items.Add(textBox1.Text);
                    }
                    else
                    {
                        Main.razdel2.Items.Add(textBox1.Text);
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Вы не выбрали раздел");
                }
                    
            }
            else
            {
                MessageBox.Show("Укажите текст, который хотите добавить");
            }
        }
    }
}
