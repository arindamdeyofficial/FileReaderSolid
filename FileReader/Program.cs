using ExcelDataReader;
using System;
using System.IO;

namespace FileReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            using (var stream = File.Open(@"C:\Users\arindam_d\OneDrive - Dell Technologies\Work\FileReaderSolid\product.xlsx", FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    do
                    {
                        while (reader.Read()) //Each ROW
                        {
                            for (int column = 0; column < reader.FieldCount; column++)
                            {
                                str += reader.GetString(column).Replace("?", "").Replace(" ", "");
                            }
                            break;
                        }
                    } while (reader.NextResult()); //Move to NEXT SHEET

                }
            }
        }
    }
}
