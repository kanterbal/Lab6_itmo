﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            str = str.ToLower();
            string c = str;
            int  j = 0, a = 0;
            for (int i =0; i < c.Length; i++)
            {
                if (c[i] == '{')
                {
                    j++;
                    if (j == 1)
                        a = i;
                }
                else
                {
                    if ((c[i] == '}') && (j != 0))
                    {
                        j--;
                        if (j >= 0)
                        {
                            c = c.Remove(a, i - a + 1);
                            i -= i - a + 1;
                        }
                    }
                }
            }
            Console.Write(c);
            Console.ReadKey();
        }
    }
}

