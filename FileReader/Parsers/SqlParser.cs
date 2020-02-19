using ExcelDataReader;
using FileReader.Products;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace FileReader.Parsers
{
    public class SqlParser : ISourceType
    {
        public List<IncomingProduct> Parse(string fileName)
        {
            //Go to Sql and have product list db model
            throw new NotImplementedException();
        }
    }
}
