namespace MaintainerDTOLIBRARY.UserService
{
    public class GetGovernanceDetailsColumnRequest
    {
        public string? GovernanceColumnID{get;set;}
        public string? FieldName { get; set; }
        public string? DataType { get; set; }
        public string? Value { get; set; }
        public string? CreatedBy { get; set; }
        public string? ComponentName{get; set; }
        public string? UpdatedBy { get; set; }
        public string? GovernanceID { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}