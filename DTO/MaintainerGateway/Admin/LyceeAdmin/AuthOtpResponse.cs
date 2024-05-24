namespace DTO.MaintainerGateway.Admin.LyceeAdmin
{
    public class AuthOtpResponse
    {
        public required bool IsDefaultOtp { get; set; }
        public required bool IsOtpAvailable { get; set; }
        public required bool IsPasswordAvailable { get; set; }
    }
}
