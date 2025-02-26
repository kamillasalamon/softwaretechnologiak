namespace ElsoHet
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnOk = new Button();
            tbHitelÖsszege = new TextBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            tbHaviKamat = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cbHaviTörlesztő = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.Location = new Point(532, 192);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(122, 23);
            btnOk.TabIndex = 0;
            btnOk.Text = "button1";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // tbHitelÖsszege
            // 
            tbHitelÖsszege.ForeColor = SystemColors.MenuText;
            tbHitelÖsszege.Location = new Point(532, 45);
            tbHitelÖsszege.Name = "tbHitelÖsszege";
            tbHitelÖsszege.Size = new Size(122, 23);
            tbHitelÖsszege.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(240, 426);
            dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(413, 53);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 3;
            label1.Text = "Hitel összeg:";
            // 
            // tbHaviKamat
            // 
            tbHaviKamat.ForeColor = SystemColors.MenuText;
            tbHaviKamat.Location = new Point(532, 85);
            tbHaviKamat.Name = "tbHaviKamat";
            tbHaviKamat.Size = new Size(122, 23);
            tbHaviKamat.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(413, 93);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 3;
            label2.Text = "Havi kamat:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(413, 136);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 3;
            label3.Text = "Havi törlesztő:";
            // 
            // cbHaviTörlesztő
            // 
            cbHaviTörlesztő.FormattingEnabled = true;
            cbHaviTörlesztő.Items.AddRange(new object[] { "100", "200", "500", "1000" });
            cbHaviTörlesztő.Location = new Point(532, 133);
            cbHaviTörlesztő.Name = "cbHaviTörlesztő";
            cbHaviTörlesztő.Size = new Size(122, 23);
            cbHaviTörlesztő.TabIndex = 4;
            cbHaviTörlesztő.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbHaviTörlesztő);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(tbHaviKamat);
            Controls.Add(tbHitelÖsszege);
            Controls.Add(btnOk);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOk;
        private TextBox tbHitelÖsszege;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox tbHaviKamat;
        private Label label2;
        private Label label3;
        private ComboBox cbHaviTörlesztő;
    }
}