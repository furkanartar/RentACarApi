using System;
using System.ComponentModel.DataAnnotations.Schema;
using Business;
using Business.Constants;
using Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {
        private ICarImageService _carImageManager;
        private IWebHostEnvironment _webHostEnvironment;

        public CarImagesController(ICarImageService carImageManager, IWebHostEnvironment webHostEnvironment)
        {
            _carImageManager = carImageManager;
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpPost("add")]
        public IActionResult Add([FromForm] CarImage fileUpload)
        {
            if (fileUpload.Files.Length > 0)
            {
                string path = _webHostEnvironment.WebRootPath + "\\Images\\";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                string guid = Guid.NewGuid().ToString();
                var extension = ("." + (fileUpload.Files.FileName.Split(".")[1].ToString()));

                using (FileStream fileStream = System.IO.File.Create(path + guid + extension))
                {
                    fileUpload.Files.CopyTo(fileStream);
                    fileStream.Flush();
                    return Ok(Messages.Uploaded);
                }
            }
            else
            {
                return BadRequest(Messages.NotUploaded);
            }
        }

        //public IActionResult Update([FromForm] CarImage )
        //{

        //}
    }
}
