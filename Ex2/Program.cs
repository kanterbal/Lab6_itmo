using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            s = s.ToLower();
            bool p = true;
            string pal = "";
            string[] stringArray = s.Split();
            foreach (string str in stringArray)
            {
                pal += str;
            }
            //Console.WriteLine(pal);
            for (int i = 0; i < pal.Length / 2; i++)
            {
                if (pal[i] != pal[pal.Length - 1 - i])
                {
                    p = false;
                }
            }
            Console.WriteLine(p);
            Console.ReadKey();
        }
    }
}
