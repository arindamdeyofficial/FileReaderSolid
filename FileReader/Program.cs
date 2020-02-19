using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace FileReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Product prd = new Product();
            prd.LogProductBase();
        }
    }
}
