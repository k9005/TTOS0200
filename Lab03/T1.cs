using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    public static class T1
    {
        //static bool numero { get; set; }
        //static bool paiva { get; set; }
        public static bool Onkoluku(string syote)
        {
            byte[] asciiBytes = Encoding.ASCII.GetBytes(syote);
            foreach (byte b in asciiBytes)
            {
                if (b > 48 && b < 57 || b == 44) return true;
            }

            return false;
        }
        public static bool Onkopvm(string syote)
        {
            return false;
        }
    }
}
