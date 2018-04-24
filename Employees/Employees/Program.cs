﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Program
    {
        // Create a subclass object and access base class functionality.
        static void Main(string[] args)
        {
            // Create a subclass object and access base class functionality.
            SalesPerson fred = new SalesPerson();
            fred.Age = 31;
            fred.Name = "Fred";
            fred.SalesNumber = 50;
            
            // Assume Manager has a constructor matching this signature:
            // (string fullName, int age, int empID,
            // float currPay, string ssn, int numbOfOpts)
            Manager chucky = new Manager("Chucky", 50, 92, 100000, "333-23-2322", 9000);
            Console.ReadLine();
        }
    }
}
