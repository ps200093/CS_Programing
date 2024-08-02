#define KOREA
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

//인덱서는 이해안간다 시발
namespace CS_TEST_맘껏_써도됌
{
    struct XY
    {
        public int x, y;
        public XY(int x, int y) { this.x = x; this.y = y; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[5] { 1, 3, 2, 5, 4 };
            int[] arr2 = { 1, 3, 2, 5, 4 };

            System.Array.Sort(arr1);
            int[] arr3 = (int[])arr1.Clone();
            System.Array.Reverse(arr1);
            for (int i = 0; i < 5; i++)
                System.Console.WriteLine(arr3[i]);

            Console.WriteLine(arr1.GetLowerBound(0));
            Console.WriteLine(arr1.GetUpperBound(0));
            Console.WriteLine(arr1.GetValue(0));

            int[][] arr5 = new int[4][];
            arr5[0] = new int[2] { 1, 2 };
            arr5[1] = new int[] { 1, 2, 3 };


            Console.WriteLine("\n\n\n");
            ArrayList al = new ArrayList();
            al.Add(0100);
            al.AddRange(arr1);
            al.Reverse(1, 5);

            foreach (object ob in al)
                Console.WriteLine(ob);

            int a=1;
            if (a is 2) Console.WriteLine("is출력");

            Console.WriteLine(typeof(int));
            Console.WriteLine("{0:N100}", 1234.56);


            Class1 c1 = new Class1();

            //c1.Name = Console.ReadLine();
            //c1.Phone = Console.ReadLine();

            //Console.WriteLine(c1.Name);
            //Console.WriteLine(c1.Phone);

            Class2 c2 = new Class2();

            //c2.Name = Console.ReadLine();
            //Console.WriteLine(c2.Name);
            //c2.Address = Console.ReadLine();
            //Console.WriteLine(c2.Address);

            c1.test();
            c2.test();

            c1.test2();
            //c2.test2();
            c2.testtest();

            Console.WriteLine("\n\n\n");

            Class3 c3 = new Class3("1");
            Class4 c4 = new Class4();


            c1.test3();
            c2.test3();

            XY xyp = new XY(1, 2);
            XY[] xyarr = new XY[2];
            

            Console.WriteLine("\n\n\n");
            Console.WriteLine($"{xyp.x}    {xyp.y}");
            Console.WriteLine($"{xyarr[0].x}    {xyarr[1].y}");

            Class5 c5 = new Class5();
          
            c5.a();
            c5.b();
            c5.c();

            Interface1 i1 = new Class5();

            i1.a();
            //i1.b();

            Console.WriteLine("\n\n\n");
            Class6 c6 = new Class6();

            delegatetest1 d1 = new delegatetest1(c6.method);
            delegatetest2 d2 = new delegatetest2(c6.method2);

            d1();
            d2(100);

            multiDelegate d3 = new multiDelegate(Class6.method3);
            multiDelegate d4 = new multiDelegate(c6.method4);
            Console.WriteLine("추가"); 
            d3 += d4;
            d3("d4 추가함");
            Console.WriteLine("삭제");
            d3 -= d4;
            d3("d4삭제함");
            d3("마지막 결과");

            Console.WriteLine("\n\n\n");

            Class7 c7 = new Class7();
            EventHandler eh = new EventHandler();

            c7.eventMethod += new eventDelegate(eh.handler);
            c7.work();


            Class8 c8 = new Class8();
            Class8_1 c8_1 = new Class8_1();

            //c8.deleEvent += c8_1.something();

            Class9.KoreaMethod();
            Class9.JapanMethod();
            Class9.ObsoleteMethod();


            Console.WriteLine("\n\n\n");
            Type type = typeof(Program);
            object[] arr = type.GetCustomAttributes(typeof(UserAttribute), true);
            if (arr.Length == 0)
                Console.WriteLine("No");
            else
            {
                UserAttribute ua = (UserAttribute)arr[0];
                Console.WriteLine(ua.Message);
            }

            test2 t2 = new test2();
            t2.testm();
        }
    }
}
