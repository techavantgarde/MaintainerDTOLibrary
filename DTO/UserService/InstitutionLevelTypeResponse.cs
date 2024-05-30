using System.Diagnostics.Contracts;

namespace MaintainerDTOLIBRARY.UserService
{
    public class InstitutionLevelTypeResponse
    {
        public string? InstitutionLevelTypeID { get; set; }
        public string? Name { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}