namespace DTO.MaintainerGateway.Admin.LyceeAdmin
{
    public class GetUserPreRequisiteResponse
    {
        public required List<GetUserPreRequisiteImages> getUserPreRequisiteImages { get; set; } = new();
        public required List<GetUserPreRequisiteGroups> getUserPreRequisiteGroups { get; set; } = new();
        public required List<GetUserPreRequisitePhoneCodes> getUserPreRequisitePhoneCodes { get; set; } = new();
    }

    public class GetUserPreRequisiteImages
    {
        public required string ImgTypeID { get; set; }
        public required string ImageType { get; set; }
    }

    public class GetUserPreRequisiteGroups
    {
        public required string GroupID { get; set; }
        public required string Name { get; set; }
        public required string Code { get; set; }
    }

    public class GetUserPreRequisitePhoneCodes
    {
        public required string RegionID { get; set; }
        public required string RegionName { get; set; }
        public required string PhoneCode { get; set; }
        public required string IsoCode3 { get; set; }
    }

    
}