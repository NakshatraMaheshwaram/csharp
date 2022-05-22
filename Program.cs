﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFile
{
    internal class Readfile
    {
        public void ReadFile()
        {
            FileStream fileStrObj = new FileStream(@"C:\Users\hp\Documents\TrainningRepo\CsharpRepo\FileHandlingReadFile\networklog.txt", FileMode.Open, FileAccess.Read);
            StreamReader strReadObj = new StreamReader(fileStrObj);
            Console.WriteLine("Id" + "\t" + "Source" + "\t" + "\tDestination" + "\t" + "Date" + "\t" + "\tTime" + "\t" + "\tStatus" + "\t" + "Network");
            while (strReadObj.Peek() > 0)
            {
                string line = strReadObj.ReadLine();
                if (line != "")
                {
                    string[] myStrs = line.Split(':');
                    if (myStrs.Length > 3)
                    {
                        string[] mydatetime = myStrs[1].Split(' ');
                        Console.Write(mydatetime[0] + "\t" + mydatetime[1] + ":" + myStrs[2] + ":" + myStrs[3] + "\t");
                    }
                    else
                    {
                        Console.Write(myStrs[1] + "\t");
                    }

                }
                else
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine("\nRead operation completed");
            Console.ReadLine();
        }
    }
}
