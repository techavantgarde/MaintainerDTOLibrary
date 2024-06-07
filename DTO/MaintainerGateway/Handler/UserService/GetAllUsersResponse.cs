namespace DTO.MaintainerGateway.Handler.UserService
{
    public class GetAllUsersResponse
    {
        public string? UserID{get;set;}
        public string? FirstName{get;set;}
        public bool? LastName{get;set;}
        public bool? IsDeleted { get; set; }
        public string? StatusReferenceID{get;set;}
        public string? StatusITableID{get;set;}
        public string? CreatedBy{get;set;}
        public string? UpdatedBy{get;set;}
        public DateTime? CreatedDate{get;set;}
        public DateTime? UpdatedDate{get;set;}
    }
}