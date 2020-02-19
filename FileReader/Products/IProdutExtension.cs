using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.IO;

namespace FileReader.Products
{
    public interface IProdutExtension
    {
        string Published { get; set; }
        string Isfeatured { get; set; }
        string Visibilityincatalog { get; set; }
        string Shortdescription { get; set; }
        string Description { get; set; }
        string Backordersallowed { get; set; }
        string WeightInKg { get; set; }
        string LengthInCm { get; set; }
        string WidthInCm { get; set; }
        string HeightInCm { get; set; }
        string Allowcustomerreviews { get; set; }
        string Purchasenote { get; set; }
        string Categories { get; set; }
        string Tags { get; set; }
        string Shippingclass { get; set; }
        string Images { get; set; }
        string Downloadlimit { get; set; }
        string Downloadexpirydays { get; set; }
        string Parent { get; set; }
        string Groupedproducts { get; set; }
        string ExternalURL { get; set; }
        string Buttontext { get; set; }
        string Download1name { get; set; }
        string Download1URL { get; set; }
    }
}
