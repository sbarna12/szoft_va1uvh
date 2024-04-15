namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                
                
                    for (int j = 0; j < 10; j++)
                {

                Button b = new Vil();
                Controls.Add(b);
                b.Height =50;
                b.Width = 50;
                b.Left =i*50+ClientRectangle.Width/2-25;
                b.Top =j*50+ClientRectangle.Height/2-25;
                b.Text=$"{i*j}";
                }
            }
            
        }
    }
}
