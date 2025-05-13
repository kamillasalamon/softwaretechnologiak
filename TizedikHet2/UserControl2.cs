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
    public partial class UserControl2 : UserControl
    {
        BikestoreModels.SeBikestoreContext context = new();
        public UserControl2()
        {
            InitializeComponent();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            var xxx = from x in context.Products
                      select new
                      {
                          ProductName__ = x.ProductName,
                          CategoryName__ = x.CategoryFkNavigation.CategoryName,
                          Brand__ = x.Brand.BrandName,
                          Prájsz = x.ListPrice
                      };

            dataGridView1.DataSource = xxx.ToList();
        }
    }
}
