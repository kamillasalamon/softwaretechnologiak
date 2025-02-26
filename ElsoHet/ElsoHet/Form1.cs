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
            decimal hitelÖsszeg = decimal.Parse(tbHitelÖsszege.Text); //szövegbõl decimal: Parse
            decimal haviKamat = decimal.Parse(tbHaviKamat.Text);
            decimal haviTörlesztõ = decimal.Parse(cbHaviTörlesztõ.Text);

            decimal hátralék = hitelÖsszeg;
            decimal befizetés = 0;

            List<Sor> sorok = new List<Sor>(); //lista

            int hónap = 0;
            while (hátralék > 0)
            {
                hátralék += haviKamat * (hátralék / 100m); // a 100as egy decimal az m miatt

                decimal ténylegesTörlesztÕ = Math.Min(hátralék, haviTörlesztõ);

                hátralék -= ténylegesTörlesztÕ; // hátralék = hátralék - haviTörlesztõ
                befizetés += ténylegesTörlesztÕ; // befizetés = befizetés + haviTörlesztõ
                hónap++;

                Sor újSor = new Sor();
                újSor.Hátralék = Math.Round(hátralék);
                újSor.Hónap = hónap;
                újSor.Befizetés = befizetés;

                sorok.Add(újSor);
            }

            dataGridView1.DataSource = sorok;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}