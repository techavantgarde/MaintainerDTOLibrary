namespace MaintainerDTOLIBRARY.SolutionService
{
    public class UpdateGroupRequest
    {
        public string? GroupCode{get;set;}
        public string? GroupName{get;set;}
        public string? UpdatedBy{get;set;}
        public required string GroupID{get;set;}

    }
}