using System.Diagnostics;

namespace Gyakorlas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("jatek2.txt");
            int sorszam = 0;
            while (!sr.EndOfStream)
            {
                string s = sr.ReadLine();
                Trace.WriteLine($"{sorszam} - {s}");
                sorszam++;
                if (sorszam == 100) break;
            }


            

            sr.Close();
        }
    }
}
