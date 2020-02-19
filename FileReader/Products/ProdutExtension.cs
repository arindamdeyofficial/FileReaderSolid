using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.IO;

namespace FileReader.Products
{
    //S of Solid
    //Seperation of concern for all product operation other Produt properties will be handeled by this class

    //I of Solid Interface segregation
    //IProdutExtension is needed to implement Mock for unit testing
    //So this class itself is unittestable and self sufficient

    //D of SOLID
    //To maintain consistent behaviour throughout the program for one common dependency IProdutExtension is needed
    public class ProdutExtension: IProdutExtension
    {
        public string Published { get; set; }
        public string Isfeatured { get; set; }
        public string Visibilityincatalog { get; set; }
        public string Shortdescription { get; set; }
        public string Description { get; set; }
        public string Backordersallowed { get; set; }
        public string WeightInKg { get; set; }
        public string LengthInCm { get; set; }
        public string WidthInCm { get; set; }
        public string HeightInCm { get; set; }
        public string Allowcustomerreviews { get; set; }
        public string Purchasenote { get; set; }
        public string Categories { get; set; }
        public string Tags { get; set; }
        public string Shippingclass { get; set; }
        public string Images { get; set; }
        public string Downloadlimit { get; set; }
        public string Downloadexpirydays { get; set; }
        public string Parent { get; set; }
        public string Groupedproducts { get; set; }
        public string ExternalURL { get; set; }
        public string Buttontext { get; set; }
        public string Download1name { get; set; }
        public string Download1URL { get; set; }
    }
}
