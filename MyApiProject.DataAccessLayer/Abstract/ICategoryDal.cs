using MyApiProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiProject.DataAccessLayer.Abstract
{
    public interface ICategoryDal
    {
        void Delete(int id);
        List<Category> GetAll();
        Category GetById(int id);
        void Insert(Category entity);
        void Update(Category entity);
    }
}
