using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        IBrandService _brandService;

        public CarManager(ICarDal carDal, IBrandService brandService)
        {
            _carDal = carDal;
            _brandService = brandService;
        }

        // fluent validation ı burada böyle çağırıyoruz.
        [SecuredOperation("product.add,admin")]
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
            // iş kurallarımızın çalışırlığını kontrol ediyoruz.
            var result = BusinessRules.Run(CheckIfBrandCountOfCategoryCorrect(car.BrandId),
                CheckIfCarNameExist(car.CarName), CheckIfBrandLimitExceed());
            if (result != null)
            {
                return result;
            }
            _carDal.Add(car);
            return new Success(Messages.CarAdded);
        }

        public IResult Delete(Car car)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.CarListed);
        }

        public IDataResult<List<Car>> GetAllByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == id), Messages.CarListed);
        }

        public IDataResult<List<Car>> GetAllByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == id), Messages.CarListed);
        }

        public IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max),Messages.CarListed);
        }

        public IDataResult<Car> GetById(int carId)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.CarId == carId),Messages.CarListed);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

        [ValidationAspect(typeof(CarValidator))]
        public IResult Update(Car car)
        {
            throw new NotImplementedException();
        }

        // iş kuralını ayrı olarak buraya yazmamız lazım, eğer birçok sayfada kullanılması gereken bir kuralsa onu service e yazmamız gerekiyor.
        private IResult CheckIfBrandCountOfCategoryCorrect(int brandId)
        {
            var result = _carDal.GetAll(c => c.BrandId == brandId).Count;
            if (result >= 10)
            {
                return new Error(Messages.CarCountofBrandError);
            }
            return new Success();
        }

        private IResult CheckIfCarNameExist(string carName)
        {
            var result = _carDal.GetAll(c => c.CarName == carName).Any();
            if (result)
            {
                return new Error(Messages.CarNameAlreadyExist);
            }
            return new Success();
        }

        private IResult CheckIfBrandLimitExceed()
        {
            var result = _brandService.GetAll();
            if (result.Data.Count > 15)
            {
                return new Error(Messages.BrandLimitExceed);
            }
            return new Success();
        }
    }
}
