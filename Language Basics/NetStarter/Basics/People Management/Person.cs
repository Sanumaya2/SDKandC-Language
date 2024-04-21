using System.Dynamic;

public class Person
{
    public int index { get; set;}

    public string userId {get; set;}
    public string firstName {get; set ;}
    public string lastName {get; set;}
    public Gender sex;
    public string email {get; set;}
    public string phone {get; set;}
    public DateTime dob {get; set;}
    public string jobTitle {get; set;}
   
 
}
  public enum Gender
   {
    Male,
    Female,
    Others
   }