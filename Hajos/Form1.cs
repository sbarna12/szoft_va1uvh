namespace Hajos
{
    public partial class Form1 : Form
    {
        List<Kérdés> Összeskérdés;
        List<Kérdés> AktuálisKérdések = new List<Kérdés>();
        int MegjeleneítettKérdésekSzáma = 5;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Összeskérdés = KérdésekBeolvasása();
            for (int i = 0; i < 7; i++)
            {
                AktuálisKérdések.Add(Összeskérdés[0]);
                Összeskérdés.RemoveAt(0);
            }
            dataGridView2.DataSource = AktuálisKérdések;
            KérdésMegjelenítése(AktuálisKérdések[MegjeleneítettKérdésekSzáma]);
        }
        void KérdésMegjelenítése(Kérdés kérdés)
        {
            label1.Text = kérdés.KérdésSzöveg;
            textBox1.Text = kérdés.Válasz1;
            textBox2.Text = kérdés.Válasz2;
            textBox3.Text = kérdés.Válasz3;

            if (string.IsNullOrEmpty(kérdés.URL))
            {
                pictureBox1.Visible = false;

            }
            else
            {
                pictureBox1.Visible = true;
                pictureBox1.Load("https://storage.altinum.hu/hajo/" + kérdés.URL);
            }

            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;


        }
        List<Kérdés> KérdésekBeolvasása()
        {
            List<Kérdés> kérdések = new();
            StreamReader sr = new("hajozasi_szabalyzat_kerdessor_BOM.txt", true);
            while (!sr.EndOfStream)
            {
                string? sor = sr.ReadLine();
                string[] tömb = sor.Split("\t");

                if (tömb.Length != 7) continue;

                Kérdés k = new();
                k.KérdésSzöveg = tömb[1];
                k.Válasz1 = tömb[2];
                k.Válasz2 = tömb[3];
                k.Válasz3 = tömb[4];
                k.URL = tömb[5];
                int x = 0;
                int.TryParse(tömb[6], out x);
                k.HelyesVálasz = x;
                kérdések.Add(k);
            }



            sr.Close();
            return kérdések;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MegjeleneítettKérdésekSzáma++;
            if (MegjeleneítettKérdésekSzáma == 7) MegjeleneítettKérdésekSzáma = 0;

            KérdésMegjelenítése(AktuálisKérdések[MegjeleneítettKérdésekSzáma]);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            
            if (AktuálisKérdések[MegjeleneítettKérdésekSzáma].HelyesVálasz == 1)
            {
                textBox1.BackColor = Color.LightGreen;
                AktuálisKérdések[MegjeleneítettKérdésekSzáma].HelyesVálaszokSzáma++;

           }
            else
            {
                textBox1.BackColor = Color.Salmon;
                AktuálisKérdések[MegjeleneítettKérdésekSzáma].HelyesVálaszokSzáma = 0;
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (AktuálisKérdések[MegjeleneítettKérdésekSzáma].HelyesVálasz == 1)
            {
                textBox2.BackColor = Color.LightGreen;
                AktuálisKérdések[MegjeleneítettKérdésekSzáma].HelyesVálaszokSzáma++;

            }
            else
            {
                textBox2.BackColor = Color.Salmon;
                AktuálisKérdések[MegjeleneítettKérdésekSzáma].HelyesVálaszokSzáma = 0;
            }
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            if (AktuálisKérdések[MegjeleneítettKérdésekSzáma].HelyesVálasz == 2)
            {
                textBox3.BackColor = Color.LightGreen;
                AktuálisKérdések[MegjeleneítettKérdésekSzáma].HelyesVálaszokSzáma++;

            }
            else
            {
                textBox3.BackColor = Color.Salmon;
                AktuálisKérdések[MegjeleneítettKérdésekSzáma].HelyesVálaszokSzáma = 3;
            }
        }
    }
}