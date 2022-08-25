//This file calculates FizzBuzz efficiently and logs the distribution of fizzes and buzzes in base 10. 

namespace FizzBuzz.Data;
///<summary>
///Creates a dataset of a given size and returns the distribution of fizzies and buzzies up to the index
///</summary>
public class FuzzyNormalDistribution
{
    private int _index;
    private int _startDex;
    private List <int> _distribution = new List<int>();
    public FuzzyNormalDistribution(int startDex, int index)
    {
        _startDex = startDex;
        _index = index;
    }
    ///<summary>
    ///This is one of the more efficient FizzBuzz algorithms on the internet
    ///</summary>
    ///
    ///this currently needs to be changed so that these are added directly to a list, and then sorted into a dataset, 0-9, for the amount of fizzbuzzes per digit
    ///Currently, it just creates a string of numbers and FizzBuzzies
    public void EfficientBuzz()
    {
        int x = 3;
        int y = 5;
        int x1 = _startDex % x;
        int y1 = _startDex % y;
        for (int i = _startDex; i <= _index; i++)
        {
            if (x1 == 0) //Fizz
                _distribution.Add(i);
            if (y1 == 0) //Buzz
                _distribution.Add(i);
            if (x1 != 0 && y1 != 0) 
                _distribution.Add(i);
            x1 = (x1 == x - 1 ? 0 : x1 + 1);
            y1 = (y1 == y - 1 ? 0 : y1 + 1);
        }
    }

    public void Results() 
    {
        EfficientBuzz();
        Console.WriteLine($"Standard Deviation of FizzBuzz: {StandardDeviation(_distribution)}\nSlope of Fizzbuzz: {Slope(_distribution)}");
    }

    #region MathFunctions
    private double StandardDeviation(List<int> values)
    {
        double avg = values.Average();
        return Math.Sqrt(values.Average(v => Math.Pow(v - avg, 2)));
    }

    private double Slope(List<int> values)
    {
        float numerator = values[values.Last()] - values[1];
        float denominator = values.Last();


        return numerator/denominator;
    }

    #endregion




}