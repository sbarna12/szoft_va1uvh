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
            List<K�rd�s> �sszesk�rd�s;
            List<K�rd�s> Akt�vK�rd�sek;
            int Akt�vK�rd�s = 5;


            List<K�rd�s> K�rd�sBeolvas�s()
            {
                List<K�rd�s> k�rd�sek = new List<K�rd�s>();


                StreamReader sr = new StreamReader("hajozasi_szabalyzat_kerdessor_BOM.txt",true);

                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine();

                    string[] t�mb = sor.Split('\t');

                    K�rd�s k = new K�rd�s();
                    k.K�rd�sSz�veg = t�mb[0];
                    k.V�lasz1 = t�mb[1];
                    k.V�lasz1 = t�mb[2];
                    k.V�lasz2 = t�mb[3];
                    k.V�lasz3 = t�mb[4];
                    k.URL = t�mb[5];
                    int.TryParse(t�mb[6], out int j�v�lasz);
                    k.HelyesV�lasz = j�v�lasz;
                    k�rd�sek.Add(k);
                }

                sr.Close();
                return k�rd�sek;
            }

         }
    }
}
