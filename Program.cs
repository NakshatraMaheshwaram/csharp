﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionHandsOn
{
    internal class Program
    {
        static void Main(string[] args)
         #region Integer List
        //List<int> Integer = new List<int>();
        //Console.WriteLine("\nList of Integers From 0 - 9 :- \n");
        //for(int i =0;i<10;i++)
        //{
        //    Integer.Add(i);
        //}
        //foreach (int i in Integer)
        //{
        //    Console.WriteLine("\t" + i);
        //}
        #endregion

        #region Name List
        //List<string> Names = new List<String>();
        //Console.WriteLine("\nList of Names :- \n");
        //Names.Add("Tim");
        //Names.Add("Martin");
        //Names.Add("Nikki");
        //Names.Add("Sara");
        //foreach (string name in Names)
        //{
        //    Console.WriteLine("\t" + name);
        //}
        #endregion

        #region TrueFalse List 
        //List<string> TF = new List<string>();
        //Console.WriteLine("\nTrue False List :- \n");
        //TF.Add("True");
        //for(int i = 1; i < 10 ; i++)
        //{
        //    if (i%2 ==0 )
        //    {
        //        TF.Add("True");
        //    }
        //    else TF.Add("False");
        //}
        //foreach (string val in TF)
        //{
        //    Console.WriteLine("\t" + val);
        //}
        #endregion

        #region Integer Array
            int[] Array1 = new int[10];
        Console.WriteLine("\nArray of Integers From 0 - 9 :- \n");
            for(int i =0;i<10;i++)
            {
                Console.WriteLine("\t" + i);
            }
    #endregion

    #region Name Array
    string[] Array2 = new string[] { "Tim", "Martin", "Nikki", "Sara" };
    Console.WriteLine("\nArray of Names :- \n");
            foreach(string i in Array2)
            {
                Console.WriteLine("\t" + i);
            }
#endregion

#region TrueFalse Array
string[] Array3 = new string[10];
Console.WriteLine("\nTrue False Array :- \n");
for (int i = 0; i < Array3.Length; i++)
{
    if (i % 2 == 0)
    {
        Array3[i] = "True";
    }
    else Array3[i] = "False";
}
foreach (string val in Array3)
{
    Console.WriteLine("\t" + val);
}
#endregion

#region
List<string> Flavours = new List<string>();
Console.WriteLine("\nEnter the no of Flavours :-");
int count = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= count; i++)
{
    Console.WriteLine("\nEnter Flavour " + i + ":-");
    Flavours.Add(Console.ReadLine());
}
Console.WriteLine("\nList of Flavours :- ");
foreach (string val in Flavours)
{
    Console.WriteLine(val);
}
Console.WriteLine("\nNo of Flavours :- " + Flavours.Count);
Console.WriteLine("\nEnter the Flavour you want to delete :-");
string fla = Console.ReadLine();
Flavours.Remove(fla);
Console.WriteLine("\nNew List of Flavours :- ");
foreach (string val in Flavours)
{
    Console.WriteLine(val);
}
Console.WriteLine("\nNo of Flavours :- " + Flavours.Count);
#endregion
Console.ReadLine();
        }
    }
}

