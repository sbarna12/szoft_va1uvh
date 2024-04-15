namespace kigyos
{
    public partial class Form1 : Form
    {
        int fej_x = 100;
        int fej_y = 100;
        int ir�ny_x = 1;
        int ir�ny_y = 0;
        int hossz = 5;
        int l�p�ssz�m = 0;

        
        List<K�gy�Elem> k�gy� = new();
        Random random = new();
        Alma alma = new Alma();
      
        public Form1()
        {
            InitializeComponent();


            int almaX = random.Next(0, ClientRectangle.Width / K�gy�Elem.M�ret) * K�gy�Elem.M�ret;
            int almaY = random.Next(0, ClientRectangle.Width / K�gy�Elem.M�ret) * K�gy�Elem.M�ret;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            l�p�ssz�m++;
            int almaX = random.Next(0, ClientRectangle.Width / K�gy�Elem.M�ret) * K�gy�Elem.M�ret;
            int almaY = random.Next(0, ClientRectangle.Width / K�gy�Elem.M�ret) * K�gy�Elem.M�ret;
            alma.Top = almaX;
            alma.Left = almaY;
            Controls.Add(alma);

            //Fejn�veszt�s
            fej_x += ir�ny_x * K�gy�Elem.M�ret;
            fej_y += ir�ny_y * K�gy�Elem.M�ret;


            foreach (K�gy�Elem item in Controls)
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

            





            K�gy�Elem ke = new K�gy�Elem();
            ke.Top = fej_y;
            ke.Left = fej_x;
            Controls.Add(ke);
            k�gy�.Add(ke);

            if (l�p�ssz�m % 2 == 0) ke.BackColor = Color.Red;

            if (Controls.Count > hossz)
            {
                K�gy�Elem lev�gand� = k�gy�[0];
                k�gy�.RemoveAt(0);
                Controls.Remove(lev�gand�);
            }
            
            


        }




        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                ir�ny_y = -1;
                ir�ny_x = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                ir�ny_y = 1;
                ir�ny_x = 0;
            }

            if (e.KeyCode == Keys.Left)
            {
                ir�ny_y = 0;
                ir�ny_x = -1;
            }

            if (e.KeyCode == Keys.Right)
            {
                ir�ny_y = 0;
                ir�ny_x = 1;
            }
        }
    }
}