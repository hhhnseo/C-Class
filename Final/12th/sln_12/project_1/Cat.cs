using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_1
{
    internal class Cat
    {
        public int Age { get; set; }    //속성

        public Cat() { this.Age = 0; }  //생성자

        //메서드
        public void Eat() { Console.WriteLine("뇸뇸"); }
        public void Sleep() { Console.WriteLine("콜콜"); }
        public void bark() { Console.WriteLine("야옹"); }
    }
}
