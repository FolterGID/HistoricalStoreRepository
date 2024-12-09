using Microsoft.Extensions.Options;
using System.Net;
using System.Net.Mail;

namespace HistoricalStore.Api.Services
{
    public class EmailService(IOptions<EmailSettings> options)
    {
        private readonly EmailSettings _settings = options.Value;

        public async Task SendAsync(string to, string subject, string body)
        {
            var smtpClient = new SmtpClient(_settings.Host)
            {
                Port = _settings.Port,
                Credentials = new NetworkCredential(_settings.UserName, _settings.Password),
                EnableSsl = _settings.EnableSSL
            };

            var mailMessage = new MailMessage
            {
                From = new MailAddress(_settings.UserName),
                Subject = subject,
                Body = body,
                IsBodyHtml = true
            };
            mailMessage.To.Add(to);

            await smtpClient.SendMailAsync(mailMessage);
        }
    }
}
