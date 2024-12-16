using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turisztikai_látványosságok
{
    public class Muzeum : Latvanyossag
    {
        public string Tema { get; set; }
        public bool JogosultIngyenesUtazasra { get; set; }
        public int Belepo { get; set; }

      
        public Muzeum(string orszag, string varos, string megnevezes, int nyitvaKezdete, int nyitvaVege, string tema, bool jogosultIngyenesUtazasra, int belepo)
            : base(orszag, varos, megnevezes, nyitvaKezdete, nyitvaVege)
        {
            Tema = tema;
            JogosultIngyenesUtazasra = jogosultIngyenesUtazasra;
            Belepo = belepo;
        }

       
        public double CsoportosKedvezmeny(int letszam)
        {
            if (letszam < 10)
                return Belepo * letszam;
            else if (letszam <= 20)
                return Belepo * letszam * 0.8;
            else
                return Belepo * letszam * 0.7;
        }
    }
}
