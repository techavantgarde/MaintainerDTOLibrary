namespace DTO.ApiGateway.Handler.UtilityService
{
    public class UpdateZipCodeRequest
    {
        public required string ZipCodeID{get;set;}
        public string? ZipCode{get;set;}
        public string? Region1ID{get;set;}
        public string? Region2ID{get;set;}
        public string? Region3ID{get;set;}
        public string? Region4ID{get;set;}
        public string? UpdatedBy{get;set;}
    }
}