namespace CityInfo.API.Services
{
    public class CouldMailService : IMailService
    {
        private string _mailTo = "admin@mycompany.com";
        private string _mailFrom = "noreply@mycompany.com";

        public void send(string subject, string message)
        {
            // send mail - output to the console window

            Console.WriteLine($"Mail from {_mailFrom} to {_mailTo}, " + $"with {nameof(CouldMailService)}.");
            Console.WriteLine($"Subject: {subject}");
            Console.WriteLine($"Message: {message}");

        }
    }
}