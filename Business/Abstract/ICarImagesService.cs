using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarImagesService
    {
        IResult Add(CarImages carimages);
        IResult Delete(CarImages carimages);
        IResult Update(CarImages carimages);
    }
}
