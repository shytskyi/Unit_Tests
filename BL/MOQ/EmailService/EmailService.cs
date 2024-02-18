namespace BL.MOQ.EmailService
{
    public class EmailService
    {
        private readonly IEmailService _emailSender;

        public EmailService(IEmailService emailSender)
        {
            _emailSender = emailSender;
        }

        public void SendEmail(string recipient, string subject, string body)
        {
            if (string.IsNullOrWhiteSpace(recipient) || string.IsNullOrWhiteSpace(subject)
                                                                || string.IsNullOrWhiteSpace(body))
            {
                throw new ArgumentException("Jeden z parametrów nie został podany.");
            }

            try
            {
                _emailSender.SendEmail(recipient, subject, body);
            }
            catch
            {
                throw new Exception("Wystąpił błąd podczas wysyłania wiadomości e-mail.");
            }
        }
    }
}
