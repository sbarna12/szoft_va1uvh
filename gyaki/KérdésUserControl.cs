using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gyaki
{
    public partial class KérdésUserControl : UserControl
    {

        int jóválasz;

        public KérdésUserControl()
        {
            InitializeComponent();
        }

        public KérdésUserControl(string k, string v1, string v2, string v3, string v4, int jóválasz)
        {
            InitializeComponent();
            label1.Text = k;
            button1.Text = v1;
            button2.Text = v2;
            button3.Text = v3;
            button4.Text = v4;
            this.jóválasz = jóválasz;
        }



        void szinezd()
        {

            if (jóválasz == 1)
            {
                button1.BackColor = Color.Green;
            }
            if (jóválasz == 2)
            {
                button2.BackColor = Color.Green;
            }
            if (jóválasz == 3)
            {
                button3.BackColor = Color.Green;
            }
            if (jóválasz == 4)
            {
                button4.BackColor = Color.Green;
            }
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
            szinezd();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
            szinezd();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Red;
            szinezd();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Red;
            szinezd();
        }
    }
}
