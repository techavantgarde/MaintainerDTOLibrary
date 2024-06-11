namespace MaintainerDTOLIBRARY.UserService
{
    public class UpdateInfrastructureColumnRequest
    {
        public string? InfraColumnID{get;set;}
        public string? FieldName { get; set; }
        public string? DataType { get; set; }
        public string? Value { get; set; }
        public string? UpdatedBy { get; set; }
        public string? ComponentName{get; set; }
    }
}