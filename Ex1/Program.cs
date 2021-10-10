using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            string startString = Console.ReadLine();
            string res = "";
            int max = 0;
            string[] stringArray = startString.Split();
            foreach (string s in stringArray)
            {
                if (s.Length >= max)
                {
                    max = s.Length;
                    res = s;
                }
            }
            Console.WriteLine("Саммое длинное слово - {0}, его длина = {1}", res, max);
            Console.ReadKey();
        }
    }
}
