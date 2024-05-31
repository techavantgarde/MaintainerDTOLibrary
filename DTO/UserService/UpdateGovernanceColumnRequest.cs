namespace MaintainerDTOLIBRARY.UserService
{
    public class UpdateGovernanceColumnRequest
    {
        public string? GovernanceColumnID { get; set;}
        public string? FieldName { get; set; }
        public string? DataType { get; set; }
        public string? Value { get; set; }
        public string? UpdatedBy { get; set; }
        public string? GovernanceID { get; set; }
        public string? ComponentName{get; set; }
    }
}