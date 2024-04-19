//language Integrated query

//Imperative [Procedural , oop etc] (C, C++, C#) 
//Declarative
using System.Security.AccessControl;

class LINQ
{
    int[] ages = [12,45,78,89];
// find squares of all numbers in ages collection.
public void LearnLinq()
{
List<int>squares =[];
foreach(var age in ages)
{
    var square = age * age;
    squares.Add(square);
}
//declarative
// var squares = ages.Select(age => age *age);
//  var squaresAlternate = from age in ages select age * age;

//find odd numbers within ages
    var odds = ages.Where(x => x % 2 == 1);

    //find cube of all even numbers within ages collection.
    var cubesofEvenNumber = ages.Select(age => age * age);
    
}


}



