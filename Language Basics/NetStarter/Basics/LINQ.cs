//language Integrated query

//Imperative [Procedural , oop etc] (C, C++, C#) 
//Declarative
using System.Security.AccessControl;
 

class LINQ
{
    int[] ages = [12, 45, 78, 89];
     List<Student> students = [
        new Student() { name = "Ram", address = "Ktm"},
        new Student() { name = "Laxman", address = "Dang"},
        new Student() { name = "Bikendra", address = "Ktm"},
        new Student() { name = "Sandip", address = "Dang"},
        new Student() { name = "Chahana", address = "Dhangadhi"},
    ];
// find squares of all numbers in ages collection.
public void LearnLinq()
    {
        List<int> squares = [];
        foreach (var age in ages)
        {
            var square = age * age;
            squares.Add(square);
        }
        //declarative
        // var squares = ages.Select(age => age *age);
        //  var squaresAlternate = from age in ages select age * age;

        //find odd numbers within ages
        // var odds = ages.Where(x => x % 2 == 1);

        //find cube of all even numbers within ages collection.
        // var cubesofEvenNumber = ages.Where(age => age % 2 == 0) .Select(age => age * age * age);

       // find student who lives in dang and sort the result by names.
       
       var Dang = students.Where(students => students.address == "Dang") .OrderBy(students => students.name);

    }


}



