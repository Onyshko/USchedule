namespace USchedule.Service.Models.AccountModels
{
    public class ForgotPasswordModel
    {

        public required string Email { get; set; }

        public required string ClientUri { get; set; }
    }
}
