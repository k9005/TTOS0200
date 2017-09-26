using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab03
{
    public static class T1
    {
        
        public static bool Onkoluku(string syote)
        {
            byte[] asciiBytes = Encoding.ASCII.GetBytes(syote);
            foreach (byte b in asciiBytes)
            {
                if (b > 48 && b < 57 || b == 44 || b == 43 || b == 45)
                {
                    byte vika = asciiBytes[asciiBytes.Length - 1];
                    if (asciiBytes[0] == 44 || vika == 44) return false;
                    else return true;
                }
            }
            return false;
        }

        public static bool Onkopvm(string syote)
        {
            string format = "dd MM yyyy";
            DateTime dateTime;
            if (DateTime.TryParse(syote, format, out dateTime))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }


    class T2
    {
        private readonly int Maxk = 5;
        private readonly int Mink = 1;
        int kerros = 1;
        public int Kerros
        {
            get
            {
                return kerros;
            }
            set
            {
                if (value <= Maxk && value >= Mink) kerros = value;
                else
                {
                    Console.WriteLine("Valitettavasti hissi kulkee vain kerroksissa 1-5.");
                    
                }
            }
        }
    }

    class T3
    {
        private readonly int Maxk = 100;
        private readonly int Mink = 0;
        int volume = 1;
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value <= Maxk && value >= Mink) volume = value;
                else if (value < Mink)
                { volume = 0;
                    Console.WriteLine("Laitoit liian pienen arvon! Volume on asetettu {0}", volume);
                }
                else if (value > Maxk)
                {
                    volume = 100;
                    Console.WriteLine("Laitoit liian suuren arvon! Volume on asetettu {0}", volume);
                }
                




            }
        }
    }
}


    

