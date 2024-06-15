using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2
{
    internal class Program
    {
        class Test
        {
            //인스턴스 메서드 생성과 사용
            public int Power(int x)
            {
                return x * x;
            }
        }

        class Calculater
        {
            //두 개의 매개변수를 갖는 메서드
            public static int Plus(int a, int b)
            {
                return a + b;
            }
            public static int Minus(int a, int b)
            {
                return a - b;
            }
        }

        class MyMath
        {
            public static int Abs(int input)
            {
                if (input < 0) { return -input; }
                else { return input; }
            }
        }
        static void Main(string[] args)
        {
            Test test = new Test();
            Console.WriteLine(test.Power(10));  // 인스턴스 메서드
            Console.WriteLine(test.Power(20));
            //Console.WriteLine(test.Power(10));

            int resultA = Calculater.Plus(3, 4);
            Console.WriteLine(resultA);
            Console.WriteLine(Calculater.Plus(3, 4));
            int resultB = Calculater.Minus(5, 2);
            Console.WriteLine(resultB);

            //MyMath mymath = new MyMath();
            //Console.WriteLine(mymath.Abs(-52));
            Console.WriteLine(MyMath.Abs(-52));
        }
    }
}
