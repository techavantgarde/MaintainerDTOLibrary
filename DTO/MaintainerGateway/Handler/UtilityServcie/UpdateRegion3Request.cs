namespace DTO.ApiGateway.Handler.UtilityService
{
    public class UpdateRegion3Request
    {
        public required string Region3ID { get; set; }
        public string? Region3Name { get; set; }
        public string? Region2ID { get; set; }
        public string? UpdatedBy { get; set; }
    }
}