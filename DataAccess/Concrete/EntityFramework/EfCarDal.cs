using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarProjectContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using (var context = new CarProjectContext())
            {
                var result = from p in context.Cars
                             join b in context.Brands
                                 on p.BrandId equals b.BrandId
                             join c in context.Colors
                                 on p.ColorId equals c.ColorId
                             select new CarDetailDto
                             {
                                 Id = p.CarId,
                                 CarName = p.CarName,
                                 BrandName = b.BrandName,
                                 ColorName = c.ColorName,
                                 DailyPrice = p.DailyPrice,
                                 ModelYear = p.ModelYear
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
    }
}
