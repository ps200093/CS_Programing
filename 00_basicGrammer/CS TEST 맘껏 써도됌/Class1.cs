using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_TEST_맘껏_써도됌
{
    public class Class1
    {
        string phone;
        string name;

 
        public string Phone
        {
            get { return phone; }
            set { phone = "ㅋㅋ" + value; }
        }
        public string Name
        {
            get { return name; }
            set { name = "zz" + value; }
        }
        
        public void test()
        {
            Console.WriteLine("test1");
        }

        public void test2()
        {
            Console.WriteLine("oneTest");
        }

        public virtual void test3()
        {
            Console.WriteLine("VirtualTest");
        }
    }
}
