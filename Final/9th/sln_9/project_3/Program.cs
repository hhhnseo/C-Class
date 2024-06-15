using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat kitty = new Cat("키티", "하얀색");
            kitty.Meow();
            Console.WriteLine("{0} : {1}", kitty.Name, kitty.Color);
            Console.WriteLine();

            Cat Nero = new Cat("네로", "검은색");
            Nero.Meow();
            Console.WriteLine("{0} : {1}", Nero.Name, Nero.Color);
        }
    }
}
