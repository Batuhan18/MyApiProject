﻿using MyApiProject.BusinessLayer.Abstract;
using MyApiProject.DataAccessLayer.Abstract;
using MyApiProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiProject.BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void TDelete(int id)
        {
            throw new NotImplementedException();
        }

        public List<About> TGetAll()
        {
            return _aboutDal.GetAll();
        }

        public About TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TInsert(About entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(About entity)
        {
            throw new NotImplementedException();
        }
    }
}