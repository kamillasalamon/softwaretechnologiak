using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TizedikHet
{
    public partial class UserControl1 : UserControl
    {
        BikestoreModels.SeBikestoreContext context = new();
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            productBindingSource.DataSource = context.Products.ToList();
            categoryBindingSource.DataSource = context.Categories.ToList();
            brandBindingSource.DataSource = context.Brands.ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var xxx = from x in context.Products
                      where x.ProductName.Contains(textBox1.Text)
                      select x;
            productBindingSource.DataSource = xxx.ToList();

        }
    }
}
