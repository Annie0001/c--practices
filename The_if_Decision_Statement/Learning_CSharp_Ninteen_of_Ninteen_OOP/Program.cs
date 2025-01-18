// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using Microsoft.VisualBasic;

var p1= new Person("Scott","Smith",new DateOnly(1970,1,1));
var p2= new Person("Aaron","Farfala",new DateOnly(1982,1,1));

// Add dogs for Scott
p1.GetPets().Add(new Dog("JJ","Grey"));
p1.GetPets().Add(new Dog("XoXo","White"));
// Add cats for Aaron
p2.GetPets().Add(new Cat("Lolo","Brown"));
p2.GetPets().Add(new Cat("Phiphi","Blue"));

var PersonList = new List <Person>{p1,p2};
foreach( var person in PersonList)
{
    // Console.WriteLine(person.gGetFirstName());
    Console.WriteLine(person);
    foreach ( var pet in person.GetPets())
    {
        Console.WriteLine($" pet: {pet} ");
    }
}
public class Person
{
    private string firstname;
    private string lastname;
    private DateOnly birthday;

    private List<Pet> pets = new List<Pet>{};

    public Person(string fName,string lName,DateOnly bd)
    {
        firstname = fName;
        lastname = lName;
        birthday = bd;                 

    }
    public List<Pet> GetPets()
    {
        return pets;
    }
    public string GetFirstName()
    {
        return firstname;
    }

    // Override method used ti stringify the person object's properties first name and last name
    public override string ToString()
    {
        // You can return any string that you want such as "good person" so 
        // when you console.write(person), it will print out good person.
        return $"{firstname} {lastname}";
    }
}
public abstract class Pet
{
    //private string name;
    // we changed this scope to protected so that the classes that derive this abstract class can inherite
    // this property. In this case we used this field for both Dog and Cat classes
    protected string name;
    //private string color;
    protected string color;
    public abstract string Makesound();

    public override string ToString()
    {
        return $"{name} {color}";
    }
}
public class Dog : Pet
{
    public Dog(string dogName, string dogColor)
    {
        name = dogName;
        color = dogColor;
    }
    public override string Makesound()
    {
        return "Bark";
    }
}
public class Cat : Pet
{   
    public Cat(string catName, string catColor)
    {
        name = catName;
        color = catColor;
    }
    public override string Makesound()
    {
        return "Meow";
    }
}

