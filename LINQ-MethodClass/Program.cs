using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_MethodClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(new exam().yyy());

            //Console.ReadKey();


            loadvalues loadvalues = new loadvalues();
            loadvalues.load();

            Console.ReadKey();
        }

       
    }

    public class exam
    {

        public bool yyy()
        {
            string order = "asc";
            bool orderBy = order.Equals("asc");

            return orderBy;
        }
        public string xxxx()
        {
            string error01 = null;
            var error02 = "mundo";

            return error01 ?? error02;
        }
    }
}
