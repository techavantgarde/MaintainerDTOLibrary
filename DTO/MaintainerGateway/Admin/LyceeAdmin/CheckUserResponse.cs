namespace DTO.MaintainerGateway.Admin.LyceeAdmin
{
    public class CheckUserResponse
    {
        public bool? PhoneNumberExists{ get; set; }
        public bool? EmailAddressExists{ get; set; }
        public bool? UserNameExists{ get; set; }
    }
}