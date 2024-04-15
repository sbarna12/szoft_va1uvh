namespace HajosTeszt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Kérdés> Összeskérdés;
            List<Kérdés> AktívKérdések;
            int AktívKérdés = 5;


            List<Kérdés> KérdésBeolvasás()
            {
                List<Kérdés> kérdések = new List<Kérdés>();


                StreamReader sr = new StreamReader("hajozasi_szabalyzat_kerdessor_BOM.txt",true);

                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine();

                    string[] tömb = sor.Split('\t');

                    Kérdés k = new Kérdés();
                    k.KérdésSzöveg = tömb[0];
                    k.Válasz1 = tömb[1];
                    k.Válasz1 = tömb[2];
                    k.Válasz2 = tömb[3];
                    k.Válasz3 = tömb[4];
                    k.URL = tömb[5];
                    int.TryParse(tömb[6], out int jóválasz);
                    k.HelyesVálasz = jóválasz;
                    kérdések.Add(k);
                }

                sr.Close();
                return kérdések;
            }

         }
    }
}
