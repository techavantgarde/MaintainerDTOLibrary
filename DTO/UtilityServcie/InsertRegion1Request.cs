namespace DTO.ApiGateway.Handler.UtilityService
{
    public class InsertRegion1Request
    {
        public string? RegionName{get;set;}
        public string? IsoCode2{get;set;}
        public string? IsoCode3{get;set;}
        public string? PhoneCode{get;set;}
        public string? Currency{get;set;}
        public string? CurrencySymbol{get;set;}
        public string? IsoCurrencyCode{get;set;}
        public decimal? ConversionRate{get;set;}
        public string? CreatedBy{get;set;}
    }
}