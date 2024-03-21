using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace kigyos
{
    class KígyóElem : PictureBox
    {
        public static int Méret = 10;

        public KígyóElem()
        {
            Width = KígyóElem.Méret;
            Height = KígyóElem.Méret;
            BackColor = Color.Blue;

        }


    }

    class Alma : KígyóElem
    {
        public Alma()
        {
            BackColor = Color.Green;
        }
    }

}

