using ExcelDataReader;
using FileReader.Products;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace FileReader.Parsers
{
    public class CsvParser : ISourceType
    {
        public List<IncomingProduct> Parse(string fileName)
        {
            return ReadExcelOriginal.ReadExcel(fileName);
        }
    }
}
