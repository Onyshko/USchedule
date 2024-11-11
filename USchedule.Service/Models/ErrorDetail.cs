using System.Text.Json;

namespace USchedule.Service.Models
{
    public class ErrorDetail
    {
        public int StatusCode { get; set; }

        public string? Message { get; set; }

        public override string ToString() => JsonSerializer.Serialize(this);
    }
}
