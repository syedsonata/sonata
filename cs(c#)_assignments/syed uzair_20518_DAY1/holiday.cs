﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VsHelloworld
{
    class holiday
    {
        static void Main()
        {
            Console.WriteLine("enter the day");
            string day = Console.ReadLine();
            int n = int.Parse(day);
            if(n==0 || n > 7)
            {
                Console.WriteLine("invalid day");
            }else if (n <= 5)
            {
                Console.WriteLine("working day");
            }else
                Console.WriteLine("holiday");
        }
    }
}
