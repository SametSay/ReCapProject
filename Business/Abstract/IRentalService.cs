using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IResult Add(Rental rental);
        IResult Update(Rental rental);
        IResult Delete(Rental rental);
        IDataResult<Rental> GetByRentId(int id);
        IDataResult<List<Rental>> GetAllRentals();
        IDataResult<List<RentalDetailDto>> GetRentalDetailDtos();
        IDataResult<List<Rental>> GetAllByCarId(int carId);
        IResult CheckReturnDate(int carId);
        IResult IsRentable(Rental rental);
    }
}
