namespace DTO.MaintainerGateway.Admin.LyceeAdmin
{
    public class GetAdminsWithoutInstitutions
    {
        public string? UserID{get;set;}
        public string? FirstName{get;set;}
        public string? LastName{get;set;}
        public string? IsDeleted { get; set; }
        public string? StatusReferenceID{get;set;}
        public string? StatusITableID{get;set;}
        public string? CreatedBy{get;set;}
        public string? UpdatedBy{get;set;}
        public DateTime? CreatedDate{get;set;}
        public DateTime? UpdatedDate{get;set;}
    }
}