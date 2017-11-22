using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMK
{
    class Program
    {

        static void Main(string[] args)
        {
            Opintojakso Op1 = new Opintojakso("Olio");

            Op1.Oppilas.Add(new Opiskelija("Kalle Koskinen","Q203", 18));
            Op1.Oppilas.Add(new Opiskelija("Olli Koskinen","asds", 18));
            Op1.Oppilas.Add(new Opiskelija("Pekka Jormakka","", 18));
            Op1.Opettaja.Add(new Opettaja("Arja koriseva","", 59));
            

            Opintojakso Op2 = new Opintojakso("Kertaus");

            Op2.Oppilas.Add(new Opiskelija("Kalle Koskinen", "Q203", 18));
            Op2.Oppilas.Add(new Opiskelija("Olli Koskinen", "asds", 18));
            Op2.Oppilas.Add(new Opiskelija("Pekka Jormakka", "", 18));
            Op2.Opettaja.Add(new Opettaja("Arja koriseva", "", 59));

            Opintojakso Op3 = new Opintojakso("Olio2");

            Op3.Oppilas.Add(new Opiskelija("Kalle Koskinen", "Q203", 18));
            Op3.Oppilas.Add(new Opiskelija("Olli Koskinen", "asds", 18));
            Op3.Oppilas.Add(new Opiskelija("Pekka Jormakka", "", 18));
            Op3.Opettaja.Add(new Opettaja("Arja koriseva", "", 59));

            Tutkinto Tutk1 = new Tutkinto("AMK");
            Tutk1.Jakso.Add(Op1);
            Tutk1.Jakso.Add(Op2);
            Tutk1.Jakso.Add(Op3);

            Laitos Jamk = new Laitos("Jamk");
            Jamk.Tutkintotyyppi.Add(Tutk1);

            Opintojakso Op4 = new Opintojakso("Ohjelmointi");

            Op4.Oppilas.Add(new Opiskelija("Kalle Koskinen", "Q203", 18));
            Op4.Oppilas.Add(new Opiskelija("Olli Koskinen", "asds", 18));
            Op4.Oppilas.Add(new Opiskelija("Pekka Jormakka", "", 18));
            Op4.Opettaja.Add(new Opettaja("Arja koriseva", "", 59));

            
            Tutkinto Tutk2 = new Tutkinto("AMK");
            Tutk2.Jakso.Add(Op4);
           

            Laitos Jyamk = new Laitos("Jyamk");
            Jyamk.Tutkintotyyppi.Add(Tutk2);

            Console.WriteLine(Jamk.ToString());
            Console.WriteLine(Jyamk.ToString());


        }

    }
}
