﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation
{
    internal class CheckedUnchecked
    {
        public void checkedfun()
        {

            checked
            {
                int val = int.MaxValue;
                Console.WriteLine(val + 2);
            }
        }
        public void uncheckedfun()
        {
            unchecked
            {

                {
                    int val = int.MaxValue;
                    Console.WriteLine(val + 2);
                }
            }
            Console.WriteLine("Unchecked Function is Called ");
        }
    }
}

