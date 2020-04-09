using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProj.Utilities
{
    public class ImageProcessor
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ImageProcessor(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        public string ProcessImage(IFormFile imageToProcess)
        {
                var uniqueFileName = GetUniqueFileName(imageToProcess.FileName);
                var uploads = Path.Combine(_webHostEnvironment.WebRootPath, "uploads");
                var filePath = Path.Combine(uploads, uniqueFileName);
                imageToProcess.CopyTo(new FileStream(filePath, FileMode.Create));
                return uniqueFileName;
        }

        private string GetUniqueFileName(string fileName)
        {
            fileName = Path.GetFileName(fileName);
            return Path.GetFileNameWithoutExtension(fileName)
                      + "_"
                      + Guid.NewGuid().ToString().Substring(0, 4)
                      + Path.GetExtension(fileName);
        }
    }
}
