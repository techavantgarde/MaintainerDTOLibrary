namespace DTO.MaintainerGateway.Admin.LyceeAdmin
{
    public class AuthOtpRequest
    {
        public required string UserIdentity { get; set; }
        public string? CountryID { get; set; }
    }
}
