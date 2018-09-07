using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP0
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine();
            Console.WriteLine(a);

            var studentGrades = new int[] { 1, 2, 34, 56, 7 };
            foreach (var i in studentGrades)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();

            
        }
    }
}
