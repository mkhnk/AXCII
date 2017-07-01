using System;
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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }


        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataSet.проценты". При необходимости она может быть перемещена или удалена.
            this.процентыTableAdapter.Fill(this.baseDataSet.проценты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataSet.продукт". При необходимости она может быть перемещена или удалена.
            this.продуктTableAdapter.Fill(this.baseDataSet.продукт);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataSet.проценты". При необходимости она может быть перемещена или удалена.
            this.процентыTableAdapter.Fill(this.baseDataSet.проценты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataSet.продукт". При необходимости она может быть перемещена или удалена.
            this.продуктTableAdapter.Fill(this.baseDataSet.продукт);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataSet.организация_поставщик". При необходимости она может быть перемещена или удалена.
            this.организация_поставщикTableAdapter.Fill(this.baseDataSet.организация_поставщик);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataSet.документ". При необходимости она может быть перемещена или удалена.
            this.документTableAdapter.Fill(this.baseDataSet.документ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataSet.прибыль_в_месяц". При необходимости она может быть перемещена или удалена.
            this.прибыль_в_месяцTableAdapter.Fill(this.baseDataSet.прибыль_в_месяц);
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2 fs = new Form2();
            fs.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < прибыль_в_месяцDataGridView.Rows.Count - 1; i++)
            {
                прибыль_в_месяцDataGridView.CurrentCell = null;
                прибыль_в_месяцDataGridView.Rows[i].Visible = false;
                for (int c = 0; c < прибыль_в_месяцDataGridView.Columns.Count; c++)
                {
                    if (прибыль_в_месяцDataGridView[c, i].Value.ToString() == textBox1.Text)
                    {
                        прибыль_в_месяцDataGridView.Rows[i].Visible = true;
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

            int colCount = прибыль_в_месяцDataGridView.ColumnCount;
            int rowCount = прибыль_в_месяцDataGridView.RowCount - 1;

            Font font = new Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point);

            int[] widthC = new int[colCount];

            int current_col = 0;
            int current_row = 0;

            while (current_col < colCount)
            {
                if (g.MeasureString(прибыль_в_месяцDataGridView.Columns[current_col].HeaderText.ToString(), font).Width > widthC[current_col])
                {
                    widthC[current_col] = (int)g.MeasureString(прибыль_в_месяцDataGridView.Columns[current_col].HeaderText.ToString(), font).Width;
                }
                current_col++;
            }

            while (current_row < rowCount)
            {
                while (current_col < colCount)
                {
                    if (g.MeasureString(прибыль_в_месяцDataGridView[current_col, current_row].Value.ToString(), font).Width > widthC[current_col])
                    {
                        widthC[current_col] = (int)g.MeasureString(прибыль_в_месяцDataGridView[current_col, current_row].Value.ToString(), font).Width;
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
            int height = прибыль_в_месяцDataGridView[current_col, current_row].Size.Height;

            Rectangle cell_border;
            SolidBrush brush = new SolidBrush(Color.Black);


            while (current_col < colCount)
            {
                width = widthC[current_col];
                cell_height = прибыль_в_месяцDataGridView[current_col, current_row].Size.Height;
                cell_border = new Rectangle(x, y, width, height);
                value = прибыль_в_месяцDataGridView.Columns[current_col].HeaderText.ToString();
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
                    cell_height = прибыль_в_месяцDataGridView[current_col, current_row].Size.Height;
                    cell_border = new Rectangle(x, y, width, height);
                    value = прибыль_в_месяцDataGridView[current_col, current_row].Value.ToString();
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

        private void прибыль_в_месяцBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            int s = прибыль_в_месяцDataGridView.RowCount - 2;
            while (s >= 0)
            {
                int c = Convert.ToInt32(прибыль_в_месяцDataGridView.Rows[s].Cells[1].Value);
                int d = Convert.ToInt32(документDataGridView.Rows[c-2].Cells[3].Value);
                int p = Convert.ToInt32(документDataGridView.Rows[c-2].Cells[2].Value);
                прибыль_в_месяцDataGridView.Rows[s].Cells[3].Value = Convert.ToString(Convert.ToInt32(продуктDataGridView.Rows[d - 1].Cells[2].Value) / 30 * Convert.ToInt32(процентыDataGridView.Rows[p - 1].Cells[2].Value) / 100 * 30);
                s--;
            }
            this.Validate();
            this.прибыль_в_месяцBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baseDataSet);

        }
    }
}
