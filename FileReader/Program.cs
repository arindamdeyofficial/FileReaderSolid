using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using FileReader.Products;
using FileReader.Parsers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Abstractions;

namespace FileReader
{
    class Program
    {
        static void Main(string[] args)
        {
            //S - Sourceparser class - ISourceType
            //File read async and expose stream always and await still read complete
            //Dataset to Product Conversion async
            //I - Product structure adhering Solid
            //ISourceType
            //O,L - Product extensible for change notify.Upon Notification conversion from flat structure to concerete structure
            //D - Unittest, ISourceType

            //ISourceType - sourcetype, Parser()

            //Sql:ISourceType
            //Mongo: ISourceType
            //Excel: ISourceType
            //Csv: ISourceType

            //Excel/ other Parser class DI Constructor ISourceType - Parser() - implement all type - DI unserstand source config based
            //IInComingProducts
            //InComingProducts DI ISourceType : IInComingProducts - src.Parse();- flat properties DataFirst
            //Product class - Model - SOLID - abstract Base - NotifyChange()

            IServiceCollection services = new ServiceCollection();
            services.AddSingleton<ISourceType, ExcelParser>();
            services.AddSingleton<IncomingProducts>();
            IServiceProvider serviceProvider = services.BuildServiceProvider();
            var incomingPrdsServices = serviceProvider.GetService<IncomingProducts>();
            incomingPrdsServices.Parse(@"D:\OneDrive\Code\FileReaderSolid\product.xlsx");

            List<Product> prd = incomingPrdsServices.ParseToProductModel();
            Console.WriteLine("{0} Products found", prd.Count());
        }
    }
}
