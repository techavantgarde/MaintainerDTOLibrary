namespace MaintainerDTOLIBRARY.UserService
{
    public class InsertGovernanceColumnRequest
    {
        public string? GovernanceID{get;set;}
        public string? FieldName { get; set; }
        public string? DataType { get; set; }
        public string? Value { get; set; }
        public string? CreatedBy { get; set; }
        public string? ComponentName{get; set; }
    }
}