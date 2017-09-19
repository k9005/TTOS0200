using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuivaaja
{
    class Hiustenkuivaaja
    {
        public bool paalla { get; set; }
        public int lampo { get; set; }
        public int voima { get; set; }
        public Hiustenkuivaaja(bool paalla, int kanava, int volume) : base()
        {
            this.paalla = paalla;
            this.lampo = lampo;
            this.voima = voima;
        }
        public Hiustenkuivaaja()
        {
        }
        public string startting()
        {
            return "huuuuu";
        }
        public string strong()
        {
            return "\nHOOOO";
        }


    }
}
    
