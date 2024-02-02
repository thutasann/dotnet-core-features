using email_mailkit_smtp.Dto;

namespace email_mailkit_smtp.Interfaces
{
    public interface IEmailNotificationRepository
    {
        Task SendEmailAsync(MailRequest mailRequest);
    }
}