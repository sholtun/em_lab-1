﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace em_lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            IGenerator k = new KnutMethod(2345678);
            Console.WriteLine(k.getNext());
        }
    }
}
