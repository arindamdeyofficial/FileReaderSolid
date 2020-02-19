using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.IO;

namespace FileReader
{
    public interface IProductBusiness
    {
        string Datesalepricestarts { get; set; }
        string Datesalepriceends { get; set; }
        string Taxclass { get; set; }
        string Instock { get; set; }
        string Stock { get; set; }
        string Soldindividually { get; set; }
        string Saleprice { get; set; }
        string Regularprice { get; set; }
        string Upsells { get; set; }
        string Cross_sells {get;set;}
    }
}
