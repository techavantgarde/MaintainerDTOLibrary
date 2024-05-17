namespace DTO.ApiGateway.Handler.UtilityService
{
    public class UpdateRegionLabelRequest
    {
        public required string RegionLabelID { get; set; }
        public string? Region1ID { get; set; }
        public string? Region1Label { get; set; }
        public string? Region2Label { get; set; }
        public string? Region3Label { get; set; }
        public string? Region4Label { get; set; }
        public string? UpdatedBy { get; set; }
    }
}