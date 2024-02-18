using BL.MOQ.ContactService;

namespace BL.MOQ.FileService
{
    public class FileService
    {
        private readonly IFileSystem _fileSystem;

        public FileService()
        {
            
        }
        public FileService(IFileSystem fileSystem)
        {
            _fileSystem = fileSystem;
        }

        public bool IsFileExists(string filePath)
        {
            return _fileSystem.IsFileExists(filePath);
        }

        public bool IsFileExistsMethod(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                throw new ArgumentException("Sciezka pliku nie moze byc pusta ani miec wartosc null.",
                                                                                            nameof(filePath));
            }

            return File.Exists(filePath);
        }
    }
}
