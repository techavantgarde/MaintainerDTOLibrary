namespace MaintainerDTOLIBRARY.UserService
{
    public class UpdateITemporaryStatusRequest
    {
        public required string ITemporaryStatusID{get;set;}
        public string? Name{get;set;}
        public byte? PriorityValue{get;set;}
        public string? UpdatedBy{get;set;}
    }
}