﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_
{
    class Parent
    {
        public Parent() { Console.WriteLine("부모 생성자"); }
    }

    /*class Child : Parent
    {
        public Child() { Console.WriteLine("자식 생성자"); }
    }*/

    class Child : Parent
    {
        public Child() : base()
        { Console.WriteLine("자식 생성자"); }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //상속했을 때 기본적인 생성자 호출 문자
            Child child = new Child();
        }
    }
}
