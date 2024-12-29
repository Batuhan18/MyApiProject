using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiProject.DtosLayer.ProductDtos
{
    public class UpdateProductDtos
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public string Detail { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
    }
}
