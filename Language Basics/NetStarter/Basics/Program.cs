// See https://aka.ms/new-console-template for more information
// using System;
// using Inheritance;
// using System;
// using System.Threading;
// using System.Threading.Tasks;
//top level statement
// Student s1 = new();
// Student s2 = new();
// Student s3 = new();
// Student s4 = new();
// Student s5 = new();
// Student s6 = new();


// s1.name = "karan";
// s1.address = "ktm";
// s1.roll = 23;
// s1.dob = new DateTime(1990,12,13);
// // Console.WriteLine(s1.name"  " + s1.address"  " + s1.roll"  " + s1.dob"  ");
// Console.WriteLine($"{s1.name}  {s1.address}  {s1.roll}  {s1.dob}");
// s1.PrintDetails();


//Create Animal class
// Animal a1 = new();
// Animal a2 = new();

// a1.name = "Dog";
// a1.color = "black";
// a1.age = 4;
// a1.weight = 45;
// a1.sound = "Bark";
// Console.WriteLine($"Name:{a1.name}  Color:{a1.color}  Age:{a1.age}  Weight:{a1.weight}   Sound:{a1.sound}");

// a2.name = "Cat";
// a2.color = "black and white";
// a2.age = 6;
// a2.weight = 20;
// a2.sound = "Meow";
// Console.WriteLine($"Name:{a2.name}  Color:{a2.color}  Age:{a2.age}  Weight:{a2.weight}  Sound:{a2.sound}");

//Create rectangle class
// var rec1 = new Rectangle( 5.6 , 3.4);
// var p = rec1.GetPerimeter();

// var rec2 = new Rectangle( 5.6 , 3.4);
// var a = rec1.GetArea();

// Console.WriteLine("Rectangle 1 - Perimeter:" + p);
// Console.WriteLine("Rectangle 2 - Area:" + a);

//Create square class
// var square1 = new Square(23.5);
// var b = square1.GetArea();
// var h = square1.GetPerimeter();
// Console.WriteLine("Square 1 - Perimeter:" + h);
// Console.WriteLine("Square 2 - Area:" + b);

//create circle class
// var cir1 = new Circle(12.5);
// var c = cir1.GetArea();
// var d = cir1.GetPerimeter();
// Console.WriteLine("Circle 1- Perimeter:" + d);
// Console.WriteLine("Circle 2 - Area:" + c);

//filefolderhandling
//  var fileio = new FileIO();
//  fileio.CreateFile();

//  fileio.CreateFileWithInFolder();

//People Management
// string filePath = @"D:\SDKandC-Language\Language Basics\NetStarter\Basics\People Management\People.csv";
// CSVParser parser = new();
// parser.Parse();
//  parser.PrintNames();
//Student.cs
// Student.PrintStudentType();

//linq
// LINQ linq = new LINQ();
// linq.LearnLinq();


// parallel and async programming
//  ParallelAsync parallelAsync = new ParallelAsync();
//  parallelAsync.ProcessNumbers();

// await parallelAsync.IgniteStove();
// await parallelAsync.GrindMasala();
// await parallelAsync.PutkeatleyOnWithWater();
// await parallelAsync.IgniteStove();

//collegedb
// using System.Net.Sockets;
// using System.Reflection.Metadata.Ecma335;
// using System.Security.AccessControl;
// using NetStarter.Basics.DataAccess;

// BasicDbContext Db = new();

// var teacher1 = new Teacher
// {
//     Name = "Laxman",
//     Address = "Dang",
//     Gender = 'M',
//     Qualification ="Graduate",
//     dob = new DateTime(2000 ,  1, 3)

// };

// Db.Teachers.Add(teacher1);
// Db.SaveChanges();  //commit change

// // var teachers = Db.Teachers.ToList();  //select * from teacher

// //list all female teachers from dang
// var teachers = Db.Teachers.Where(x=> x.Gender =='M' && x.Address == "Dang")
// // .Select(y=> y.name);
// .ToList(); //linq
// foreach(var teacher in teachers)
// {
//     Console.WriteLine($"Name:{teacher.Name} , Dob: {teacher.dob}");
// }



CsvParser parser = new CsvParser();
List<Person> people = parser.Parse();

// Create instance of PeopleReport
PeopleReport report = new PeopleReport();

// Generate and save reports
report.SaveMales(people.ToArray(), "males.csv");
report.SaveAdultFemales(people.ToArray(), "adultfemales.csv");
report.SaveDotComUsers(people.ToArray(), "dotcomusers.csv");




