using System;
using System.Runtime.CompilerServices;
public class Program
{
    public static void Main(string[] args)
    {

        /* Employee emp = new()
         {
             Id = 1,
             FirstName = "John",
             LastName = "Stew",
             Salary = 25000.00
         };
         Employee emp2 = new()
         {
             Id = 2,
             FirstName = "Cinna",
             Salary = 1000.23
         };
         Employee emp3 = new()
         {
             Id = 3,
             FirstName = "Jack      ",
             LastName = "    Thyme     ",
             Salary = 231000
         };
         emp.Display();
         emp2.Display();
         emp3.Display();*/


        Calculator calc = new();
        calc.add();
        calc.sub();
        calc.mul();

        StudentDto? ob = null;
        calc.save(ob);
        //Console.ReadKey();
    }
}
