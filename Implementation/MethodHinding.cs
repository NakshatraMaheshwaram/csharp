﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation
{
    internal class MethodHinding
    {
        public void member()
        {
            Console.WriteLine("Total number of family members: 3");
        }
        public class My_Member : MethodHinding
        {

            // Reimplement the method of the base class
            // Using new keyword
            // It hides the method of the base class
            public new void member()
            {
                Console.WriteLine("Name: Ravi, Age: 35 \nName: Shashirekha, " +
                                       "Age: 30 \nName: Rohan, Age: 11 ");
            }
        }
    }
}
    