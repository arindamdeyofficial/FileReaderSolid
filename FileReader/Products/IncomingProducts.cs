using ExcelDataReader;
using FileReader.Parsers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FileReader.Products
{
    public class IncomingProducts
    {
        private readonly ISourceType _src;
        public IncomingProducts(ISourceType src)
        {
            _src = src;
        }
        public void Parse(string fileName)
        {
            AllIncomingProducts = _src.Parse(fileName);
        }
        public List<Product> ParseToProductModel()
        {
            return AllIncomingProducts.Select(i => new Product
            {
                Name = i.Name,
                SKU = i.SKU,
                Type = i.Type,
                Attributes = new ProductAttributes
                {
                    Attribute1name = i.Attribute1name
                },
                BusinessInfo = new ProductBusiness
                {
                    Saleprice = i.Saleprice
                },
                OtherProductproperties = new ProdutExtension
                {
                    Description = i.Description
                }
            }).ToList();
        }
        public List<IncomingProduct> AllIncomingProducts { get; set; }
    }
}
