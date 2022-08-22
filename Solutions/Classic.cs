namespace FizzBuzz.Resources
{
    public class Classic
    {
        private int _index;
        /// <summary>
        /// The "Classic" implementation of FizzBuzz, using If/else statements and a little math
        /// </summary>
        /// <param name="index">How far do you want to FizzBuzz?</param>
        public Classic(int index) 
            => _index = index;

        public void Solution()
        {
            for (int i = 1; i <= _index; i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }
        }
    }
}
