namespace USchedule.Service.Models.AccountModels
{
    public class UserModel
    {
        public Guid Id { get; set; }

        public string? Name { get; set; }

        public string? Surname { get; set; }

        public required string Email { get; set; }

        public required List<string> Roles { get; set; }
    }
}
