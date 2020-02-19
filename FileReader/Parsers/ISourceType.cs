using ExcelDataReader;
using FileReader.Products;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace FileReader.Parsers
{
    public interface ISourceType
    {
        List<IncomingProduct> Parse(string fileName);
    }
}
