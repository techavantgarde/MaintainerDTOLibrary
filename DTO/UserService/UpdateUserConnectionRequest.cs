namespace MaintainerDTOLIBRARY.UserService
{
    public class UpdateUserConnectionRequest
    {
        public string? UserConnectionID { get; set; }
        public string? UserID { get; set; }
        public string? ReferenceID { get; set; }
        public string? UTLiTableID { get; set; }
        public string? UpdatedBy { get; set; }
    }
}