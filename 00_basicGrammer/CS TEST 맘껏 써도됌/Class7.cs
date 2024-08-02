using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_TEST_맘껏_써도됌
{
    public delegate void eventDelegate();
    class Class7
    {
        public event eventDelegate eventMethod;

        public void work()
        {
            if (eventMethod != null) eventMethod();
        }
    }

    class EventHandler
    {
        public void handler()
        {
            Console.WriteLine("처리");
        }    
    }
}
