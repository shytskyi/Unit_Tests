using BL.MOQ.EmailService;
using Moq;

namespace UnitTestProject
{
    public class MOQEmailServiceTest
    {
        [Fact]
        public void SendEmail_OneArgumentIsEmpty_ReturnExeption()
        {
            //Arange
            string recipient = "";
            string subject = "unit test";
            string body = "test body";
            var mock = new Mock<IEmailService>();
            mock.Setup(x => x.SendEmail(recipient, subject, body))
                .Throws(new ArgumentException("Jeden z parametrów nie został podany."));
            var service = new EmailService(mock.Object);

            //Act Assert
            Assert.Throws<ArgumentException>(() => service.SendEmail(recipient, subject, body));

        }

        [Fact]
        public void SendEmail_OneArgumentIsSpace_ReturnExeption()
        {
            //Arange
            string r = " ";
            string s = "test";
            string b = "test";
            var mock = new Mock<IEmailService>();
            mock.Setup(x => x.SendEmail(r, s, b))
                .Throws(new ArgumentException("Jeden z parametrów nie został podany."));
            var service = new EmailService(mock.Object);

            //Act Assert
            Assert.Throws<ArgumentException>(() => service.SendEmail(r, s, b));
        }

        [Fact]
        public void SendEmail_TrueArgument_ReturnExeption()
        {
            string r = "test";
            string s = "test";
            string b = "test";
            var mock = new Mock<IEmailService>();
            mock.Setup(x => x.SendEmail(r, s, b))
                .Throws(new Exception("Wystąpił błąd podczas wysyłania wiadomości e-mail."));
            var service = new EmailService(mock.Object);

            var result = Assert.Throws<Exception>(() => service.SendEmail(r, s, b));
            Assert.Equal("Wystąpił błąd podczas wysyłania wiadomości e-mail.", result.Message);
        }
    }
}
