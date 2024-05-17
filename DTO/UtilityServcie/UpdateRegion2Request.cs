namespace DTO.ApiGateway.Handler.UtilityService
{
    public class UpdateRegion2Request
    {
        public required string Region2ID { get; set; }
        public string? Region2Name { get; set; }
        public string? Region1ID { get; set; }
        public string? UpdatedBy { get; set; }
    }
}