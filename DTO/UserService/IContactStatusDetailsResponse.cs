namespace MaintainerDTOLIBRARY.UserService
{
    public class IContactStatusDetailsResponse
    {
        public string? IContactStatusID{get;set;}
        public string? Name{get;set;}
        public byte? PriorityValue{get;set;}
        public string? CreatedBy{get;set;}
        public string? UpdatedBy{get;set;}
        public DateTime? CreatedDate{get;set;}
        public DateTime? UpdatedDate{get;set;}
    }
}