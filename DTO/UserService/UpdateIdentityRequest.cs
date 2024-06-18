namespace MaintainerDTOLIBRARY.UserService
{
    public class UpdateIdentityRequest
    {
        public string? IdentityID { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? ITableID { get; set; }
        public string? ReferenceID { get; set; }
        public string? UpdatedBy { get; set; }
        public string? Salt { get; set; }
    }
}