using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktörerövningar5inl
{
    class Fordon
    {
        private string tillvärkare;
        private string modell;
        private int år;
        private int vikt;

        public Fordon() 
        {
            tillvärkare = string.Empty;
            modell = string.Empty;
            år = 0;
            vikt = 0;
        }

        public void setTillvärkare(string tillv)
        {
            tillvärkare = tillv;
        }

        public void setModell(string mod)
        {
            modell = mod;
        }

        public void setÅr(int å)
        {
            år = å;
        }

        public void setVikt(int vi)
        {
            vikt = vi;
        }

        public override string ToString()
        {
            return tillvärkare + " " + modell + " " + år + " " + vikt;
        }
    }
}
