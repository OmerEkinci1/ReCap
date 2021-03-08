using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    public class CarImagesController : Controller
    {
        ICarImagesService _carImagesService;

        public CarImagesController(ICarImagesService carImagesService)
        {
            _carImagesService = carImagesService;
        }

        //[HttpGet("getall")]
        //public IActionResult GetAll()
        //{
        //    var result = _carImagesService.GetAll();
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //}

        //[HttpGet("getbyid")]
        //public IActionResult GetById(int id)
        //{
        //    var result = _carImagesService.GetById(id);
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //}

        [HttpPost("add")]
        public IActionResult Add(CarImages carImages)
        {
            var result = _carImagesService.Add(carImages);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(CarImages carImages)
        {
            var result = _carImagesService.Delete(carImages);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(CarImages carImages)
        {
            var result = _carImagesService.Update(carImages);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
