// using System.Runtime.CompilerServices;

class Student
{
    public static string studentType = "Tech";
    public string name;
    // public string Name{
    //     get
    //     {
    //         return name;
    //     }
    //     set
    //     {
    //         if(value != "")
    //         name = value;
    //     }
    // }
    public string address;
    public int roll;
    public DateTime dob;
    public void PrintDetails()
    {
        Console.WriteLine($"{name}  {address}  {roll}  {dob}");
    }
    public static void PrintStudentType()
    {
        Console.WriteLine($"Student Type: {studentType}");
    }
}
// create class called "Animal"
// Define at least 5 internal fields : 
// define a method to print all details of animal in descriptive format
//  In program entry point, create at least two object of Animal 
// initialize fields for each  instance
// // Print details in console
// class Animal
// {
//     internal string name;
//     internal string color;
//     internal int age;
//     internal int weight;
//     internal string sound;
//      internal void PrintDetails()
//     {
//         Console.WriteLine($"{name}  {color}  {age}  {weight}  {sound}");
    // }
// }
