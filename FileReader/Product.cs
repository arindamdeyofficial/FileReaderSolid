using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.IO;

namespace FileReader
{
    public class Product
    {
        public string Type { get; set; }
        public string SKU { get; set; }
        public string Name { get; set; }
        public string Published { get; set; }
        public string Isfeatured { get; set; }
        public string Visibilityincatalog { get; set; }
        public string Shortdescription { get; set; }
        public string Description { get; set; }
        public string Datesalepricestarts { get; set; }
        public string Datesalepriceends { get; set; }
        public string Taxclass { get; set; }
        public string Instock { get; set; }
        public string Stock { get; set; }
        public string Backordersallowed { get; set; }
        public string Soldindividually { get; set; }
        public string WeightInKg { get; set; }
        public string LengthInCm { get; set; }
        public string WidthInCm { get; set; }
        public string HeightInCm { get; set; }
        public string Allowcustomerreviews { get; set; }
        public string Purchasenote { get; set; }
        public string Saleprice { get; set; }
        public string Regularprice { get; set; }
        public string Categories { get; set; }
        public string Tags { get; set; }
        public string Shippingclass { get; set; }
        public string Images { get; set; }
        public string Downloadlimit { get; set; }
        public string Downloadexpirydays { get; set; }
        public string Parent { get; set; }
        public string Groupedproducts { get; set; }
        public string Upsells { get; set; }
        public string Cross_sells {get;set;}
    public string ExternalURL { get; set; }
    public string Buttontext { get; set; }
    public string Download1name { get; set; }
    public string Download1URL { get; set; }
    public string Attribute1name { get; set; }
    public List<string> Attribute1values { get; set; }
    public string Attribute1visible { get; set; }
    public string Attribute1global { get; set; }
    public string Attribute2name { get; set; }
    public List<string> Attribute2values { get; set; }
    public string Attribute2visible { get; set; }
    public string Attribute2global { get; set; }
    public string Attribute1default { get; set; }
    public string Attribute2default { get; set; }
}
}
