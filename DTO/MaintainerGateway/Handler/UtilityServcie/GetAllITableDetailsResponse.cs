namespace DTO.ApiGateway.Handler.UtilityService
{
    public class GetAllITableDetailsResponse
    {
        public required string ITableID { get; set; }
        public required string IDBID { get; set; }
        public required string Name { get; set; }
        public required string CreatedBy { get; set; }
        public required string UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? Description { get; set; }    
    }
}