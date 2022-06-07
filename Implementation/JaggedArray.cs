﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation
{
    internal class JaggedArray
    {
        public void StudentArray()
        {
            Console.WriteLine("********************** JAGGED ARRAY START *************************");
            int[][] StudentPreasentOn = new int[4][]
            {
               new int[]{1,2,3,4,5,6,7,8,9 },
               new int[]{1,3,5,8,9,},
            new int[]{2,5,9},
            new int[]{1,2,6,9},
                };

            for (int i = 0; i < StudentPreasentOn.Length; i++)
            {
                Console.Write("\nStudents ({0}) was present on :  ", i + 1);
                for (int j = 0; j < StudentPreasentOn[i].Length; j++)
                {
                    Console.Write(StudentPreasentOn[i][j] + "\t");
                }

            }
            Console.WriteLine("\n\n********************** JAGGED ARRAY END *************************");
        }
    }
}
    