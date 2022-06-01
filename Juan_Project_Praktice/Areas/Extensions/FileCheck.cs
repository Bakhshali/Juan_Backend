using Microsoft.AspNetCore.Http;

namespace Juan_Project_Praktice.Areas.Extensions
{
    public static class FileCheck
    {
        public static bool IsImage( this IFormFile file)
        {
            return file.ContentType.Contains("image");
        }

        public static bool IsGreater(this IFormFile file,int mb)
        {
            return file.Length < mb *1024 * 1024;
        }

        public static bool IsOkay(this IFormFile file,int mb)
        {
            return IsGreater(file,mb) && IsImage(file);
        }

    }
}
