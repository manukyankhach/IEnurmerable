using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfIEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company("MexFac");
            foreach (var item in company)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
