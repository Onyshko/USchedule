namespace USchedule.Service.Models.AccountModels
{
    public class UserAuthenticationModel
    {
        public required string Email { get; set; }

        public required string Password { get; set; }
    }
}
