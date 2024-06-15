﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_1
{
    // ① 하나의 파일에 여러 개의 클래스 생성
    class Cat
    {
        public string Name;
        public string Color;
        public Cat(string name, string color)   // 생성자 정의(선언)
        {
            Name = name;
            Color = color;
        }
        public void Meow()  // 메서드
        {
            Console.WriteLine($"{Name} : 야옹~");
        }
    }
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
