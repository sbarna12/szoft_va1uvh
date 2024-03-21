namespace kigyos
{
    public partial class Form1 : Form
    {
        int fej_x = 100;
        int fej_y = 100;
        int irány_x = 1;
        int irány_y = 0;
        int hossz = 5;
        int lépésszám = 0;

        
        List<KígyóElem> kígyó = new();
        Random random = new();
        Alma alma = new Alma();
      
        public Form1()
        {
            InitializeComponent();


            int almaX = random.Next(0, ClientRectangle.Width / KígyóElem.Méret) * KígyóElem.Méret;
            int almaY = random.Next(0, ClientRectangle.Width / KígyóElem.Méret) * KígyóElem.Méret;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lépésszám++;
            int almaX = random.Next(0, ClientRectangle.Width / KígyóElem.Méret) * KígyóElem.Méret;
            int almaY = random.Next(0, ClientRectangle.Width / KígyóElem.Méret) * KígyóElem.Méret;
            alma.Top = almaX;
            alma.Left = almaY;
            Controls.Add(alma);

            //Fejnövesztés
            fej_x += irány_x * KígyóElem.Méret;
            fej_y += irány_y * KígyóElem.Méret;


            foreach (KígyóElem item in Controls)
            {
                if (item.Top == almaY && item.Left == almaX)
                {
                    hossz++;
                }

                else{
                    if (item.Top == fej_y && item.Left == fej_x)
                    {
                        timer1.Enabled = false;
                        return;
                    }
                }
                
                
            }

            





            KígyóElem ke = new KígyóElem();
            ke.Top = fej_y;
            ke.Left = fej_x;
            Controls.Add(ke);
            kígyó.Add(ke);

            if (lépésszám % 2 == 0) ke.BackColor = Color.Red;

            if (Controls.Count > hossz)
            {
                KígyóElem levágandó = kígyó[0];
                kígyó.RemoveAt(0);
                Controls.Remove(levágandó);
            }
            
            


        }




        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                irány_y = -1;
                irány_x = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                irány_y = 1;
                irány_x = 0;
            }

            if (e.KeyCode == Keys.Left)
            {
                irány_y = 0;
                irány_x = -1;
            }

            if (e.KeyCode == Keys.Right)
            {
                irány_y = 0;
                irány_x = 1;
            }
        }
    }
}