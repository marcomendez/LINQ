using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_MethodClass
{
    class loadvalues
    {
       public void load()
        {
            int[] numbers = { 2, 3, 4, 5 };
            var squaredNumbers = numbers.Select(x => x * x);
            Console.WriteLine(string.Join(" ", squaredNumbers));



            List<string> listName = new List<string>();

            List<Person> people = new List<Person>();
            people.Add(new Person { name = "marc", age = 10 });
            people.Add(new Person { name = "carlo", age = 20 });
            people.Add(new Person { name = "marc", age = 30 });

            people.ForEach(name =>
           {
               listName.Add(name.name);
           });


            listName.ForEach(item =>
           {
               Console.WriteLine(item);
           });
            
        }
    }
}

public class Person
{
    public string name { set; get; }
    public int age { set; get; }


    public bool istrue(string cad)
    {
        return cad == name;
    }
}
