namespace DTO.ApiGateway.Clients.LyceeEGovernance
{
    public class AuthOtpRequest
    {
        public required string UserIdentity { get; set; }
        public string? CountryID { get; set; }
    }
}
