using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspect.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

       
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        [SecuredOperation("rental.delete,moderator,admin")]
        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentDeleted);
        }

        public IDataResult<List<Rental>> GetAllRentals()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.RentListed);
        }

        public IDataResult<Rental> GetByRentId(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.RentId == id), Messages.RentGetting);
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetailDtos()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails(), Messages.RentListed);
        }


        [SecuredOperation("user,rental.add,moderator,admin")]
        [ValidationAspect(typeof(RentalValidator))]
        public IResult Add(Rental rental)
        {
            var results = _rentalDal.GetAll(r => r.CarId == rental.CarId);
            foreach (var result in results)
            {
                if (result.ReturnDate == null || result.RentDate > result.ReturnDate)
                {
                    return new ErrorResult(Messages.ReturnDateNone);
                }
            }

            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentAdded);
        }


        [SecuredOperation("user,rental.update,moderator,admin")]
        [ValidationAspect(typeof(RentalValidator))]
        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentUpdated);
        }

        public IDataResult<List<Rental>> GetAllByCarId(int carId)
        {
            throw new NotImplementedException();
        }

        public IResult CheckReturnDate(int carId)
        {
            var result = _rentalDal.GetAll(x => x.CarId == carId && x.ReturnDate == null);
            if (result.Count > 0)
            {
                return new ErrorResult(Messages.RentalUndeliveredCar);
            }
            return new SuccessResult();
        }

        public IResult IsRentable(Rental rental)
        {
            var result = _rentalDal.GetAll(r => r.CarId == rental.CarId);

            if (result.Any(r =>
                r.ReturnDate >= rental.RentDate &&
                r.RentDate <= rental.ReturnDate
            ))
            {
                return new ErrorResult(Messages.RentalNotAvailable);
            }

            return new SuccessResult();
        }
    }
}
