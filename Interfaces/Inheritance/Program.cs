using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance;

class Program
{
    static void Main(string[] args)
    {
        Person[] persons = new Person[3]
        {
            new Customer
            {
                FistName="Hilal"
            },
            new Student
            {
                FistName="Eda"
            },
            new Person
            {
                FistName="Engin"
            }
        };
        foreach (var person in persons)
        {
            Console.WriteLine(person.FistName);  
        }
        Console.ReadLine();
    }
}
class Person
{
    public int Id { get; set; }
    public string FistName { get; set; }
    public string LastName { get; set; }
}

class Customer : Person
{
    public string City { get; set; }
}
class Student : Person
{
    public string Department { get; set; }
}