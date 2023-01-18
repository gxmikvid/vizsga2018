﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vizsga2018_TothMiklos_13
{
    internal class Lakopark
    {
        int[,] hazak;
        int maxHazSzam;
        string nev;
        int utcakSzama;

        public Lakopark(int[,] hazak, int maxHazSzam, string nev, int utcakSzama)
        {
            Hazak = hazak;
            MaxHazSzam = maxHazSzam;
            Nev = nev;
            UtcakSzama = utcakSzama;
        }

        public int[,] Hazak { get => hazak; set => hazak = value; }
        public int MaxHazSzam { get => maxHazSzam; set => maxHazSzam = value; }
        public string Nev { get => nev; set => nev = value; }
        public int UtcakSzama { get => utcakSzama; set => utcakSzama = value; }
    }
}
