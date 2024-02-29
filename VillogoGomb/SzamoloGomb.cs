using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillogoGomb
{
    internal class SzamoloGomb : Button
    {
        int szám = 0;
        public SzamoloGomb()
        {
            Height = 20;
            Width = 20;
            MouseClick += SzamoloGomb_MouseClick;


        }

        private void SzamoloGomb_MouseClick(object? sender, MouseEventArgs e)
        {

            if (szám == 5) 
                szám = 0;
            szám ++;
            Text = szám.ToString();

        }
    }
}
