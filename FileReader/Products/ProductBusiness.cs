using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.IO;

namespace FileReader.Products
{
    //S of Solid
    //Seperation of concern for all product operation ProductBusiness will be handeled by this class

    //I of Solid Interface segregation
    //IProductBusiness is needed to implement Mock for unit testing
    //So this class itself is unittestable and self sufficient

    //D of SOLID
    //To maintain consistent behaviour throughout the program for one common dependency IProductBusiness is needed
    public class ProductBusiness: IProductBusiness
    {
        public string Datesalepricestarts { get; set; }
        public string Datesalepriceends { get; set; }
        public string Taxclass { get; set; }
        public string Instock { get; set; }
        public string Stock { get; set; }
        public string Soldindividually { get; set; }
        public string Saleprice { get; set; }
        public string Regularprice { get; set; }
        public string Upsells { get; set; }
        public string Cross_sells {get;set;}
    }
}
