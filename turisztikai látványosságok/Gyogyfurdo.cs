using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turisztikai_látványosságok
{
    public class Gyogyfurdo : Strand
    {
        public int Korhatar { get; set; }
        public bool Masszazs { get; set; }

        
        public Gyogyfurdo(string orszag, string varos, string megnevezes, int nyitvaKezdete, int nyitvaVege, bool zart, int araOrankent, int korhatar, bool masszazs)
            : base(orszag, varos, megnevezes, nyitvaKezdete, nyitvaVege, zart, araOrankent)
        {
            Korhatar = korhatar;
            Masszazs = masszazs;
            Csuszdak = new List<string>();
        }
    }
}
