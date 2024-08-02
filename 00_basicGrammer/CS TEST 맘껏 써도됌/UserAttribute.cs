using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_TEST_맘껏_써도됌
{
    class UserAttribute : Attribute
    {
        private string message;
        public UserAttribute(string message)
        {
            this.message = message;
        }
        public string Message
        {
            get
            {
                return message;
            }
        }
    }
}
