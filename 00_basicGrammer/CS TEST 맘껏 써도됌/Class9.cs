using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CS_TEST_맘껏_써도됌
{
    class Class9
    {
        [Conditional("KOREA")]
        public static void KoreaMethod()
        {
            Console.WriteLine("KOREA");
        }
        [Conditional("JAPAN")]
        public static void JapanMethod()
        {
            Console.WriteLine("JAPAN");
        }
        [Obsolete("뭔데")]
        public static void ObsoleteMethod()
        {
            Console.WriteLine("뭔데");
        }
    }
}
