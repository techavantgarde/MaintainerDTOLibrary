namespace MaintainerDTOLIBRARY.UserService
{
    public class UpdateInstitutionLyceeCodeRequest
    {
        public string? Code { get; set; }
        public string? InstitutionID { get; set; }
        public string? UpdatedBy { get; set; }
        public required string InstitutionLyceeCodeID { get; set; }
        
    }
}