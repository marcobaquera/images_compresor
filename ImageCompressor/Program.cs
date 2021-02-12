using ImageCompressor.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageCompressor
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var folderPathService = new FolderPathService();
                var imagesCompresorService = new ImagesCompresorService();
                var imagesPaths = folderPathService.GetImagesPath();
                imagesCompresorService.CompressImages(imagesPaths);
                Console.WriteLine("Compresion finalizada");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
