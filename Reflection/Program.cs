using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
        }

        private static void Task2()
        {
            MyClass clas = new MyClass(9, "C#", "Oleg Skidan");

            Type type = typeof(MyClass);

            var prop = type.GetProperties();

            foreach (var pr in prop)
            {
                Console.WriteLine(pr.Name + " - " + pr.GetValue(clas));
            }

            Console.ReadLine();
        }

        private static void Task1()
        {
            Type type = typeof(Console);
            int count = 1;

            var methods = type.GetMethods();
            int length = type.GetMethods().Length;
            Console.WriteLine("Methods of Console class:");

            foreach (var method in methods)
            {
                Console.SetCursorPosition(10, count++);
                Console.WriteLine("Mетод: {0}", method.Name);
            }

            Console.ReadLine();
            Console.Clear();
        }
    }
}
