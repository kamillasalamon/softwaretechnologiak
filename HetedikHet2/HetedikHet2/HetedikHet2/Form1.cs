using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace HetedikHet2
{
    public partial class Form1 : Form
    {
        BindingList<CountryData> countryData = new();

        public Form1()
        {
            InitializeComponent();
            //dataGridView1.DataSource = countryData;
            countryDataBindingSource.DataSource = countryData;
            dataGridView1.DataSource = countryDataBindingSource;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (var reader = new StreamReader("european_countries.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var rekordok = csv.GetRecords<CountryData>();
                foreach (var rekord in rekordok)
                {
                    countryData.Add(rekord);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            countryDataBindingSource.RemoveCurrent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCountryE fce = new FormCountryE();
            fce.CountryData= countryDataBindingSource.Current as CountryData;
            fce.ShowDialog();
        }
    }

}