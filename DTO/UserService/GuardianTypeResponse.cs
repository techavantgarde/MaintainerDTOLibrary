using System.Diagnostics.Contracts;

namespace MaintainerDTOLIBRARY.UserService
{
    public class GuardianTypeResponse
    {
        public string? GuardianTypeID { get; set; }
        public string? Name { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}