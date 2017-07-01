namespace AXCII
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.baseDataSet = new AXCII.baseDataSet();
            this.прибыль_в_месяцBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.прибыль_в_месяцTableAdapter = new AXCII.baseDataSetTableAdapters.прибыль_в_месяцTableAdapter();
            this.tableAdapterManager = new AXCII.baseDataSetTableAdapters.TableAdapterManager();
            this.организация_поставщикTableAdapter = new AXCII.baseDataSetTableAdapters.организация_поставщикTableAdapter();
            this.прибыль_в_месяцBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.прибыль_в_месяцBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.прибыль_в_месяцDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.документBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.организацияпоставщикBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.документTableAdapter = new AXCII.baseDataSetTableAdapters.документTableAdapter();
            this.продуктBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.продуктTableAdapter = new AXCII.baseDataSetTableAdapters.продуктTableAdapter();
            this.продуктDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.процентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.процентыTableAdapter = new AXCII.baseDataSetTableAdapters.процентыTableAdapter();
            this.процентыDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.документDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.прибыль_в_месяцBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.прибыль_в_месяцBindingNavigator)).BeginInit();
            this.прибыль_в_месяцBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.прибыль_в_месяцDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.документBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.организацияпоставщикBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.процентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.процентыDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.документDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 474);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 38);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(599, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "Поиск";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(438, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 23);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Отчет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // baseDataSet
            // 
            this.baseDataSet.DataSetName = "baseDataSet";
            this.baseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // прибыль_в_месяцBindingSource
            // 
            this.прибыль_в_месяцBindingSource.DataMember = "прибыль_в_месяц";
            this.прибыль_в_месяцBindingSource.DataSource = this.baseDataSet;
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
            this.tableAdapterManager.организация_поставщикTableAdapter = this.организация_поставщикTableAdapter;
            this.tableAdapterManager.прибыль_в_месяцTableAdapter = this.прибыль_в_месяцTableAdapter;
            this.tableAdapterManager.продуктTableAdapter = null;
            this.tableAdapterManager.процентыTableAdapter = null;
            this.tableAdapterManager.срокиTableAdapter = null;
            // 
            // организация_поставщикTableAdapter
            // 
            this.организация_поставщикTableAdapter.ClearBeforeFill = true;
            // 
            // прибыль_в_месяцBindingNavigator
            // 
            this.прибыль_в_месяцBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.прибыль_в_месяцBindingNavigator.BindingSource = this.прибыль_в_месяцBindingSource;
            this.прибыль_в_месяцBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.прибыль_в_месяцBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.прибыль_в_месяцBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.прибыль_в_месяцBindingNavigatorSaveItem});
            this.прибыль_в_месяцBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.прибыль_в_месяцBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.прибыль_в_месяцBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.прибыль_в_месяцBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.прибыль_в_месяцBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.прибыль_в_месяцBindingNavigator.Name = "прибыль_в_месяцBindingNavigator";
            this.прибыль_в_месяцBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.прибыль_в_месяцBindingNavigator.Size = new System.Drawing.Size(697, 25);
            this.прибыль_в_месяцBindingNavigator.TabIndex = 1;
            this.прибыль_в_месяцBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // прибыль_в_месяцBindingNavigatorSaveItem
            // 
            this.прибыль_в_месяцBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.прибыль_в_месяцBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("прибыль_в_месяцBindingNavigatorSaveItem.Image")));
            this.прибыль_в_месяцBindingNavigatorSaveItem.Name = "прибыль_в_месяцBindingNavigatorSaveItem";
            this.прибыль_в_месяцBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.прибыль_в_месяцBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.прибыль_в_месяцBindingNavigatorSaveItem.Click += new System.EventHandler(this.прибыль_в_месяцBindingNavigatorSaveItem_Click);
            // 
            // прибыль_в_месяцDataGridView
            // 
            this.прибыль_в_месяцDataGridView.AutoGenerateColumns = false;
            this.прибыль_в_месяцDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.прибыль_в_месяцDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.прибыль_в_месяцDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.прибыль_в_месяцDataGridView.DataSource = this.прибыль_в_месяцBindingSource;
            this.прибыль_в_месяцDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.прибыль_в_месяцDataGridView.Location = new System.Drawing.Point(0, 25);
            this.прибыль_в_месяцDataGridView.Name = "прибыль_в_месяцDataGridView";
            this.прибыль_в_месяцDataGridView.Size = new System.Drawing.Size(697, 449);
            this.прибыль_в_месяцDataGridView.TabIndex = 2;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "код_документа";
            this.dataGridViewTextBoxColumn2.DataSource = this.документBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "Код";
            this.dataGridViewTextBoxColumn2.HeaderText = "код_документа";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "Код";
            // 
            // документBindingSource
            // 
            this.документBindingSource.DataMember = "документ";
            this.документBindingSource.DataSource = this.baseDataSet;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "код_организации";
            this.dataGridViewTextBoxColumn3.DataSource = this.организацияпоставщикBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Код";
            this.dataGridViewTextBoxColumn3.HeaderText = "код_организации";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "Код";
            // 
            // организацияпоставщикBindingSource
            // 
            this.организацияпоставщикBindingSource.DataMember = "организация_поставщик";
            this.организацияпоставщикBindingSource.DataSource = this.baseDataSet;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "итоговая_прибыль";
            this.dataGridViewTextBoxColumn4.HeaderText = "итоговая_прибыль";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // документTableAdapter
            // 
            this.документTableAdapter.ClearBeforeFill = true;
            // 
            // продуктBindingSource
            // 
            this.продуктBindingSource.DataMember = "продукт";
            this.продуктBindingSource.DataSource = this.baseDataSet;
            // 
            // продуктTableAdapter
            // 
            this.продуктTableAdapter.ClearBeforeFill = true;
            // 
            // продуктDataGridView
            // 
            this.продуктDataGridView.AutoGenerateColumns = false;
            this.продуктDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.продуктDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.продуктDataGridView.DataSource = this.продуктBindingSource;
            this.продуктDataGridView.Location = new System.Drawing.Point(362, 194);
            this.продуктDataGridView.Name = "продуктDataGridView";
            this.продуктDataGridView.Size = new System.Drawing.Size(300, 220);
            this.продуктDataGridView.TabIndex = 3;
            this.продуктDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Код";
            this.dataGridViewTextBoxColumn5.HeaderText = "Код";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "название";
            this.dataGridViewTextBoxColumn6.HeaderText = "название";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "цена";
            this.dataGridViewTextBoxColumn7.HeaderText = "цена";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // процентыBindingSource
            // 
            this.процентыBindingSource.DataMember = "проценты";
            this.процентыBindingSource.DataSource = this.baseDataSet;
            // 
            // процентыTableAdapter
            // 
            this.процентыTableAdapter.ClearBeforeFill = true;
            // 
            // процентыDataGridView
            // 
            this.процентыDataGridView.AutoGenerateColumns = false;
            this.процентыDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.процентыDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.процентыDataGridView.DataSource = this.процентыBindingSource;
            this.процентыDataGridView.Location = new System.Drawing.Point(362, 101);
            this.процентыDataGridView.Name = "процентыDataGridView";
            this.процентыDataGridView.Size = new System.Drawing.Size(300, 220);
            this.процентыDataGridView.TabIndex = 4;
            this.процентыDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Код";
            this.dataGridViewTextBoxColumn8.HeaderText = "Код";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "код_сроков";
            this.dataGridViewTextBoxColumn9.HeaderText = "код_сроков";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "процент_в_месяц";
            this.dataGridViewTextBoxColumn10.HeaderText = "процент_в_месяц";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // документDataGridView
            // 
            this.документDataGridView.AutoGenerateColumns = false;
            this.документDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.документDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.документDataGridView.DataSource = this.документBindingSource;
            this.документDataGridView.Location = new System.Drawing.Point(306, 177);
            this.документDataGridView.Name = "документDataGridView";
            this.документDataGridView.Size = new System.Drawing.Size(300, 220);
            this.документDataGridView.TabIndex = 5;
            this.документDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Код";
            this.dataGridViewTextBoxColumn11.HeaderText = "Код";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "наименование документа";
            this.dataGridViewTextBoxColumn12.HeaderText = "наименование документа";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "код_процентов";
            this.dataGridViewTextBoxColumn13.HeaderText = "код_процентов";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "код_продукта";
            this.dataGridViewTextBoxColumn14.HeaderText = "код_продукта";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "сумма";
            this.dataGridViewTextBoxColumn15.HeaderText = "сумма";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 512);
            this.Controls.Add(this.прибыль_в_месяцDataGridView);
            this.Controls.Add(this.прибыль_в_месяцBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.процентыDataGridView);
            this.Controls.Add(this.продуктDataGridView);
            this.Controls.Add(this.документDataGridView);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Прибыль в месяц";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form5_FormClosed);
            this.Load += new System.EventHandler(this.Form5_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.прибыль_в_месяцBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.прибыль_в_месяцBindingNavigator)).EndInit();
            this.прибыль_в_месяцBindingNavigator.ResumeLayout(false);
            this.прибыль_в_месяцBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.прибыль_в_месяцDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.документBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.организацияпоставщикBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.процентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.процентыDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.документDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private baseDataSet baseDataSet;
        private System.Windows.Forms.BindingSource прибыль_в_месяцBindingSource;
        private baseDataSetTableAdapters.прибыль_в_месяцTableAdapter прибыль_в_месяцTableAdapter;
        private baseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator прибыль_в_месяцBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton прибыль_в_месяцBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView прибыль_в_месяцDataGridView;
        private baseDataSetTableAdapters.документTableAdapter документTableAdapter;
        private System.Windows.Forms.BindingSource документBindingSource;
        private baseDataSetTableAdapters.организация_поставщикTableAdapter организация_поставщикTableAdapter;
        private System.Windows.Forms.BindingSource организацияпоставщикBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource продуктBindingSource;
        private baseDataSetTableAdapters.продуктTableAdapter продуктTableAdapter;
        private System.Windows.Forms.DataGridView продуктDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.BindingSource процентыBindingSource;
        private baseDataSetTableAdapters.процентыTableAdapter процентыTableAdapter;
        private System.Windows.Forms.DataGridView процентыDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridView документDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
    }
}