namespace MaintainerDTOLIBRARY.SolutionService
{
    public class UpdateProductRequest
    {
        public string? ProductCode{get;set;}
        public string? ProductName{get;set;}
        public string? UpdatedBy{get;set;}
        public required string ProductID{get;set;}

    }
}