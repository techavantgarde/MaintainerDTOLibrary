namespace MaintainerDTOLIBRARY.UserService
{
    public class UpdateFullManagementRequest
    {
        public required string ManagementID{get;set;}
        public string? Name{get;set;}
        public string? IsDeleted{get;set;}
        public string? StatusReferenceID{get;set;}
        public string? StatusITableID{get;set;}
        public string? UpdatedBy{get;set;}
    }
}