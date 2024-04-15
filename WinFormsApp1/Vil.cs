using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Vil : Button
    {
        public Vil() {
            {
                BackColor = Color.White;
                MouseEnter += Vil_MouseEnter;
                MouseLeave += Vil_MouseLeave;

            }

        }

        private void Vil_MouseLeave(object? sender, EventArgs e)
        {
            BackColor = Color.Pink;
        }

        private void Vil_MouseEnter(object? sender, EventArgs e)
        {
            BackColor = Color.Teal;
        }
    }
}
