namespace MaintainerDTOLIBRARY.UserService
{
    public class GetAllInstitutionDetailsRequest
    {
        public string? InstitutionID { get; set; }
        public string? InstitutionName{get;set;}
        public string? StatusReferenceID { get; set; }
        public string? StatusITableID{get;set;}
        public string? IsDeleted{get;set;}
        public string? CreatedBy{get;set;}
        public DateTime? CreatedDate{get;set;}
        public string? UpdatedBy{get;set;}
        public DateTime? UpdatedDate{get;set;}

    }
}