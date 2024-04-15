namespace Hajos
{
    public partial class Form1 : Form
    {
        List<K�rd�s> �sszesk�rd�s;
        List<K�rd�s> Aktu�lisK�rd�sek = new List<K�rd�s>();
        int Megjelene�tettK�rd�sekSz�ma = 5;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            �sszesk�rd�s = K�rd�sekBeolvas�sa();
            for (int i = 0; i < 7; i++)
            {
                Aktu�lisK�rd�sek.Add(�sszesk�rd�s[0]);
                �sszesk�rd�s.RemoveAt(0);
            }
            dataGridView2.DataSource = Aktu�lisK�rd�sek;
            K�rd�sMegjelen�t�se(Aktu�lisK�rd�sek[Megjelene�tettK�rd�sekSz�ma]);
        }
        void K�rd�sMegjelen�t�se(K�rd�s k�rd�s)
        {
            label1.Text = k�rd�s.K�rd�sSz�veg;
            textBox1.Text = k�rd�s.V�lasz1;
            textBox2.Text = k�rd�s.V�lasz2;
            textBox3.Text = k�rd�s.V�lasz3;

            if (string.IsNullOrEmpty(k�rd�s.URL))
            {
                pictureBox1.Visible = false;

            }
            else
            {
                pictureBox1.Visible = true;
                pictureBox1.Load("https://storage.altinum.hu/hajo/" + k�rd�s.URL);
            }

            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;


        }
        List<K�rd�s> K�rd�sekBeolvas�sa()
        {
            List<K�rd�s> k�rd�sek = new();
            StreamReader sr = new("hajozasi_szabalyzat_kerdessor_BOM.txt", true);
            while (!sr.EndOfStream)
            {
                string? sor = sr.ReadLine();
                string[] t�mb = sor.Split("\t");

                if (t�mb.Length != 7) continue;

                K�rd�s k = new();
                k.K�rd�sSz�veg = t�mb[1];
                k.V�lasz1 = t�mb[2];
                k.V�lasz2 = t�mb[3];
                k.V�lasz3 = t�mb[4];
                k.URL = t�mb[5];
                int x = 0;
                int.TryParse(t�mb[6], out x);
                k.HelyesV�lasz = x;
                k�rd�sek.Add(k);
            }



            sr.Close();
            return k�rd�sek;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Megjelene�tettK�rd�sekSz�ma++;
            if (Megjelene�tettK�rd�sekSz�ma == 7) Megjelene�tettK�rd�sekSz�ma = 0;

            K�rd�sMegjelen�t�se(Aktu�lisK�rd�sek[Megjelene�tettK�rd�sekSz�ma]);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            
            if (Aktu�lisK�rd�sek[Megjelene�tettK�rd�sekSz�ma].HelyesV�lasz == 1)
            {
                textBox1.BackColor = Color.LightGreen;
                Aktu�lisK�rd�sek[Megjelene�tettK�rd�sekSz�ma].HelyesV�laszokSz�ma++;

           }
            else
            {
                textBox1.BackColor = Color.Salmon;
                Aktu�lisK�rd�sek[Megjelene�tettK�rd�sekSz�ma].HelyesV�laszokSz�ma = 0;
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (Aktu�lisK�rd�sek[Megjelene�tettK�rd�sekSz�ma].HelyesV�lasz == 1)
            {
                textBox2.BackColor = Color.LightGreen;
                Aktu�lisK�rd�sek[Megjelene�tettK�rd�sekSz�ma].HelyesV�laszokSz�ma++;

            }
            else
            {
                textBox2.BackColor = Color.Salmon;
                Aktu�lisK�rd�sek[Megjelene�tettK�rd�sekSz�ma].HelyesV�laszokSz�ma = 0;
            }
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            if (Aktu�lisK�rd�sek[Megjelene�tettK�rd�sekSz�ma].HelyesV�lasz == 2)
            {
                textBox3.BackColor = Color.LightGreen;
                Aktu�lisK�rd�sek[Megjelene�tettK�rd�sekSz�ma].HelyesV�laszokSz�ma++;

            }
            else
            {
                textBox3.BackColor = Color.Salmon;
                Aktu�lisK�rd�sek[Megjelene�tettK�rd�sekSz�ma].HelyesV�laszokSz�ma = 3;
            }
        }
    }
}