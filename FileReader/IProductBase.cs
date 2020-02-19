using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.IO;

namespace FileReader
{
    public interface IProductBase
    {
        string Type { get; set; }
        string SKU { get; set; }
        string Name { get; set; }
    }
}
