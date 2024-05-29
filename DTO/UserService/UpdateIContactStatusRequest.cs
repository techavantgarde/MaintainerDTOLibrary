namespace MaintainerDTOLIBRARY.UserService
{
    public class UpdateIContactStatusRequest
    {
        public required string IContactStatusID{get;set;}
        public string? Name{get;set;}
        public byte? PriorityValue{get;set;}
        public string? UpdatedBy{get;set;}
    }
}