using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicTopics.classes;

namespace BasicTopics
{
    class Program
    {
        static void Main(string[] args)
        {
            //var result = MyHelper.GetSurname("Aijaz");

            //   var result = "Saif".GetSurname("Maher");

            // Console.WriteLine(result);

            //var result = "Saif".IsActive();
            //Console.WriteLine(result);

            var obj = new Simple("Aijaz Ali", 30);

            var obj2 = new Simple("Saif", 12);

            Console.WriteLine(obj2.Name);

            Console.WriteLine(obj2.Age);

            Console.ReadKey();
        }
    }
}
