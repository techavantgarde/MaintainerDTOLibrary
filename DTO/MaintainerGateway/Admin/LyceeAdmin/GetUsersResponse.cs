namespace DTO.MaintainerGateway.Admin.LyceeAdmin
{
    public class GetUsersResponse
    {
        public required string UserId { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Role { get; set; }
    }
}
