using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Schema;
class CSVParser
{
     List<Person> people = [];
    public void Parse()
    {
     // read file
     string filePath = @"D:\SDKandC-Language\Language Basics\NetStarter\Basics\People Management\People.csv";
     var lines = File.ReadAllLines(filePath);
     //parsing
     foreach(var line in lines.Skip(1))
     {
        var parts = line.Split(",", StringSplitOptions.RemoveEmptyEntries);
        var person = new Person
        {
            index = int.Parse(parts[0]),
            userId = parts[1],
            firstName = parts[2],
            lastName = parts[3],
            sex = Enum.Parse<Gender>(parts[4]),
             email = parts[5],
             phone = parts[6],
             dob = DateTime.Parse(parts[7]),
             jobTitle = parts[8]


        };
        people.Add(person);
     }

    }

   public void PrintNames()
   {
    foreach(var person in people)
    {
        Console.WriteLine($"{person.firstName} {person.lastName}");
    }
   }
}