using USchedule.Repository.Models;

namespace USchedule.Repository.Interfaces
{
    public interface IEmailSender
    {
        void SendEmail(Message message);

        Task SendEmailAsync(Message message);
    }
}
