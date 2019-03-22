using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZamanliExeCalistirici
{
    public class Zaman
    {
        public int Gun { get; set; }
        public int Saat { get; set; }
        public int Dakika { get; set; }

        public Zaman(string gun,string saat,string dakika)
        {
            Gun = Convert.ToInt32(gun);
            Saat = Convert.ToInt32(saat);
            Dakika = Convert.ToInt32(dakika);
        }

    }
}
