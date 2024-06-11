namespace MaintainerDTOLIBRARY.UserService
{
    public class UpdateFullAssociationRequest
    {
        public required string AssociationID{get;set;}
        public string? Name{get;set;}
        public bool? IsDeleted{get;set;}
        public string? StatusReferenceID{get;set;}
        public string? StatusITableID{get;set;}
        public string? UpdatedBy{get;set;}
    }
}