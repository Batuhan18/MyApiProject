using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiProject.DtosLayer.CategoryDtos
{
    public class ResultCategoryDtos
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
    }
}
