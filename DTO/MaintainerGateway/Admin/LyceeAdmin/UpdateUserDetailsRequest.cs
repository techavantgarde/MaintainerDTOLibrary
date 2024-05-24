namespace DTO.ApiGateway.Clients.LyceeEGovernance
{
    public class UpdateUserDetailsRequest
    {
        public required string UserIdentity { get; set; }
        public required string UpdatedBy { get; set; }


        public string? NewGroupID { get; set; }
        public string? CurrentGroupID { get; set; }


        public string? ImageID { get; set; }
        public string? ImageName { get; set; }
        public byte[]? ImageContent { get; set; }
        public string? ImageTypeID { get; set; }


        public string? FirstName { get; set; }
        public string? LastName { get; set; }


        public string? ContactNumberID { get; set; }
        public string? RegionID { get; set; }
        public long? PhoneNumber { get; set; }


        public string? ContactEmailID { get; set; }
        public string? EmailID { get; set; }


        public string? AddressID { get; set; }
        public string? AdditionalAddress { get; set; }
        public string? Landmark { get; set; }
        public string? ZipCodeID { get; set; }

        public List<string>? DeletedUrlID { get; set; }
        public List<UpdateUserDetailsUrl>? updateUserDetailsUrls { get; set; } = new();
    }

    public class UpdateUserDetailsUrl
    {
        public string? UrlID { get; set; }
        public string? Url { get; set; }
        public string? LabelID { get; set; }
    }
}