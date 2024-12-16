using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turisztikai_látványosságok
{
    public abstract class Latvanyossag
    {
        public string Orszag { get; set; }
        public string Varos { get; set; }
        public string Megnevezes { get; set; }
        public int NyitvaKezdete { get; set; }
        public int NyitvaVege { get; set; }

     
        public Latvanyossag(string orszag, string varos, string megnevezes, int nyitvaKezdete, int nyitvaVege)
        {
            Orszag = orszag;
            Varos = varos;
            Megnevezes = megnevezes;
            NyitvaKezdete = nyitvaKezdete;
            NyitvaVege = nyitvaVege;
        }

        public Latvanyossag(string orszag, string varos, string megnevezes)
            : this(orszag, varos, megnevezes, 0, 24) { }
    }
}
