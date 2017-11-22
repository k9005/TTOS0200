using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMK
{
    class Laitos
    {
        string Name { get; set; }
        public List<Tutkinto> Tutkintotyyppi;

        public Laitos(string name)
        {
            Name = name;
            Tutkintotyyppi = new List<Tutkinto>();
        }
        public override string ToString()
        {
            string retval = Name + " sisältö\n";
            foreach (Tutkinto item in Tutkintotyyppi)
            {
                retval += item.ToString() + "\n";
            }
            return retval;
        }
    }
}
