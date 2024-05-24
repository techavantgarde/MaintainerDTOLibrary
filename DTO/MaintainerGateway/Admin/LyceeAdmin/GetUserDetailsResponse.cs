namespace DTO.MaintainerGateway.Admin.LyceeAdmin
{
    public class GetUserDetailsResponse
    {
        public required string GroupID { get; set; }

        public string? ImageID { get; set; }
        public byte[]? ImageContent { get; set; }
        public string? ImageTypeID { get; set; }


        public required string FirstName { get; set; }
        public required string LastName { get; set; }


        public required string ContactNumberID { get; set; }
        public required string RegionID { get; set; }
        public required long PhoneNumber { get; set; }


        public required string ContactEmailID { get; set; }
        public required string EmailID { get; set; }


        public required string AddressID { get; set; }
        public required string AdditionalAddress { get; set; }
        public string? Landmark { get; set; }
        public required string UTLZipCodeID { get; set; }

    }
   
}