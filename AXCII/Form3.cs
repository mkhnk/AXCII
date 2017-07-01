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
    public partial class Form3 : Form
    {        
        public Form3()
        {
            InitializeComponent();
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataSet.сроки". При необходимости она может быть перемещена или удалена.
            this.срокиTableAdapter.Fill(this.baseDataSet.сроки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataSet.продукт". При необходимости она может быть перемещена или удалена.
            this.продуктTableAdapter.Fill(this.baseDataSet.продукт);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataSet.проценты". При необходимости она может быть перемещена или удалена.
            this.процентыTableAdapter.Fill(this.baseDataSet.проценты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataSet.документ". При необходимости она может быть перемещена или удалена.
            this.документTableAdapter.Fill(this.baseDataSet.документ);
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2 fs = new Form2();
            fs.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < документDataGridView.Rows.Count - 1; i++)
            {
                документDataGridView.CurrentCell = null;
                документDataGridView.Rows[i].Visible = false;
                for (int c = 0; c < документDataGridView.Columns.Count; c++)
                {
                    if (документDataGridView[c, i].Value.ToString() == textBox1.Text)
                    {
                        документDataGridView.Rows[i].Visible = true;
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

            int colCount = документDataGridView.ColumnCount;
            int rowCount = документDataGridView.RowCount - 1;

            Font font = new Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point);

            int[] widthC = new int[colCount];

            int current_col = 0;
            int current_row = 0;

            while (current_col < colCount)
            {
                if (g.MeasureString(документDataGridView.Columns[current_col].HeaderText.ToString(), font).Width > widthC[current_col])
                {
                    widthC[current_col] = (int)g.MeasureString(документDataGridView.Columns[current_col].HeaderText.ToString(), font).Width;
                }
                current_col++;
            }

            while (current_row < rowCount)
            {
                while (current_col < colCount)
                {
                    if (g.MeasureString(документDataGridView[current_col, current_row].Value.ToString(), font).Width > widthC[current_col])
                    {
                        widthC[current_col] = (int)g.MeasureString(документDataGridView[current_col, current_row].Value.ToString(), font).Width;
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
            int height = документDataGridView[current_col, current_row].Size.Height;

            Rectangle cell_border;
            SolidBrush brush = new SolidBrush(Color.Black);


            while (current_col < colCount)
            {
                width = widthC[current_col];
                cell_height = документDataGridView[current_col, current_row].Size.Height;
                cell_border = new Rectangle(x, y, width, height);
                value = документDataGridView.Columns[current_col].HeaderText.ToString();
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
                    cell_height = документDataGridView[current_col, current_row].Size.Height;
                    cell_border = new Rectangle(x, y, width, height);
                    value = документDataGridView[current_col, current_row].Value.ToString();
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

        private void документBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            int s = документDataGridView.RowCount-2;
            while (s >= 0)
            {
                int d = Convert.ToInt32(документDataGridView.Rows[s].Cells[3].Value);
                int p = Convert.ToInt32(документDataGridView.Rows[s].Cells[2].Value);
                int c = Convert.ToInt32(процентыDataGridView.Rows[p-1].Cells[1].Value);
                документDataGridView.Rows[s].Cells[4].Value = Convert.ToString(Convert.ToInt32(продуктDataGridView.Rows[d-1].Cells[2].Value) / 30 * Convert.ToInt32(процентыDataGridView.Rows[p-1].Cells[2].Value) / 100 * Convert.ToInt32(срокиDataGridView.Rows[c-1].Cells[1].Value));
                s--;
            }
            this.Validate();
            this.документBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baseDataSet);
        }
    }
}
