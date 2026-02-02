using System;

public class Employee
{
    //id
    public required int? Id { get; init; }

    //Firtname
    private string _firstName;
    public required string FirstName
    {
        get => _firstName;
        init => _firstName = value.Trim();
    }

    //lastname
    private string _lastName = "";
    public string LastName
    {
        get => _lastName;
        init => _lastName = value.Trim();
    }

    //fulname
    public string FullName => $"{FirstName} {LastName}";

    //salary
    private double _salary;
    public required double Salary
    {
        get => _salary;
        init
        {
            if (value < 0)
            {
                throw new ArgumentException("salary should be greater than 0");
            }
            _salary = value;
        }
    }


    //ToString
    public void Display()
    {
        Console.WriteLine($"Id is: {Id} | Name is: {FullName} | Salary is: {Salary}");
    }

}