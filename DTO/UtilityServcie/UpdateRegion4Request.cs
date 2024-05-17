namespace DTO.ApiGateway.Handler.UtilityService
{
    public class UpdateRegion4Request
    {
        public required string Region4ID { get; set; }
        public string? Region4Name { get; set; }
        public string? Region3ID { get; set; }
        public string? UpdatedBy { get; set; }
    }
}