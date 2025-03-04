using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jurnalModul3_1030222330070
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += tombolAngka_Click;
            button2.Click += tombolAngka_Click;
            button3.Click += tombolAngka_Click;
            button4.Click += tombolAngka_Click;
            button5.Click += tombolAngka_Click;
            button6.Click += tombolAngka_Click;
            button7.Click += tombolAngka_Click;
            button8.Click += tombolAngka_Click;
            button9.Click += tombolAngka_Click;
            button0.Click += tombolAngka_Click;
            buttonPlus.Click += tombolTambah_Click;
            buttonTotal.Click += tombolTotal_Click;


        }
        private void tombolAngka_Click(object sender, EventArgs e)
        {
            Button tombol = (Button)sender;
            label1.Text += tombol.Text;
        }

        private void tombolTambah_Click(object sender, EventArgs e)
        {
            label1.Text += "+";
        }

        private void tombolTotal_Click(object sender, EventArgs e)
        {
            string[] angka = label1.Text.Split('+');
            int total = 0;
            foreach (string angkaStr in angka)
            {
                total += int.Parse(angkaStr);
            }
            label1.Text = total.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
