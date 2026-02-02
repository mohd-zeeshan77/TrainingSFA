using System;

public class Calculator
{
    public int First { get; private set; }
    public int Second { get; private set; }
    public Calculator()
    {
        First = ReadNumber("Enter First Number: ");
        Second = ReadNumber("Enter Second Number: ");
    }
    private int ReadNumber(string message)
    {
        while (true)
        {
            Console.WriteLine(message);
            if (int.TryParse(Console.ReadLine(), out int value))
            {
                return value;
            }
            Console.WriteLine("enter valid number!");
        }
    }
    public void add()
    {
        Console.WriteLine($"{First} + {Second} = {First + Second}");
    }
    public void sub()
    {
        Console.WriteLine($"{First} - {Second} = {First - Second}");
    }
    public void mul()
    {
        Console.WriteLine($"{First} * {Second} = {First * Second}");
    }
    public void save(StudentDto? ob)
    {

    }
}

public class StudentDto
{

}