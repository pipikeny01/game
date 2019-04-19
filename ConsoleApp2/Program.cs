using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>
            {
                345,
                51,
                55
            };

            foreach(var a in Add(5))
            {
                Console.WriteLine(a);
                if(a < 100)
                    break;
            }

            Console.WriteLine("------------------");

            foreach (var a in AddTwo(5))
            {
                Console.WriteLine(a);
            }

            Console.ReadKey();
        }

        public static List<int> Add(int m){
            List<int> r = new List<int>();
            r.Add( m + 5);


            //.......

            r.Add(m + 20);

            return r;
        }

        public static IEnumerable<int> AddTwo(int m)
        {
            yield return m + 5;


            //.......

            yield break;

            yield return m + 20;




        }
    }
}
