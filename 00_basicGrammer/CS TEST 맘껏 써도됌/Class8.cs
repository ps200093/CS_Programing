using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_TEST_맘껏_써도됌
{
    public delegate void dele();
    class Class8
    {
        public event dele deleEvent;

        public void push()
        {
            if (deleEvent != null) deleEvent();
        }
    }

    class Class8_1{
        public void something()
        {
             Console.WriteLine("test");
        }
    }
}
