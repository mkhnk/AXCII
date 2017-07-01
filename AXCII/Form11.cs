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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void прибыль_в_месяцBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.прибыль_в_месяцBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baseDataSet);

        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataSet.организация_поставщик". При необходимости она может быть перемещена или удалена.
            this.организация_поставщикTableAdapter.Fill(this.baseDataSet.организация_поставщик);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataSet.документ". При необходимости она может быть перемещена или удалена.
            this.документTableAdapter.Fill(this.baseDataSet.документ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataSet.прибыль_в_месяц". При необходимости она может быть перемещена или удалена.
            this.прибыль_в_месяцTableAdapter.Fill(this.baseDataSet.прибыль_в_месяц);
            int s = прибыль_в_месяцDataGridView.RowCount - 2;
            int c = документDataGridView.RowCount - 2;
            int i = 0;
            int n = 0;
            while ((i <= s) && (i <= c))
            {
                //MessageBox.Show(Convert.ToString(i));
                n = Convert.ToInt32(прибыль_в_месяцDataGridView.Rows[i].Cells[2].Value);
                chart1.Series.Add("Series" + Convert.ToString(i));
                chart1.Series[i].Points.AddXY(i+1, прибыль_в_месяцDataGridView.Rows[i].Cells[3].Value);
                chart1.Series[i].Name = Convert.ToString(организация_поставщикDataGridView.Rows[n-1].Cells[1].Value)+ "        " + Convert.ToString(i+1);
                i++;
            }
        }

        private void Form11_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2 fs = new Form2();
            fs.Show();
            this.Hide();
        }
    }
}
