using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;

namespace Core.Utilities.FileHelper
{
    public class FileHelper
    {
        public static string AddAsync(IFormFile file)
        {
            var result = PathAndNameCreator(file);

            try
            {
                var sourcePath = Path.GetTempFileName();

                using (var stream = new FileStream(sourcePath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                File.Move(sourcePath, result.path);
            }
            catch (Exception exception)
            {

                return exception.Message;
            }

            return result.pathAndName;
        }

        public static string UpdateAsync(string sourcePath, IFormFile file)
        {
            var result = PathAndNameCreator(file);

            try
            {
                using (var fileStream = new FileStream(result.path, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }

                File.Delete(sourcePath);
            }
            catch (Exception excepiton)
            {
                return excepiton.Message;
            }

            return result.pathAndName;
        }

        public static IResult DeleteAsync(string path)
        {
            try
            {
                File.Delete(path);
            }
            catch (Exception exception)
            {
                return new ErrorResult(exception.Message);
            }

            return new SuccessResult();
        }

        public static (string path, string pathAndName) PathAndNameCreator(IFormFile file)
        {
            FileInfo fileInfo = new FileInfo(file.FileName);
            string fileExtension = fileInfo.Extension;

            var uniqueFilename = Guid.NewGuid().ToString("N") + fileExtension;

            string result = $@"{Environment.CurrentDirectory + @"\wwwroot\Images"}\{uniqueFilename}";

            return (result, $@"\Images\{uniqueFilename}");
        }
    }
}