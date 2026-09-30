namespace stajProjesi_29_09
{



    public interface IFileService
    {
        bool CanRead(string fileExtension);
        string ReadFile(string filePath);
    }

}