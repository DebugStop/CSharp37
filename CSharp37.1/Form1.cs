﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp37._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            Random rnd = new Random();
            int number;

            for (int index = 0; index < 10; index++)
            {
                number = -10 + rnd.Next(20);
                listBox1.Items.Add(number);
            }

            for (int index = 0; index < 10; index++)
                if (((int)listBox1.Items[index] == Math.Abs((int)listBox1.Items[2])) && (index != 2))
                    MessageBox.Show(listBox1.Items[index].ToString());

        }
    }
}
