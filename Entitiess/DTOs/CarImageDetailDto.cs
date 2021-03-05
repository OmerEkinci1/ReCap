using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarImageDetailDto : IDto
    {
        public int imageId { get; set; }
        public int carId { get; set; }
        public string carName { get; set; }
        public string imagePath { get; set; }
        public DateTime imageDate { get; set; }
    }
}
