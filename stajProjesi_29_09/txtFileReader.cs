using System;
using System.IO;

namespace stajProjesi_29_09
{
    public class TxtFileReader : IFileService
    {
        public bool CanRead(string fileExtension)
        {
            return string.Equals(fileExtension, ".txt", StringComparison.OrdinalIgnoreCase);
        }

        public string ReadFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("Seçilen .txt dosyası bulunamadı.");
            }
            return File.ReadAllText(filePath);
        }
    }
}
