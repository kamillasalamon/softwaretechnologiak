using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HetedikHet2
{
    public partial class FormCountryE : Form
    {
        public CountryData CountryData;
        public FormCountryE()
        {
            InitializeComponent();
           
        }

        private void FormCountryE_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = CountryData;
        }
    }
}
