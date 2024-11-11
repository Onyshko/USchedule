namespace USchedule.Service.Interfaces
{
    public interface IJwtService
    {
        Task<string> CreateToken(string email);
    }
}
