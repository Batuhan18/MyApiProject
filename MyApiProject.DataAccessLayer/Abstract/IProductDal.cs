using MyApiProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiProject.DataAccessLayer.Abstract
{
    public interface IProductDal
    {
        void Delete(int id);
        List<Product> GetAll();
        Product GetById(int id);
        void Insert(Product entity);
        void Update(Product entity);
    }
}
