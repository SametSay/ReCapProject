using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);

        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetByCarId(int id);
        IDataResult<List<Car>> GetCarsByBrandId(int id);
        IDataResult<List<Car>> GetCarsByColorId(int id);
        IDataResult<List<Car>> GetCarsByDailyPrice(decimal min, decimal max);
        IDataResult<List<CarDetailDto>> GetCarDetailsByBrandName(string name);
        IDataResult<List<CarDetailDto>> GetCarDetailsByColorName(string name);
        IDataResult<List<CarDetailDto>> GetCarDetailsByBrandNameAndColorName(string brandName, string colorName);
        IDataResult<List<CarDetailDto>> GetCarDetails();
    }
}
