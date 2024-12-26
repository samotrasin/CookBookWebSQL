namespace CookBookWebSQL.Models;

public class UserImage{
    public int Id {get;set;}
    public string userImagePath {get;set;} = string.Empty;
    public int UserId{get;set;}
    public User? User{get;set;}
}