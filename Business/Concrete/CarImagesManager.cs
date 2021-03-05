using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarImagesManager : ICarImagesService
    {
        ICarImagesDal _carimagesDal;

        public CarImagesManager(ICarImagesDal carimagesDal)
        {
            _carimagesDal = carimagesDal;
        }

        [ValidationAspect(typeof(CarImagesValidator))]
        public IResult Add(CarImages carimages)
        {
            _carimagesDal.Add(carimages);
            return new Success(Messages.CarImagesAdded);
        }

        public IResult Delete(CarImages carimages)
        {
            throw new NotImplementedException();
        }

        public IResult Update(CarImages carimages)
        {
            throw new NotImplementedException();
        }
    }
}
