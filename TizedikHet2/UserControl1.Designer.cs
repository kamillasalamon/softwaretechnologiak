namespace TizedikHet
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            productSkDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            brandIdDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            brandBindingSource = new BindingSource(components);
            categoryFkDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            categoryBindingSource = new BindingSource(components);
            modelYearDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            listPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            brandDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryFkNavigationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderItemsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stocksDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productBindingSource = new BindingSource(components);
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)brandBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { productSkDataGridViewTextBoxColumn, productNameDataGridViewTextBoxColumn, brandIdDataGridViewTextBoxColumn, categoryFkDataGridViewTextBoxColumn, modelYearDataGridViewTextBoxColumn, listPriceDataGridViewTextBoxColumn, brandDataGridViewTextBoxColumn, categoryFkNavigationDataGridViewTextBoxColumn, orderItemsDataGridViewTextBoxColumn, stocksDataGridViewTextBoxColumn });
            dataGridView1.DataSource = productBindingSource;
            dataGridView1.Location = new Point(28, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(896, 489);
            dataGridView1.TabIndex = 0;
            // 
            // productSkDataGridViewTextBoxColumn
            // 
            productSkDataGridViewTextBoxColumn.DataPropertyName = "ProductSk";
            productSkDataGridViewTextBoxColumn.HeaderText = "ProductSk";
            productSkDataGridViewTextBoxColumn.Name = "productSkDataGridViewTextBoxColumn";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // brandIdDataGridViewTextBoxColumn
            // 
            brandIdDataGridViewTextBoxColumn.DataPropertyName = "BrandId";
            brandIdDataGridViewTextBoxColumn.DataSource = brandBindingSource;
            brandIdDataGridViewTextBoxColumn.DisplayMember = "BrandName";
            brandIdDataGridViewTextBoxColumn.HeaderText = "BrandId";
            brandIdDataGridViewTextBoxColumn.Name = "brandIdDataGridViewTextBoxColumn";
            brandIdDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            brandIdDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            brandIdDataGridViewTextBoxColumn.ValueMember = "BrandSk";
            // 
            // brandBindingSource
            // 
            brandBindingSource.DataSource = typeof(BikestoreModels.Brand);
            // 
            // categoryFkDataGridViewTextBoxColumn
            // 
            categoryFkDataGridViewTextBoxColumn.DataPropertyName = "CategoryFk";
            categoryFkDataGridViewTextBoxColumn.DataSource = categoryBindingSource;
            categoryFkDataGridViewTextBoxColumn.DisplayMember = "CategoryName";
            categoryFkDataGridViewTextBoxColumn.HeaderText = "CategoryFk";
            categoryFkDataGridViewTextBoxColumn.Name = "categoryFkDataGridViewTextBoxColumn";
            categoryFkDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            categoryFkDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            categoryFkDataGridViewTextBoxColumn.ValueMember = "CategorySk";
            // 
            // categoryBindingSource
            // 
            categoryBindingSource.DataSource = typeof(BikestoreModels.Category);
            // 
            // modelYearDataGridViewTextBoxColumn
            // 
            modelYearDataGridViewTextBoxColumn.DataPropertyName = "ModelYear";
            modelYearDataGridViewTextBoxColumn.HeaderText = "ModelYear";
            modelYearDataGridViewTextBoxColumn.Name = "modelYearDataGridViewTextBoxColumn";
            // 
            // listPriceDataGridViewTextBoxColumn
            // 
            listPriceDataGridViewTextBoxColumn.DataPropertyName = "ListPrice";
            listPriceDataGridViewTextBoxColumn.HeaderText = "ListPrice";
            listPriceDataGridViewTextBoxColumn.Name = "listPriceDataGridViewTextBoxColumn";
            // 
            // brandDataGridViewTextBoxColumn
            // 
            brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            // 
            // categoryFkNavigationDataGridViewTextBoxColumn
            // 
            categoryFkNavigationDataGridViewTextBoxColumn.DataPropertyName = "CategoryFkNavigation";
            categoryFkNavigationDataGridViewTextBoxColumn.HeaderText = "CategoryFkNavigation";
            categoryFkNavigationDataGridViewTextBoxColumn.Name = "categoryFkNavigationDataGridViewTextBoxColumn";
            // 
            // orderItemsDataGridViewTextBoxColumn
            // 
            orderItemsDataGridViewTextBoxColumn.DataPropertyName = "OrderItems";
            orderItemsDataGridViewTextBoxColumn.HeaderText = "OrderItems";
            orderItemsDataGridViewTextBoxColumn.Name = "orderItemsDataGridViewTextBoxColumn";
            // 
            // stocksDataGridViewTextBoxColumn
            // 
            stocksDataGridViewTextBoxColumn.DataPropertyName = "Stocks";
            stocksDataGridViewTextBoxColumn.HeaderText = "Stocks";
            stocksDataGridViewTextBoxColumn.Name = "stocksDataGridViewTextBoxColumn";
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(BikestoreModels.Product);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(28, 16);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(357, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "UserControl1";
            Size = new Size(951, 556);
            Load += UserControl1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)brandBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource productBindingSource;
        private BindingSource categoryBindingSource;
        private DataGridViewTextBoxColumn productSkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn brandIdDataGridViewTextBoxColumn;
        private BindingSource brandBindingSource;
        private DataGridViewComboBoxColumn categoryFkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modelYearDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn listPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryFkNavigationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn orderItemsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stocksDataGridViewTextBoxColumn;
        private TextBox textBox1;
    }
}
