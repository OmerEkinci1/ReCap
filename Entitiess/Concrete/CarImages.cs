using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class CarImages : IEntity
    {
        public int imageId { get; set; }
        public int carId { get; set; }
        public string imagePath { get; set; }
        public DateTime imageDate { get; set; }
    }
}
