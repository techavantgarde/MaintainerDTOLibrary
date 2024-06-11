namespace MaintainerDTOLIBRARY.UserService
{
    public class InsertUserConnectionRequest
    {
        public string? UserID { get; set; }
        public string? ReferenceID { get; set; }
        public string? UTLiTableID { get; set; }
        public string? CreatedBy { get; set; }
    }
}