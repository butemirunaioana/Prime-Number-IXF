﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeNumberIXF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            int result = 0;
            bool isNumber = Int32.TryParse(PrimeNumberTextbox.Text, out result);
            if (isNumber)
            {
                bool isPrime = true;
                for (int i = 2; i <=result / 2; i++)
                {
                    if (result % i == 0)
                        isPrime = false;
                }
                if (isPrime)
                {
                    this.BackColor = Color.Green;
                    PrimeNumberTextbox. Text = " ";
                }
                else
                {
                    this.BackColor = Color.Red;
                    PrimeNumberTextbox.Text = " ";

                }
            } else
            {
                MessageBox.Show("S-a introdus un text");
                this.BackColor = Color.Yellow;
             

            }

        }
    }
}
