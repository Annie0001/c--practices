// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using Microsoft.VisualBasic;

var p1= new Person("Scott","Smith",new DateOnly(1970,1,1));
var p2= new Person("Aaron","Farfala",new DateOnly(1982,1,1));

var PersonList = new List <Person>{p1,p2};
foreach( var person in PersonList)
{
    Console.WriteLine(person.getFirstName());
}
public class Person
{
    private string firstname;
    private string lastname;
    private DateOnly birthday;

    public Person(string fName,string lName,DateOnly bd)
    {
        firstname = fName;
        lastname = lName;
        birthday = bd;

    }
    public string getFirstName()
    {
        return firstname;
    }

}

