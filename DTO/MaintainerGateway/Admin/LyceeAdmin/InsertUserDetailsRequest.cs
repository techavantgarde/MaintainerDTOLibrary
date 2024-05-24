namespace DTO.MaintainerGateway.Admin.LyceeAdmin
{
    public class InsertUserDetailsRequest
    {
        public required string CreatedBy { get; set; }
        public required string GroupID { get; set; }
        public string? ImageName { get; set; }
        public byte[]? ImageContent { get; set; }
        public string? ImageTypeID { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string RegionID { get; set; }
        public required long PhoneNumber { get; set; }
        public required string EmailID { get; set; }
        public required string AdditionalAddress { get; set; }
        public required string Landmark { get; set; }
        public required string ZipCodeID { get; set; }
    }

}