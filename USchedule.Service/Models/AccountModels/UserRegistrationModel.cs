namespace USchedule.Service.Models.AccountModels
{
    public class UserRegistrationModel : UserModel
    {
        public required string Password { get; set; }

        public required string ConfirmPassword { get; set; }

        public required string ClientUri { get; set; }
    }
}
