namespace MaintainerDTOLIBRARY.UserService
{
    public class InsertIdentityRequest
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? ITableID { get; set; }
        public string? ReferenceID { get; set; }
        public string? CreatedBy { get; set; }
        public string? Salt { get; set; }
    }
}