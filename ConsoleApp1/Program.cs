using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var class1 = new Class1();
            Console.WriteLine($"class1 is BaseClass ({class1 is BaseClass})");
            Console.WriteLine($"class1 is IInterface ({class1 is IInterface})");

            var class2 = new Class2();
            Console.WriteLine($"class2 is BaseClass ({class2 is BaseClass})");
            Console.WriteLine($"class2 is IInterface ({class2 is IInterface})");

            (class2 as IInterface).HelloWord();


            Console.ReadKey();
        }
    }

    public abstract class BaseClass
    {

    }

    public class Class1: BaseClass
    {

    }

    public class Class2 : BaseClass, IInterface
    {
        public void HelloWord()
        {
            Console.WriteLine("HelloWord!");
        }
    }

    public interface IInterface
    {
        void HelloWord();
    }

}
