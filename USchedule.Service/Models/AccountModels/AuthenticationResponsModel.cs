namespace USchedule.Service.Models.AccountModels
{
    public class AuthenticationResponsModel
    {
        public bool IsAuthSuccessful { get; set; }

        public string? ErrorMessage { get; set; }

        public string? Token { get; set; }
    }
}
