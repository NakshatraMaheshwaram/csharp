using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingReadFile1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Readfile readfile = new Readfile();
            readfile.ReadFile();
            readfile.Success();
            readfile.Failed();
            readfile.Missed();
            readfile.Dailed();
        }

    }
}
