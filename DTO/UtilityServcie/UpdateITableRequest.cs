namespace DTO.ApiGateway.Handler.UtilityService
{
    public class UpdateITableRequest
    {
        public  string? IDBID { get; set; }
        public required string ITableID { get; set; }
        public  string? Name { get; set; }
        public  string? UpdatedBy { get; set; }
        public  string? Description { get; set; }
    }
}