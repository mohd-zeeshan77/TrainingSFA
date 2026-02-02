using System;
using System.Runtime.CompilerServices;
using TestConsole.Data;
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


        /*Calculator calc = new();
        calc.add();
        calc.sub();
        calc.mul();

        StudentDto? ob = null;
        calc.save(ob);*/



        AppDbContext dbContext = new AppDbContext();
        /*  IQueryable<string> filteredStates = dbContext.state
              .OrderBy(x => x.Name)
              .Where(state => state.Name.Contains("Pradesh"))
              .Select(state => state.Name);*/
        var filteredStates = dbContext.state
            .OrderBy(x => x.Name)
            .ToList();

        foreach (var st in filteredStates)
        {
            Console.WriteLine($"{st.Id} : {st.Name} : {st.Code}");
        }


        /*foreach (var state in filteredStates)
        {
            Console.WriteLine(state);
        }*/

        //Console.ReadKey();
    }
}