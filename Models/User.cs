namespace CookBookWebSQL.Models;
public class User
{
    public int Id {get;set;}
    public string UserName {get;set;} = "";
    public string Email {get;set;} = "";
    public string Password {get;set;} =string.Empty;
    public string PhoneNumber {get;set;} = string.Empty;
    public string Roles {get;set;} = string.Empty;
    public List<UserImage> Images {get;set;} = [];
    public bool IsEmailConfirmed {get;set;}
    public bool IsPhoneNumberConfirmed {get;set;}
    public DateTime createdDate {get;set;}
    public DateTime updatedDate{get;set;}
}

