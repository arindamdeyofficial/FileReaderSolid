using ExcelDataReader;
using FileReader.Products;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace FileReader
{
    public static class ReadExcelOriginal
    {
        public static List<IncomingProduct> ReadExcel(string fileName)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            var sw = new Stopwatch();
            sw.Start();
            List<IncomingProduct> prds = new List<IncomingProduct>();
            using (var stream = File.Open(fileName, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    List<string> columns = new List<string>();                    

                    DataSet ds = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        UseColumnDataType = false,
                        ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true
                        }
                    });
                    prds = ConvertDataTableToGenericList<IncomingProduct>(ds.Tables[0]);
                }
            }
            Console.WriteLine("Elapsed: " + sw.ElapsedMilliseconds.ToString() + " ms (" + sw.ElapsedMilliseconds.ToString() + " ms to open)"
                + Environment.NewLine + "Total products found: " + prds.Count());
            return prds;
        }
        public static List<T> ConvertDataTableToGenericList<T>(DataTable dt)
        {
            var columnNames = dt.Columns.Cast<DataColumn>()
                   .Select(c => c.ColumnName)
                   .ToList();

            var properties = typeof(T).GetProperties();
            DataRow[] rows = dt.Select();
            return rows.Select(row =>
            {
                var objT = Activator.CreateInstance<T>();
                foreach (var pro in properties)
                {                    
                    if (columnNames.Contains(pro.Name))
                        pro.SetValue(objT, Convert.ChangeType(row[pro.Name], pro.PropertyType));
                }

                return objT;
            }).ToList();
        }
    }
}
