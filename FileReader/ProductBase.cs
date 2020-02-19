using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.IO;

namespace FileReader
{
    //S of Solid
    //Seperation of concern for all product operation ProductBase signature is enough

    //I of Solid Interface segregation
    //IProductBase is needed to implement Mock for unit testing
    //So this class itself is unittestable and self sufficient

    //Works as model who populates himself and notify whole programm if needed i.e. Seperation of concern, decoupling
    public abstract class ProductBase: IProductBase
    {
        //L of SOLID Liskov i.e. derived class should be able to replace all members of parent
        //i.e. if it's private then whole class not extendable and gives compilation error
        public ProductBase()
        {
            Console.WriteLine("Productbase {0} instantiated", Name);
        }
        public string Type { get; set; }
        public string SKU { get; set; }
        public string Name { get; set; }

        //L of SOLID Liskov i.e. derived class should be able to replace all members of parent
        //Giving flexibility to child
        public abstract void NotifyProductChange();

        //L of SOLID Liskov i.e. derived class should be able to replace all members of parent
        //Giving flexibility to extend 
        public virtual void LogProductBase()
        {
            Console.WriteLine("Productbase {0} logged", Name);
        }
    }
}
