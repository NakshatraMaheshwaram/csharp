﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    JaggedArray jaggedArray = new JaggedArray();
            //    jaggedArray.StudentArray();
            //    Console.WriteLine("\n\n************************ REF&OUT START ************************");
            //    RefAndOut refAndOut = new RefAndOut();
            //    refAndOut.RefFunction();
            //    refAndOut.OutFunction();
            //    Console.WriteLine("************************ REF&OUT END ************************");

            //Checked Unchecked
            //CheckedUnchecked checkedUnchecked = new CheckedUnchecked();
            //checkedUnchecked.uncheckedfun();
            //checkedUnchecked.checkedfun();

            //Nested Class
            NestedClasses.Outer_class.Inner_class inner_Class = new NestedClasses.Outer_class.Inner_class();
            inner_Class.Method1();

            //Nullable 
            Console.WriteLine("Null Keyword:-");
            Nullable nullableDemo = new Nullable();
            nullableDemo.PerformNullableExample();

            //Method hiding
            Console.WriteLine("Method Hiding:-");
            MethodHinding obj = new MethodHinding();
            obj.member();

            //tuples
            Console.WriteLine("Tupples:-");
            Tuples tup = new Tuples();
            tup.SetTupleMethod();

            //struct
            Console.WriteLine("Struct And Classes:-");
            STRUCTURE usingStruct = new STRUCTURE();
            usingStruct.PerFormStruct();
            usingStruct.StructCanNotBeNullAssign();

            Console.ReadLine();
        }
    }
}
        
