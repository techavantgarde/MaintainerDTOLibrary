namespace DTO.MaintainerGateway.Handler.UserService
{
    public class GetAllUserUserConnectionsResponse
    {
        public string? UserID{get;set;}
        public string? UserConnectionID{get;set;}
        public string? InstitutionID{get;set;}
        public string? ITableID{get;set;}
        public string? CreatedBy{get;set;}
        public string? UpdatedBy{get;set;}
        public DateTime? CreatedDate{get;set;}
        public DateTime? UpdatedDate{get;set;}
    }
}