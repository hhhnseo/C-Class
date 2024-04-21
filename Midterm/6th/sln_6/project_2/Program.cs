using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //배열 : 같은 데이터 타입을 가진 데이터 집합(고정)

            int[] alphas = new int[3] {10, 20, 30};
            foreach (var item in alphas)
            {
                Console.WriteLine(item);
            }
            alphas[3] = 40;

            //리스트 : 같은 데이터타입을 가진 데이터들의 집합(가변)
            List<int> List = new List<int>();   //생성자
            List.Add(10);
            List.Add(20);
            List.Add(30);
            foreach (var item in List)
            {
                Console.WriteLine(item);
            }

            List<int> lists = new List<int>() { 15, 25, 35 };
            lists.Add(40);
            lists.Add(50);
            lists.Add(60);

            foreach (var item in lists)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            lists.Remove(50);
            lists.RemoveAt(4);
            lists.Insert(0, 5);
            foreach (var item in lists)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();*/

            List<int> list = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                list.Add(i);
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            list.RemoveAt(2);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            list.Insert(2, 2);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //ArrayList : 배열과 달리 컬렉션을 생성할 때 용량을 미리 지정할
            //필요없이 필요에 따라 자동으로 그 용량이 늘어나거나 줄어든다.
            
            ArrayList lists = new ArrayList();
            lists.Add(30);
            lists.Add(40);
            lists.Add(50);

            foreach (var item in lists)
            {
                Console.WriteLine(item);
            }

            lists.Remove(30);
            lists.RemoveAt(2);
            lists.Insert(2, 25);

            foreach (var item in lists)
            {
                Console.WriteLine(item);
            }

        }
    }
}
