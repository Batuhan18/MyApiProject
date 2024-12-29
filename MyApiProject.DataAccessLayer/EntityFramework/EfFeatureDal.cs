﻿using MyApiProject.DataAccessLayer.Abstract;
using MyApiProject.DataAccessLayer.Context;
using MyApiProject.DataAccessLayer.Repositories;
using MyApiProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiProject.DataAccessLayer.EntityFramework
{
    public class EfFeatureDal : GenericRepository<Feature>, IFeatureDal
    {
        public EfFeatureDal(ApiContext context) : base(context)
        {
        }
    }
}
