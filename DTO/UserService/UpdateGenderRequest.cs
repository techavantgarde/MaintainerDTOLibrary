namespace MaintainerDTOLIBRARY.UserService
{
    public class UpdateGenderRequest
    {
        public required string GenderID {get;set;}
        public string? GenderName {get;set;}
        public string? UpdatedBy {get;set;}
    }
}