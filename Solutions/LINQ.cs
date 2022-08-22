namespace FizzBuzz.Resources;

public class LINQSolutions
{
    private int _index;
    /// <summary>
    /// Constructor for various LINQ solutions
    /// </summary>
    /// <param name="index">How far do you want to LinqBuzz?</param>
    public LINQSolutions(int index)
    {
        _index = index;
    }

    /// <summary>
    /// Single line implementation of LINQ. It's alright. 
    /// </summary>
    public void SingleLineSolution()
    {
        Enumerable.Range(1, _index).Select(
                n =>
                    (n % 15 == 0)
                        ? "FizzBuzz"
                        : (
                            (n % 3 == 0)
                                ? "Fizz"
                                : (
                                    (n % 5 == 0) ? "Buzz" : n.ToString())
                        )
            )
            .ToList()
            .ForEach(Console.WriteLine);
    }
}