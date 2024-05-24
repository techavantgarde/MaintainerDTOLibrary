namespace DTO.MaintainerGateway.Admin.LyceeAdmin
{
    public class ValidateOTPRequest
    {
        public required int Otp { get; set; }
        public required string UserIdentity { get; set; }
    }
}
