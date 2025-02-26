namespace ElsoHet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            decimal hitel�sszeg = decimal.Parse(tbHitel�sszege.Text); //sz�vegb�l decimal: Parse
            decimal haviKamat = decimal.Parse(tbHaviKamat.Text);
            decimal haviT�rleszt� = decimal.Parse(cbHaviT�rleszt�.Text);

            decimal h�tral�k = hitel�sszeg;
            decimal befizet�s = 0;

            List<Sor> sorok = new List<Sor>(); //lista

            int h�nap = 0;
            while (h�tral�k > 0)
            {
                h�tral�k += haviKamat * (h�tral�k / 100m); // a 100as egy decimal az m miatt

                decimal t�nylegesT�rleszt� = Math.Min(h�tral�k, haviT�rleszt�);

                h�tral�k -= t�nylegesT�rleszt�; // h�tral�k = h�tral�k - haviT�rleszt�
                befizet�s += t�nylegesT�rleszt�; // befizet�s = befizet�s + haviT�rleszt�
                h�nap++;

                Sor �jSor = new Sor();
                �jSor.H�tral�k = Math.Round(h�tral�k);
                �jSor.H�nap = h�nap;
                �jSor.Befizet�s = befizet�s;

                sorok.Add(�jSor);
            }

            dataGridView1.DataSource = sorok;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}