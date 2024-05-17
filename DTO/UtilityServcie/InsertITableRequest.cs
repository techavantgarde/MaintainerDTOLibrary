namespace DTO.ApiGateway.Handler.UtilityService
{
    public class InsertITableRequest
    {
        public required string IDBID { get; set; }
        public required string Name { get; set; }
        public required string CreatedBy { get; set; }
        public required string Description { get; set; }

    }
}