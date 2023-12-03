using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OUT
{
    class OUT
    {
        static void Foo(ref int value)
        {
            value++;
            Console.WriteLine(value);
        }

        static void Bar(out int value)
        {
            value = 5;
            Console.WriteLine(value);
        }
        static void Main(string[] args)
        {
            int a = 10;

            Foo(ref a);
            Bar(out int b);


            string str = Console.ReadLine();
            int.TryParse(str, out int result);

            Console.WriteLine(result);

        }
    }
}
