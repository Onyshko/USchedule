namespace USchedule.Repository.Models
{
    public class JwtSettingsModel
    {
        public string? ValidIssuer { get; set; }

        public string? ValidAudience { get; set; }

        public string? SecurityKey { get; set; }

        public string? ExpiryInMinutes { get; set; }
    }
}
