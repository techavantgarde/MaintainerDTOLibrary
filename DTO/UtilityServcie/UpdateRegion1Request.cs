namespace DTO.ApiGateway.Handler.UtilityService
{
    public class UpdateRegion1Request
    {
        public required string Region1ID{get;set;}
        public string? RegionName{get;set;}
        public string? IsoCode2{get;set;}
        public string? IsoCode3{get;set;}
        public string? PhoneCode{get;set;}
        public string? Currency{get;set;}
        public string? CurrencySymbol{get;set;}
        public string? IsoCurrencyCode{get;set;}
        public decimal? ConversionRate{get;set;}
        public string? UpdatedBy{get;set;}

    }
}