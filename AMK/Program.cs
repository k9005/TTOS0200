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
            Opintojakso Opint1 = new Opintojakso("Olio");

            Opint1.Oppilas.Add(new Opiskelija("Kalle Koskinen","Q203", 18));
            Opint1.Oppilas.Add(new Opiskelija("Olli Koskinen","asds", 18));
            Opint1.Oppilas.Add(new Opiskelija("Pekka Jormakka","", 18));
            Opint1.Opettaja.Add(new Opettaja("Arja koriseva","", 59));
            

            Opintojakso Opint2 = new Opintojakso("Kertaus");

            Opint2.Oppilas.Add(new Opiskelija("Kalle Koskinen", "Q203", 18));
            Opint2.Oppilas.Add(new Opiskelija("Olli Koskinen", "asds", 18));
            Opint2.Oppilas.Add(new Opiskelija("Pekka Jormakka", "", 18));
            Opint2.Opettaja.Add(new Opettaja("Arja koriseva", "", 59));

            Opintojakso Opint3 = new Opintojakso("Olio2");

            Opint3.Oppilas.Add(new Opiskelija("Kalle Koskinen", "Q203", 18));
            Opint3.Oppilas.Add(new Opiskelija("Olli Koskinen", "asds", 18));
            Opint3.Oppilas.Add(new Opiskelija("Pekka Jormakka", "", 18));
            Opint3.Opettaja.Add(new Opettaja("Arja koriseva", "", 59));

            Tutkinto Tutk1 = new Tutkinto("AMK");
            Tutk1.Jakso.Add(Opint1);
            Tutk1.Jakso.Add(Opint2);
            Tutk1.Jakso.Add(Opint3);

            Laitos Jamk = new Laitos("Jamk");
            Jamk.Tutkintotyyppi.Add(Tutk1);

            Opintojakso Opint4 = new Opintojakso("Ohjelmointi");

            Opint3.Oppilas.Add(new Opiskelija("Kalle Koskinen", "Q203", 18));
            Opint3.Oppilas.Add(new Opiskelija("Olli Koskinen", "asds", 18));
            Opint3.Oppilas.Add(new Opiskelija("Pekka Jormakka", "", 18));
            Opint3.Opettaja.Add(new Opettaja("Arja koriseva", "", 59));

            Opintojakso Opint5 = new Opintojakso("C#");

            Opint3.Oppilas.Add(new Opiskelija("Kalle Koskinen", "Q203", 18));
            Opint3.Oppilas.Add(new Opiskelija("Olli Koskinen", "asds", 18));
            Opint3.Oppilas.Add(new Opiskelija("Pekka Jormakka", "", 18));
            Opint3.Opettaja.Add(new Opettaja("Arja koriseva", "", 59));

            Opintojakso Opint6 = new Opintojakso("C++");

            Opint3.Oppilas.Add(new Opiskelija("Kalle Koskinen", "Q203", 18));
            Opint3.Oppilas.Add(new Opiskelija("Olli Koskinen", "asds", 18));
            Opint3.Oppilas.Add(new Opiskelija("Pekka Jormakka", "", 18));
            Opint3.Opettaja.Add(new Opettaja("Arja koriseva", "", 59));

            Tutkinto Tutk2 = new Tutkinto("AMK");
            Tutk2.Jakso.Add(Opint4);
            Tutk2.Jakso.Add(Opint5);
            Tutk2.Jakso.Add(Opint6);

            Laitos Jyamk = new Laitos("Jyamk");
            Jyamk.Tutkintotyyppi.Add(Tutk2);

            Console.WriteLine(Jamk.ToString());
            Console.WriteLine(Jyamk.ToString());


        }

    }
}
