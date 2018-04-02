﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitlyTypedLocalVars
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicitly typed local variables.
            var myInt = 0;
            var myBool = true;
            var myString = "Time, marches on...";
            // Print out the underlying type.
            Console.WriteLine("myInt is a: {0}", myInt.GetType().Name);
            Console.WriteLine("myBool is a: {0}", myBool.GetType().Name);
            Console.WriteLine("myString is a: {0}", myString.GetType().Name);
            Console.ReadLine();
        }
    }
}
