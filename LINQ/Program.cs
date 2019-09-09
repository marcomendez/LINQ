using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Person { name = "marc", age = 10 });
            people.Add(new Person { name = "carlo", age = 20 });
            people.Add(new Person { name = "marc", age = 30 });


            var result = people.Where(p => p.istrue("marc") || p.istrue("carlo"));

            foreach( Person p in result)
            {
                Console.WriteLine(p.name + " : " + p.age, Environment.NewLine);
            }



            int[] numbers = { 2, 3, 4, 5 };
            var squaredNumbers = numbers.Select(x => x * x);
            Console.WriteLine(string.Join(" ", squaredNumbers));



            string[] words = { "believe", "relief", "asdadasd", "receipt", "field" };

            bool iAfterE = words.All(w => w.Contains("ei"));

            Console.WriteLine("There is a word that contains in the list that contains 'ei': {0}", iAfterE);


            Console.ReadKey();
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
}

