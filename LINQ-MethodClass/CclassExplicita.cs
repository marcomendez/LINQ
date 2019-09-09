using System.Collections.Generic;
using System.Linq;

namespace LINQ_MethodClass
{
    class CclassExplicita
    {
        private static string[] postres = { "Torta de manzana", "empanadas de queso", "pastel banana", "pai limon", "pay manzana" };

        private static IEnumerable<string> encontrados = from p in postres
                                                         where p.Contains("manzana")
                                                         orderby p
                                                         select p;
        public bool x()
        {
            var error01 = true;
            var error02 = true;

            return error01 ? error02 : error01;
        }
    }
}
