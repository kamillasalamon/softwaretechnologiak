namespace MasodikHet
{
    public partial class Form1 : Form
    {
        public Form1() //konstruktor
        {
            InitializeComponent();

            //gomb l�trehoz�sa: 
            //Button gomb = new Button() //gomb l�trehoz�sa
            //gomb.Text = "OK"; //gomb felirat
            //gomb.Height = 30; //sz�less�g magass�g
            //gomb.Width = 30;
            //gomb.Top = 100; //f�gg�leges tengely
            //gomb.Left = 200; //v�zszintes tengely

            //fibonacci1:
            //for (int i = 0; i < 10; i++)
            //{
            //    Button gomb = new Button();
            //    gomb.Width = 30;
            //    gomb.Height = 30;
            //    gomb.Top = gomb.Height * i;
            //    gomb.Text= Fibonacci(i).ToString();
            //    Controls.Add(gomb);
            //}


            //bal fels� sarok alap�rtelmezett, koordin�t�ja 0:0


            //fibonacci 2:
            //List<Sor> lista = new List<Sor>();
            //for (int i = 0; i < 10; i++)
            //{
            //    Sor sor = new Sor();
            //    sor.Szam = Fibonacci(i);
            //    lista.Add(sor);
            //}

            //dataGridView1.DataSource = lista;


            //szorz�t�bla:
            //int buttonSize = 40;
            //for (int row = 1; row < 11; row++)
            //{
            //    for (int col = 1; col < 11; col++)
            //    {
            //        Button btn = new Button();
            //        btn.Height = buttonSize;
            //        btn.Width = buttonSize;
            //        btn.Left = col * buttonSize;
            //        btn.Top = row * buttonSize;
            //        btn.Text = (row * col).ToString();
            //        this.Controls.Add(btn);
            //    }
            //}

            //sakkt�bla:
            int buttonSize = 40;
            for (int row = 1; row < 9; row++)
            {
                for (int col = 1; col < 9; col++)
                {
                    Button btn = new Button();
                    btn.Height = buttonSize;
                    btn.Width = buttonSize;
                    btn.Left = col * buttonSize;
                    btn.Top = row * buttonSize;
                    int a= row+col;
                    if (a % 2 == 0) 
                    { 
                        btn.BackColor= Color.Black;
                    }

                    this.Controls.Add(btn);
                }
            }

        }

        int Fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}