using MyApiProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiProject.DataAccessLayer.Abstract
{
    public interface IAboutDal
    {
        void Delete(int id);
        List<About> GetAll();
        void Insert(About entity);
        void Update(About entity);
    }
}
