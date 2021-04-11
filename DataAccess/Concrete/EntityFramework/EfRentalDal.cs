using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;


namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarProjectContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (var context = new CarProjectContext())
            {
                var result = from rent in context.Rentals
                             join car in context.Cars on rent.CarId equals car.CarId
                             join brand in context.Brands on car.BrandId equals brand.BrandId
                             join color in context.Colors on car.ColorId equals color.ColorId
                             join cus in context.Customers on rent.CustomerId equals cus.CustomerId
                             select new RentalDetailDto
                             {
                                 CarId = rent.CarId,
                                 CustomerId = rent.CustomerId,
                                 RentId = rent.RentId,
                                 RentDate = rent.RentDate,
                                 ReturnDate = rent.ReturnDate,
                             };

                return result.ToList();
            }
        }
    
        public List<RentalDetailDto> GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
    }
}
