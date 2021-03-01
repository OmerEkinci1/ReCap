using Entitiess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entitiess.Concrete
{
    public class Color : IEntity
    {
        public int colorId { get; set; }
        public string colorName { get; set; }
    }
}
