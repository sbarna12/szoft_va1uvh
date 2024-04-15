using System.Diagnostics;
using System.Windows.Forms.VisualStyles;

namespace gyaki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("jatek.csv", encoding:default);
            int sorszam = 0;
            while (!sr.EndOfStream)
            {

                string sor = sr.ReadLine();
                string[] st = sor.Split(';');
                string kerdes = st[0];
                string v1 = st[1];
                string v2 = st[2];
                string v3 = st[3];
                string v4 = st[4];
                int jóvalasz = int.Parse(st[5]);






                string kerdes = sr.ReadLine();
                string valasz1=sr.ReadLine();
                string valasz2=sr.ReadLine();
                string valasz3 = sr.ReadLine();
                string valasz4 = sr.ReadLine();
                int joválasz = int.Parse(sr.ReadLine());

                KérdésUserControl uc = new KérdésUserControl(kerdes, valasz1, valasz2, valasz3, valasz4, joválasz);

                Controls.Add(uc);
                uc.Top= sorszam*uc.Height+1;
                

                Trace.WriteLine($"{sorszam} - {kerdes}");
                sorszam++;
                if (sorszam == 100) break;
            }




            sr.Close();
        }
    }
}
