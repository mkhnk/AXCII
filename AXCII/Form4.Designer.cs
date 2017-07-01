namespace AXCII
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.baseDataSet = new AXCII.baseDataSet();
            this.операцияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.операцияTableAdapter = new AXCII.baseDataSetTableAdapters.операцияTableAdapter();
            this.tableAdapterManager = new AXCII.baseDataSetTableAdapters.TableAdapterManager();
            this.операцияBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.операцияBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.операцияDataGridView = new System.Windows.Forms.DataGridView();
            this.организацияклиентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.организация_клиентTableAdapter = new AXCII.baseDataSetTableAdapters.организация_клиентTableAdapter();
            this.организацияпоставщикBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.организация_поставщикTableAdapter = new AXCII.baseDataSetTableAdapters.организация_поставщикTableAdapter();
            this.документBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.документTableAdapter = new AXCII.baseDataSetTableAdapters.документTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.операцияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.операцияBindingNavigator)).BeginInit();
            this.операцияBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.операцияDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.организацияклиентBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.организацияпоставщикBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.документBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 461);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 38);
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
            // операцияBindingSource
            // 
            this.операцияBindingSource.DataMember = "операция";
            this.операцияBindingSource.DataSource = this.baseDataSet;
            // 
            // операцияTableAdapter
            // 
            this.операцияTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = AXCII.baseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.операцияTableAdapter = this.операцияTableAdapter;
            this.tableAdapterManager.организация_клиентTableAdapter = null;
            this.tableAdapterManager.организация_поставщикTableAdapter = null;
            this.tableAdapterManager.прибыль_в_месяцTableAdapter = null;
            this.tableAdapterManager.продуктTableAdapter = null;
            this.tableAdapterManager.процентыTableAdapter = null;
            this.tableAdapterManager.срокиTableAdapter = null;
            // 
            // операцияBindingNavigator
            // 
            this.операцияBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.операцияBindingNavigator.BindingSource = this.операцияBindingSource;
            this.операцияBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.операцияBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.операцияBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.операцияBindingNavigatorSaveItem});
            this.операцияBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.операцияBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.операцияBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.операцияBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.операцияBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.операцияBindingNavigator.Name = "операцияBindingNavigator";
            this.операцияBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.операцияBindingNavigator.Size = new System.Drawing.Size(760, 25);
            this.операцияBindingNavigator.TabIndex = 1;
            this.операцияBindingNavigator.Text = "bindingNavigator1";
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
            // операцияBindingNavigatorSaveItem
            // 
            this.операцияBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.операцияBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("операцияBindingNavigatorSaveItem.Image")));
            this.операцияBindingNavigatorSaveItem.Name = "операцияBindingNavigatorSaveItem";
            this.операцияBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.операцияBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.операцияBindingNavigatorSaveItem.Click += new System.EventHandler(this.операцияBindingNavigatorSaveItem_Click);
            // 
            // операцияDataGridView
            // 
            this.операцияDataGridView.AutoGenerateColumns = false;
            this.операцияDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.операцияDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.операцияDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.операцияDataGridView.DataSource = this.операцияBindingSource;
            this.операцияDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.операцияDataGridView.Location = new System.Drawing.Point(0, 25);
            this.операцияDataGridView.Name = "операцияDataGridView";
            this.операцияDataGridView.Size = new System.Drawing.Size(760, 436);
            this.операцияDataGridView.TabIndex = 2;
            // 
            // организацияклиентBindingSource
            // 
            this.организацияклиентBindingSource.DataMember = "организация_клиент";
            this.организацияклиентBindingSource.DataSource = this.baseDataSet;
            // 
            // организация_клиентTableAdapter
            // 
            this.организация_клиентTableAdapter.ClearBeforeFill = true;
            // 
            // организацияпоставщикBindingSource
            // 
            this.организацияпоставщикBindingSource.DataMember = "организация_поставщик";
            this.организацияпоставщикBindingSource.DataSource = this.baseDataSet;
            // 
            // организация_поставщикTableAdapter
            // 
            this.организация_поставщикTableAdapter.ClearBeforeFill = true;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "операция";
            this.dataGridViewTextBoxColumn2.HeaderText = "операция";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "код_исходящей_организации";
            this.dataGridViewTextBoxColumn3.DataSource = this.организацияклиентBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Код";
            this.dataGridViewTextBoxColumn3.HeaderText = "код_исходящей_организации";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "Код";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "код_входящей_организации";
            this.dataGridViewTextBoxColumn4.DataSource = this.организацияпоставщикBindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "Код";
            this.dataGridViewTextBoxColumn4.HeaderText = "код_входящей_организации";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "Код";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "код_документа";
            this.dataGridViewTextBoxColumn5.DataSource = this.документBindingSource;
            this.dataGridViewTextBoxColumn5.DisplayMember = "Код";
            this.dataGridViewTextBoxColumn5.HeaderText = "код_документа";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn5.ValueMember = "Код";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 499);
            this.Controls.Add(this.операцияDataGridView);
            this.Controls.Add(this.операцияBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Операция";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form4_FormClosed);
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.операцияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.операцияBindingNavigator)).EndInit();
            this.операцияBindingNavigator.ResumeLayout(false);
            this.операцияBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.операцияDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.организацияклиентBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.организацияпоставщикBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.документBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource операцияBindingSource;
        private baseDataSetTableAdapters.операцияTableAdapter операцияTableAdapter;
        private baseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator операцияBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton операцияBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView операцияDataGridView;
        private System.Windows.Forms.BindingSource организацияклиентBindingSource;
        private baseDataSetTableAdapters.организация_клиентTableAdapter организация_клиентTableAdapter;
        private System.Windows.Forms.BindingSource организацияпоставщикBindingSource;
        private baseDataSetTableAdapters.организация_поставщикTableAdapter организация_поставщикTableAdapter;
        private System.Windows.Forms.BindingSource документBindingSource;
        private baseDataSetTableAdapters.документTableAdapter документTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn5;
    }
}