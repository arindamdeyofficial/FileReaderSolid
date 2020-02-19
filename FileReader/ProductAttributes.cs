using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.IO;

namespace FileReader
{
    //S of Solid
    //Seperation of concern for all product operation ProductAttributes will be handeled by this class

    //I of Solid Interface segregation
    //IProductAttributes is needed to implement Mock for unit testing
    //So this class itself is unittestable and self sufficient

    //D of SOLID
    //To maintain consistent behaviour throughout the program for one common dependency IProductAttributes is needed

    public class ProductAttributes : IProductAttributes
    {
        public string Attribute1name { get; set; }
        public string Attribute1values { get; set; }
        public string Attribute1visible { get; set; }
        public string Attribute1global { get; set; }
        public string Attribute2name { get; set; }
        public string Attribute2values { get; set; }
        public string Attribute2visible { get; set; }
        public string Attribute2global { get; set; }
        public string Attribute1default { get; set; }
        public string Attribute2default { get; set; }

        //L of SOLID Liskov i.e. derived class should be able to replace all members of parent
        //Giving flexibility to extend 
        public virtual void LogProductAttributes()
        {
            Console.WriteLine("ProductAttributes {0} logged", Attribute1name);
        }
    }
}
