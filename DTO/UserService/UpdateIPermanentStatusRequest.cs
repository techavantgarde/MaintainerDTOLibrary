namespace MaintainerDTOLIBRARY.UserService
{
    public class UpdateIPermanentStatusRequest
    {
        public required string IPermanentStatusID{get;set;}
        public string? Name{get;set;}
        public byte? PriorityValue{get;set;}
        public string? UpdatedBy{get;set;}
    }
}