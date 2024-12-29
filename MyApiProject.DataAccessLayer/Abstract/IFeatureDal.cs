using MyApiProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiProject.DataAccessLayer.Abstract
{
    public interface IFeatureDal
    {
        void Delete(int id);
        List<Feature> GetAll();
        Feature GetById(int id);
        void Insert(Feature entity);
        void Update(Feature entity);
    }
}
