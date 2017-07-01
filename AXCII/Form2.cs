using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AXCII
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 fs = new Form3();
            fs.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 fs = new Form4();
            fs.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 fs = new Form5();
            fs.Show();
            this.Hide();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form6 fs = new Form6();
            fs.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 fs = new Form7();
            fs.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form8 fs = new Form8();
            fs.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form9 fs = new Form9();
            fs.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form10 fs = new Form10();
            fs.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form11 fs = new Form11();
            fs.Show();
            this.Hide();
        }
    }
}
