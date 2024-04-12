namespace MaintainerDTOLIBRARY.UtilityServcie
{
        public class CombinedDataResponse
        {
            public string? RegionName { get; set; }
            public string? ISOCode2 { get; set; }
            public string? ISOCode3 { get; set; }
            public string? PhoneCode { get; set; }
            public string? Currency { get; set; }
            public string? Symbol { get; set; }
            public string? ISOCurrencyCode { get; set; }
            public decimal? ConversionRate { get; set; }
            public string? Region1Label { get; set; }
            public string? Region2Label { get; set; }
            public string? Region3Label { get; set; }
            public string? Region4Label { get; set; }
            public List<Sheet2DataResponse>? Sheet2Data { get; set; }
        }
}