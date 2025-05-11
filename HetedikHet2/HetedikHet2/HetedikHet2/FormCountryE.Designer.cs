namespace HetedikHet2
{
    partial class FormCountryE
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            countryDataBindingSource = new BindingSource(components);
            textBox2 = new TextBox();
            countryDataBindingSource1 = new BindingSource(components);
            textBox3 = new TextBox();
            countryDataBindingSource2 = new BindingSource(components);
            bindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)countryDataBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)countryDataBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)countryDataBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 60);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 0;
            label1.Text = "Country name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 144);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 1;
            label2.Text = "Population:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 232);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 2;
            label3.Text = "Area:";
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", countryDataBindingSource, "Name", true));
            textBox1.Location = new Point(89, 89);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(153, 23);
            textBox1.TabIndex = 3;
            // 
            // countryDataBindingSource
            // 
            countryDataBindingSource.DataSource = typeof(CountryData);
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", countryDataBindingSource1, "Population", true));
            textBox2.Location = new Point(85, 176);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(157, 23);
            textBox2.TabIndex = 4;
            // 
            // countryDataBindingSource1
            // 
            countryDataBindingSource1.DataSource = typeof(CountryData);
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", countryDataBindingSource2, "AreaInSquareKm", true));
            textBox3.Location = new Point(85, 262);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(157, 23);
            textBox3.TabIndex = 5;
            // 
            // countryDataBindingSource2
            // 
            countryDataBindingSource2.DataSource = typeof(CountryData);
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(CountryData);
            // 
            // FormCountryE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCountryE";
            Text = "FormCountryE";
            Load += FormCountryE_Load;
            ((System.ComponentModel.ISupportInitialize)countryDataBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)countryDataBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)countryDataBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private BindingSource bindingSource1;
        private BindingSource countryDataBindingSource;
        private BindingSource countryDataBindingSource1;
        private BindingSource countryDataBindingSource2;
    }
}