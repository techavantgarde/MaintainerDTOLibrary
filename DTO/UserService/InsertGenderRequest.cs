namespace MaintainerDTOLIBRARY.UserService
{
    public class InsertGenderRequest
    {
        public required string GenderName {get;set;}
        public string? CreatedBy {get;set;}
    }
}