using System.Diagnostics.Contracts;

namespace MaintainerDTOLIBRARY.UserService
{
    public class CategoryTypeResponse
    {
        public string? InstitutionCategoryTypeID{get;set;}
        public string? GovernanceTypeID{get;set;}
        public string? OwnershipTypeID { get; set; }
        public string? Name { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}