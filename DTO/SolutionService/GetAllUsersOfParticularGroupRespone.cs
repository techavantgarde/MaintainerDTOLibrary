namespace MaintainerDTOLIBRARY.SolutionService
{
    public class GetAllUsersOfParticularGroupResponse
    {
        public  string? EntityGroupID{get;set;}
        public string? GroupID{get;set;}
        public string? UserID{get;set;}
        public string? ITableID{get;set;}
        public string? CreatedBy{get;set;}
        public string? UpdatedBy{get;set;}
        public DateTime? CreatedDate{get;set;}
        public DateTime? UpdatedDate{get;set;}

    }
}