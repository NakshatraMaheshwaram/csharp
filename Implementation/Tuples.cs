﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation
{
    internal class Tuples
    {
        public void SetTupleMethod()
        {
            var student = new Tuple<string, string, string, string, int>("Nakshatra", "Ravi", "Maheshwaram", "Developer", 2022);
            Console.WriteLine("Print the tuple");
            Console.WriteLine("First Name=" + student.Item1);
            Console.WriteLine("Middle Name= " + student.Item2);
            Console.WriteLine("Last Name= " + student.Item3);
            Console.WriteLine("Designation = " + student.Item3);
            Console.WriteLine("Year= " + student.Item4);
        }
    }
}
    
