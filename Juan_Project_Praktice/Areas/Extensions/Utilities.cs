using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Juan_Project_Praktice.Areas.Extensions
{
    public static class Utilities
    {
        public static async Task<string> FileUpload(this IFormFile file,string root,string folder)
        {
            

            string fileName = Guid.NewGuid()+ file.FileName;
            string path = Path.Combine();
            string fullPath = Path.Combine(path, fileName);

            using (FileStream stream = new FileStream(fullPath,FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            return fileName;
        }
    }
}
