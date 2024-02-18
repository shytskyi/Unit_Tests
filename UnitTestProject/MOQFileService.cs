using BL.MOQ.FileService;
using Moq;

namespace UnitTestProject
{
    public class MOQFileService
    {
        [Fact]
        public void FileExists_TruePath_ReturnTrue()
        {
            //Arrage
            string filePath = "D:\\File_name.txt";
            var mock = new Mock<IFileSystem>();
            mock.Setup(x => x.IsFileExists(filePath)).Returns(true);

            //Act 
            var service = new FileService(mock.Object);
            var result = service.IsFileExists(filePath);

            //Assert
            Assert.Equal(true, result);
        }

        [Fact]
        public void FileExists_FalsePath_ReturnFalse()
        {
            //Arrage
            string filePath = "D/FalseName.txt";
            var mock = new Mock<IFileSystem>();
            mock.Setup(x => x.IsFileExists(filePath)).Returns(false);

            //Act 
            var service = new FileService(mock.Object);
            var result = service.IsFileExists(filePath);

            //Assert
            Assert.Equal(false, result);
        }

        [Fact]
        public void FileExists_PathEmpty_ReturnExeption()
        {
            //Arrage
            string filePath = "";
            var mock = new Mock<IFileSystem>();
            mock.Setup(x => x.IsFileExists(filePath))
                .Throws( new ArgumentException("Sciezka pliku nie moze byc pusta ani miec wartosc null."));

            //Act 
            var service = new FileService(mock.Object);

            //Assert
            var result = Assert.Throws<ArgumentException>(() => service.IsFileExists(filePath));
            Assert.Equal("Sciezka pliku nie moze byc pusta ani miec wartosc null.", result.Message);
        }


        [Fact]
        public void IsFileExistsMethod_Path_ReturnTrue()
        {
            //Arrage
            string path = "D:\\File_name.txt";

            //Act 
            var service = new FileService();
            var result = service.IsFileExistsMethod(path);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void IsFileExistsMethod_IsNullOrEmpty_ReturnExeption()
        {
            //Arrage
            string path = "";
            var service = new FileService();

            //Act 
            //Assert
            Assert.Throws<ArgumentException>(() => service.IsFileExistsMethod(path));
        }

        [Fact]
        public void IsFileExistsMethod_FalsePath_ReturnFalse()
        {
            //Arrage
            string path = "D:\\False_name.txt";

            //Act 
            var service = new FileService();
            var result = service.IsFileExistsMethod(path);

            //Assert
            Assert.False(result);
        }
    }
}
