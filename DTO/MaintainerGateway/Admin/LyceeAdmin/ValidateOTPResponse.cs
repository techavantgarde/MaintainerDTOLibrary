namespace DTO.MaintainerGateway.Admin.LyceeAdmin
{
    public class ValidateOTPResponse
    {
        public string? UserID { get; set; }
        public required bool IsOtpValidated { get; set; }
    }
}