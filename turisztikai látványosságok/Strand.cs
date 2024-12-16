using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turisztikai_látványosságok
{
    public class Strand : Latvanyossag
    {
        public bool Zart { get; set; }
        public List<string> Csuszdak { get; set; }
        public int AraOrankent { get; set; }

     
        public Strand(string orszag, string varos, string megnevezes, int nyitvaKezdete, int nyitvaVege, bool zart, int araOrankent)
            : base(orszag, varos, megnevezes, nyitvaKezdete, nyitvaVege)
        {
            Zart = zart;
            AraOrankent = araOrankent;
            Csuszdak = new List<string>();
        }

        
        public void CsuszdaHozzaad(string csuszda)
        {
            Csuszdak.Add(csuszda);
        }

        public void CsuszdaHozzaad(List<string> csuszdaLista)
        {
            Csuszdak.AddRange(csuszdaLista);
        }
    }

}
