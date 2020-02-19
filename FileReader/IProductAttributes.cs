using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.IO;

namespace FileReader
{
    public interface IProductAttributes
    {
        string Attribute1name { get; set; }
        string Attribute1values { get; set; }
        string Attribute1visible { get; set; }
        string Attribute1global { get; set; }
        string Attribute2name { get; set; }
        string Attribute2values { get; set; }
        string Attribute2visible { get; set; }
        string Attribute2global { get; set; }
        string Attribute1default { get; set; }
        string Attribute2default { get; set; }
    }
}
