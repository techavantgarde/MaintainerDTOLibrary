namespace MaintainerDTOLIBRARY.UserService
{
    public class GetFullAssociationDetailsResponse
    {
        public string? AssociationID{get;set;}
        public string? AssociationName{get;set;}
        public bool? IsDeleted{get;set;}
        public string? StatusReferenceID{get;set;}
        public string? StatusITableID{get;set;}
        public string? CreatedBy{get;set;}
        public string? UpdatedBy{get;set;}
        public DateTime? CreatedDate{get;set;}
        public DateTime? UpdatedDate{get;set;}
    }
}