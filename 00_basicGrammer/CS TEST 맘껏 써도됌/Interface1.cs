using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_TEST_맘껏_써도됌
{
    interface Interface1
    {
        void a();
    }
    interface interface2
    {
        void b();
    }
    interface interface3 : Interface1
    {
        void c();
    }
}
