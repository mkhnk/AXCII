﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace AXCII
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }


        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataSet.организация_поставщик". При необходимости она может быть перемещена или удалена.
            this.организация_поставщикTableAdapter.Fill(this.baseDataSet.организация_поставщик);

        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2 fs = new Form2();
            fs.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < организация_поставщикDataGridView.Rows.Count - 1; i++)
            {
                организация_поставщикDataGridView.CurrentCell = null;
                организация_поставщикDataGridView.Rows[i].Visible = false;
                for (int c = 0; c < организация_поставщикDataGridView.Columns.Count; c++)
                {
                    if (организация_поставщикDataGridView[c, i].Value.ToString() == textBox1.Text)
                    {
                        организация_поставщикDataGridView.Rows[i].Visible = true;
                        break;
                    }
                }
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int x = 0;
            int y = 20;
            int cell_height = 0;

            int colCount = организация_поставщикDataGridView.ColumnCount;
            int rowCount = организация_поставщикDataGridView.RowCount - 1;

            Font font = new Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point);

            int[] widthC = new int[colCount];

            int current_col = 0;
            int current_row = 0;

            while (current_col < colCount)
            {
                if (g.MeasureString(организация_поставщикDataGridView.Columns[current_col].HeaderText.ToString(), font).Width > widthC[current_col])
                {
                    widthC[current_col] = (int)g.MeasureString(организация_поставщикDataGridView.Columns[current_col].HeaderText.ToString(), font).Width;
                }
                current_col++;
            }

            while (current_row < rowCount)
            {
                while (current_col < colCount)
                {
                    if (g.MeasureString(организация_поставщикDataGridView[current_col, current_row].Value.ToString(), font).Width > widthC[current_col])
                    {
                        widthC[current_col] = (int)g.MeasureString(организация_поставщикDataGridView[current_col, current_row].Value.ToString(), font).Width;
                    }
                    current_col++;
                }
                current_col = 0;
                current_row++;
            }

            current_col = 0;
            current_row = 0;

            string value = "";

            int width = widthC[current_col] + 5;
            int height = организация_поставщикDataGridView[current_col, current_row].Size.Height;

            Rectangle cell_border;
            SolidBrush brush = new SolidBrush(Color.Black);


            while (current_col < colCount)
            {
                width = widthC[current_col];
                cell_height = организация_поставщикDataGridView[current_col, current_row].Size.Height;
                cell_border = new Rectangle(x, y, width, height);
                value = организация_поставщикDataGridView.Columns[current_col].HeaderText.ToString();
                g.DrawRectangle(new Pen(Color.Black), cell_border);
                g.DrawString(value, font, brush, x, y);
                x += widthC[current_col];
                current_col++;
            }
            current_row = -1;
            while (current_row < rowCount)
            {
                while (current_col < colCount)
                {
                    width = widthC[current_col];
                    cell_height = организация_поставщикDataGridView[current_col, current_row].Size.Height;
                    cell_border = new Rectangle(x, y, width, height);
                    value = организация_поставщикDataGridView[current_col, current_row].Value.ToString();
                    g.DrawRectangle(new Pen(Color.Black), cell_border);
                    g.DrawString(value, font, brush, x, y);
                    x += widthC[current_col];
                    current_col++;
                }
                current_col = 0;
                current_row++;
                x = 0;
                y += cell_height;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDocument Document = new PrintDocument();
            Document.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.Document = Document;
            dlg.ShowDialog();
        }

        private void организация_поставщикBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.организация_поставщикBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baseDataSet);

        }
    }
}
