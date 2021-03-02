using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business;
using Core.Utilities.Results;
using Entities;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImageController : ControllerBase
    {
        private ICarImageService _carImageManager;

        public CarImageController(ICarImageService carImageManager)
        {
            _carImageManager = carImageManager;
        }

        [HttpGet("add")]
        public IActionResult Add(CarImage carImage)
        {
            var result = _carImageManager.Add(carImage);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
