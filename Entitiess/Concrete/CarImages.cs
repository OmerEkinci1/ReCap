using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class CarImages : IEntity
    {
        [Key]
        public int imageId { get; set; }
        public int carId { get; set; }
        public string imagePath { get; set; }
        public DateTime imageDate { get; set; }
    }
}
