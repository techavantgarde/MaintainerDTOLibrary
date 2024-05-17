
namespace DTO.ApiGateway.Handler.UtilityService
{

    public class InsertDBNameCodeAndDescriptionRequest
    {
        public string? Name { get; set; }
        public string? Code { get; set; }
        public string? CreatedBy { get; set; }
        public string? Description { get; set; }
    }
}