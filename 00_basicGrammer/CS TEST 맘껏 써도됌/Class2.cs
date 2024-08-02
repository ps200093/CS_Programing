using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_TEST_맘껏_써도됌
{
    class Class2 : Class1
    {
        string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        new public void test()
        {
            Console.WriteLine("test2");
        }
        public void testtest()
        {
            base.test();
        }
        //public void test2()
        //{
        //    Console.WriteLine("TwoTest");
        //}

        public override void test3()
        {
            Console.WriteLine("subVirtualTest");
        }
    }
}
