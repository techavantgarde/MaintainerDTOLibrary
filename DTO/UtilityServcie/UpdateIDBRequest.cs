namespace DTO.ApiGateway.Handler.UtilityService
{
    public class UpdateIDBRequest
    {
        public required string IDBID { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }   
        public string? UpdatedBy { get; set; }
        public string? Description { get; set; }
    }
}