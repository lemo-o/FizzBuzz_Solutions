using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Resources
{
    internal class Classic
    {
        private int _index;
        Classic(int index)
        {
            _index = index;
        }
        public void Solution()
        {
            for (int i = 0; i < _index; i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                    Console.WriteLine("FizzBUzz");
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");
                else if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                else
                    Console.WriteLine(i);
            }
        }
    }
}
