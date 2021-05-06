
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

using Core.DataAccess.EntityFramework;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityFrameworkBase<Car, ReCapDbsContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapDbsContext context = new ReCapDbsContext())
            {
                var result = from c in context.Cars
                             join cl in context.Colors on c.ColorId equals cl.ColorId
                             join b in context.Brands on c.BrandId equals b.BrandId
                             select new CarDetailDto
                             {
                                 CarId = c.CarId,
                                 
                                 ColorName = cl.ColorName,
                                 BrandName = b.BrandName
                                 
                             };
                return result.ToList();

            }
        }
    }
}
