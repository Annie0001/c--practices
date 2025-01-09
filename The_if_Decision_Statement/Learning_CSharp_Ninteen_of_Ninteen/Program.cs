// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

var p1 = new Person ("Scott","Hanselman", new DateOnly(1970,1,1));
var p2 = new Person ("David","fowler",new DateOnly(1986,1,1));
public class Person
{
    private string firstname;
    private string lastname;
    private DateOnly birthday;
    public Person(string first, string last, DateOnly bd)
    {
        firstname = first;
        lastname = last;
        birthday = bd;

    }
}