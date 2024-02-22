namespace fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Sor> sorok = new List<Sor>();

            for (int i = 0; i < 30; i++)
            {
                Sor �jSor = new Sor();
                �jSor.Sorsz�m = i;
                �jSor.�rt�k = Fibonacci(i);



                Button button = new Button();

                button.Text = Fibonacci(i).ToString();
                button.Top = i * 25;
                sorok.Add(�jSor);
                Controls.Add(button);
            }
            dataGridView1.DataSource = sorok;

        }

        int Fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}