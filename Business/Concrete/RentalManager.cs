using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        private IRentalDal _rentalDal;

        public IResult Add(Rentals rental)
        {
            _rentalDal.Add(rental);
            return new Success(Messages.RentalAdded);
        }

        public IResult Delete(Rentals rental)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Rentals rental)
        {
            throw new NotImplementedException();
        }
    }
}
