using System;

public class StandardBuzz
{
    /// <summary>
    /// This is the standard form for FizzBuzz, in static, readonly, string form 
    /// </summary>
    public static readonly string[] StringFizzBuzz =
    {
        "1",
        "2",
        "Fizz",
        "4",
        "Buzz",
        "Fizz",
        "7",
        "8",
        "Fizz",
        "Buzz",
        "11",
        "Fizz",
        "13",
        "14",
        "FizzBuzz"
    };
    /// <summary>
    /// Fizzbuzz, in public static int form. Returning a -1 == Fizz, -2 = Buzz, -3 == FizzBuzz
    /// </summary>
    public static readonly int[] IntFizzBuzz =
    {
        1,
        2,
        -1,
        4,
        -2,
        -1,
        7,
        8,
        -1,
        -2,
        11,
        -1,
        13,
        14,
        -3
    };
}
