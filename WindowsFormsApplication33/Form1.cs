﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication33
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double toplam = 0;
            int sayac = 0;
            double ortalama;
            while (sayac< listBox1.Items.Count)
            {
                 toplam=toplam + Convert.ToDouble(listBox1.Items[sayac]);
                 sayac++;
            }
            ortalama = toplam / sayac;
            label1.Text = "Ortalama" + ortalama.ToString();
        }
    }
}
