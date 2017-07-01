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
    public partial class Form1 : Form
    {
        public static int kek = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                label1.Visible = true;
                label2.Visible = true;
                button1.Text = "Войти как клиент";
            } else
            {
                label1.Visible = false;
                button1.Text = "Вход";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                label1.Visible = true;
                label2.Visible = true;
                button1.Text = "Войти как клиент";
            } else
            {
                label2.Visible = false;
                button1.Text = "Вход";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "123" && textBox2.Text == "123")
            {
                Form2 fs = new Form2();
                fs.Show();
                this.Hide();
            }
            else if (textBox1.Text == "" && textBox2.Text == "")
            {
                kek = 1;
                Form5 fs = new Form5();
                fs.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный пароль!");
                textBox1.Text = "";
                textBox2.Text = "";
                label1.Visible = true;
                label2.Visible = true;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
