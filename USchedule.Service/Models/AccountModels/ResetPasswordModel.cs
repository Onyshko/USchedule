namespace USchedule.Service.Models.AccountModels
{
    public class ResetPasswordModel
    {
        public required string Password { get; set; }

        public required string ConfirmPassword { get; set; }

        public required string Email { get; set; }
    }
}
