using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Ultraspikebalatonosja
{
    class Balcsika
    {
        public string Nev { get; set; }
        public int Rajtszam { get; set; }
        public string VersenyzoKategoria { get; set; }
        public int IdoEredmeny { get; set; }
        public int TeljesTav { get; set; }

        public Balcsika(string r)
        {
        string[] v = r.Split(";");
            Nev = v[0];
            Rajtszam = v[1];
            VersenyzoKategoria = v[2];
            IdoEredmeny = v[3];
            TeljesTav = v[4];
        }
    }
}

