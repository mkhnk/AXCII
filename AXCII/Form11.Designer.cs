namespace AXCII
{
    partial class Form11
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.прибыль_в_месяцBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baseDataSet = new AXCII.baseDataSet();
            this.прибыль_в_месяцTableAdapter = new AXCII.baseDataSetTableAdapters.прибыль_в_месяцTableAdapter();
            this.tableAdapterManager = new AXCII.baseDataSetTableAdapters.TableAdapterManager();
            this.документBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.документTableAdapter = new AXCII.baseDataSetTableAdapters.документTableAdapter();
            this.документDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.прибыль_в_месяцDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.организация_поставщикBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.организация_поставщикTableAdapter = new AXCII.baseDataSetTableAdapters.организация_поставщикTableAdapter();
            this.организация_поставщикDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.прибыль_в_месяцBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.документBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.документDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.прибыль_в_месяцDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.организация_поставщикBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.организация_поставщикDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.Rotation = 150;
            chartArea1.AxisX.Title = "Номер компании в списке";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisY.Title = "Прибыль от акций в месяц";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.прибыль_в_месяцBindingSource;
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            legend1.Title = "Список компаний";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(941, 467);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // прибыль_в_месяцBindingSource
            // 
            this.прибыль_в_месяцBindingSource.DataMember = "прибыль_в_месяц";
            this.прибыль_в_месяцBindingSource.DataSource = this.baseDataSet;
            // 
            // baseDataSet
            // 
            this.baseDataSet.DataSetName = "baseDataSet";
            this.baseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // прибыль_в_месяцTableAdapter
            // 
            this.прибыль_в_месяцTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = AXCII.baseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.документTableAdapter = null;
            this.tableAdapterManager.операцияTableAdapter = null;
            this.tableAdapterManager.организация_клиентTableAdapter = null;
            this.tableAdapterManager.организация_поставщикTableAdapter = null;
            this.tableAdapterManager.прибыль_в_месяцTableAdapter = this.прибыль_в_месяцTableAdapter;
            this.tableAdapterManager.продуктTableAdapter = null;
            this.tableAdapterManager.процентыTableAdapter = null;
            this.tableAdapterManager.срокиTableAdapter = null;
            // 
            // документBindingSource
            // 
            this.документBindingSource.DataMember = "документ";
            this.документBindingSource.DataSource = this.baseDataSet;
            // 
            // документTableAdapter
            // 
            this.документTableAdapter.ClearBeforeFill = true;
            // 
            // документDataGridView
            // 
            this.документDataGridView.AutoGenerateColumns = false;
            this.документDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.документDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.документDataGridView.DataSource = this.документBindingSource;
            this.документDataGridView.Location = new System.Drawing.Point(621, 137);
            this.документDataGridView.Name = "документDataGridView";
            this.документDataGridView.Size = new System.Drawing.Size(300, 220);
            this.документDataGridView.TabIndex = 1;
            this.документDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "наименование документа";
            this.dataGridViewTextBoxColumn2.HeaderText = "наименование документа";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "код_процентов";
            this.dataGridViewTextBoxColumn3.HeaderText = "код_процентов";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "код_продукта";
            this.dataGridViewTextBoxColumn4.HeaderText = "код_продукта";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "сумма";
            this.dataGridViewTextBoxColumn5.HeaderText = "сумма";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // прибыль_в_месяцDataGridView
            // 
            this.прибыль_в_месяцDataGridView.AutoGenerateColumns = false;
            this.прибыль_в_месяцDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.прибыль_в_месяцDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.прибыль_в_месяцDataGridView.DataSource = this.прибыль_в_месяцBindingSource;
            this.прибыль_в_месяцDataGridView.Location = new System.Drawing.Point(537, 227);
            this.прибыль_в_месяцDataGridView.Name = "прибыль_в_месяцDataGridView";
            this.прибыль_в_месяцDataGridView.Size = new System.Drawing.Size(300, 220);
            this.прибыль_в_месяцDataGridView.TabIndex = 2;
            this.прибыль_в_месяцDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Код";
            this.dataGridViewTextBoxColumn6.HeaderText = "Код";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "код_документа";
            this.dataGridViewTextBoxColumn7.HeaderText = "код_документа";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "код_организации";
            this.dataGridViewTextBoxColumn8.HeaderText = "код_организации";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "итоговая_прибыль";
            this.dataGridViewTextBoxColumn9.HeaderText = "итоговая_прибыль";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // организация_поставщикBindingSource
            // 
            this.организация_поставщикBindingSource.DataMember = "организация_поставщик";
            this.организация_поставщикBindingSource.DataSource = this.baseDataSet;
            // 
            // организация_поставщикTableAdapter
            // 
            this.организация_поставщикTableAdapter.ClearBeforeFill = true;
            // 
            // организация_поставщикDataGridView
            // 
            this.организация_поставщикDataGridView.AutoGenerateColumns = false;
            this.организация_поставщикDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.организация_поставщикDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.организация_поставщикDataGridView.DataSource = this.организация_поставщикBindingSource;
            this.организация_поставщикDataGridView.Location = new System.Drawing.Point(519, 152);
            this.организация_поставщикDataGridView.Name = "организация_поставщикDataGridView";
            this.организация_поставщикDataGridView.Size = new System.Drawing.Size(300, 220);
            this.организация_поставщикDataGridView.TabIndex = 3;
            this.организация_поставщикDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Код";
            this.dataGridViewTextBoxColumn10.HeaderText = "Код";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "наименование";
            this.dataGridViewTextBoxColumn11.HeaderText = "наименование";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "телефон";
            this.dataGridViewTextBoxColumn12.HeaderText = "телефон";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "почта";
            this.dataGridViewTextBoxColumn13.HeaderText = "почта";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "фио_представителя";
            this.dataGridViewTextBoxColumn14.HeaderText = "фио_представителя";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 467);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.организация_поставщикDataGridView);
            this.Controls.Add(this.прибыль_в_месяцDataGridView);
            this.Controls.Add(this.документDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form11";
            this.Text = "Графики";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form11_FormClosed);
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.прибыль_в_месяцBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.документBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.документDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.прибыль_в_месяцDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.организация_поставщикBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.организация_поставщикDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private baseDataSet baseDataSet;
        private System.Windows.Forms.BindingSource прибыль_в_месяцBindingSource;
        private baseDataSetTableAdapters.прибыль_в_месяцTableAdapter прибыль_в_месяцTableAdapter;
        private baseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource документBindingSource;
        private baseDataSetTableAdapters.документTableAdapter документTableAdapter;
        private System.Windows.Forms.DataGridView документDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridView прибыль_в_месяцDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.BindingSource организация_поставщикBindingSource;
        private baseDataSetTableAdapters.организация_поставщикTableAdapter организация_поставщикTableAdapter;
        private System.Windows.Forms.DataGridView организация_поставщикDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
    }
}