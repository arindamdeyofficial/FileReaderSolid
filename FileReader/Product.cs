using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.IO;

namespace FileReader
{
    public class Product: ProductBase
    {
        public ProductAttributes Attributes { get; set; }
        public ProdutExtension OtherProductproperties { get; set; }
        public ProductBusiness BusinessInfo { get; set; }
        
        public override void NotifyProductChange()
        {
            Console.WriteLine("Productbase {0} change notified through Product", Name);
        }

        //O of SOLID
        //Open for implemementation
        //If required can extend
        //public override void LogProductBase()
        //{
        //    Console.WriteLine("Productbase {0} logged through Product", Name);
        //}

        public Product ConvertConcreteProduct(IncomingProduct prdsIncoming)
        {
            this.Name = prdsIncoming.Name;
            return this;
        }
    }
}
