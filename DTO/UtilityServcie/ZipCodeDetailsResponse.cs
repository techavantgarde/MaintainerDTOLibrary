namespace DTO.ApiGateway.Handler.UtilityService
{
    public class ZipCodeDetailsResponse
    {
        public string? ZipCodeID{get;set;}
        public string? ZipCode{get;set;}
        public string? Region1ID{get;set;}
        public string? Region2ID{get;set;}
        public string? Region3ID{get;set;}
        public string? Region4ID{get;set;}
        public string? CreatedBy{get;set;}
        public string? UpdatedBy{get;set;}
        public DateTime? CreatedDate{get;set;}
        public DateTime? UpdatedDate{get;set;}
    }
}