using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageCompressor.Services
{
    public class FolderPathService
    {
        public const string FolderPathKey = "FolderTarget";


        public string[] GetImagesPath()
        {
            var folderPath = GetFolderPath();
            return Directory.GetFiles(folderPath, "*.jpg", SearchOption.AllDirectories);
        }
        private string GetFolderPath()
        {
            return ConfigurationManager.AppSettings[FolderPathKey];
        }
    }
}
