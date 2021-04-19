using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic
{
    class Program
    {
        string var = "테스트";

        static void Main(string[] args)
        {
            var name = "최" + "민" + "정";
            Console.Write("개형이 안되는 녀석");
            Console.WriteLine("개형이 안되는 녀석");

            Console.Write("개행이 안되는 ");
            Console.WriteLine("");
            Console.Write("개행되는 ");

            Console.WriteLine(52);
            Console.WriteLine(5 * 3 * 2);
            Console.WriteLine(10/5);
            Console.WriteLine(5%3);

            Console.WriteLine(9);
            Console.WriteLine(0.0);

            Console.WriteLine(1.0 + 2.0);
            Console.WriteLine(1.0 - 2.0);
            Console.WriteLine(1.0 * 2.0);

            Console.WriteLine(1.0 / 2.0);
            Console.WriteLine(1 / 2);
            Console.WriteLine(1.0 / 2);
            Console.WriteLine(1.0 - 2.0);

            Console.WriteLine("미림림|u여쟈졍뵤효ㅑ걓교ㅓ" );
            Console.WriteLine('가');

            Console.WriteLine("안녕하세요!"[0]);
            Console.WriteLine("안녕하세요!"[1]);
            Console.WriteLine("안녕하세요!"[2]);
            Console.WriteLine("안녕하세요!"[-0]);


            Console.WriteLine(62 < 273);

            Console.WriteLine(3 < DateTime.Now.Hour && DateTime.Now.Hour < 8);

            int a = 2147483647;
            int b = 1;
            Console.WriteLine(a + b);

            double c = 52.263;
            char d = '아';

            Console.WriteLine("int:" + sizeof(int));
            Console.WriteLine("long:" + sizeof(long));
            Console.WriteLine("float:" + sizeof(float));
            Console.WriteLine("double:" + sizeof(double));
            Console.WriteLine("char:" + sizeof(char));
            Console.WriteLine("bool:" + sizeof(bool));

            bool TrueOrFalse = false;

            int output = 0;
            output += 52;
            output += 42;

            Console.WriteLine(output);

            output *= 2;
            Console.WriteLine(output);

            string output2 = "Hello";
            output2 += "World";
            output2 += "!";
            Console.WriteLine(output2);
        }
    }
}
