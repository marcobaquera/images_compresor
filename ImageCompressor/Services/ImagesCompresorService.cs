using ImageMagick;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageCompressor.Services
{
    public class ImagesCompresorService
    {

        private const string QualityTargetKey = "QualityTarget";


        public void CompressImages(string[] imagesPath)
        {
            int imageQuality = GetQualityTarget();
            for (int i = 0; i < imagesPath.Length; i++)
            {
                using (var image = new MagickImage(imagesPath[i]))
                {
                    image.Quality = imageQuality;
                    Console.WriteLine("Compresing image {0} from {1}: {2}", i, imagesPath.Length, imagesPath[i]);
                    image.Write(new FileInfo(image.FileName));
                }

            }
        }

        private int GetQualityTarget()
        {
            return int.Parse(ConfigurationManager.AppSettings[QualityTargetKey]);
        }

    }
}
