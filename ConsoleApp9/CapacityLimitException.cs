using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    class CapacityLimitException:Exception
    {
        public CapacityLimitException(string message):base(message)
        {
            Console.WriteLine(message);
        }
    }
}
