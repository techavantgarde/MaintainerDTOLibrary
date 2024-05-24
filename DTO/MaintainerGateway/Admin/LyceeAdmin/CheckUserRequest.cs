namespace DTO.MaintainerGateway.Admin.LyceeAdmin
{
    public class CheckUserRequest
    {
        public string? PhoneNumber{ get; set; }
        public string? EmailAddress{ get; set; }
        public string? UserName{ get; set; }
    }
}