//This file calculates FizzBuzz efficiently and logs the distribution of fizzes and buzzes in base 10. 

namespace FizzBuzz.Data;

/// <summary>
///     Creates a dataset of a given size and returns the distribution of fizzies and buzzies up to the index
/// </summary>
public class FuzzyNormalDistribution
{
    private readonly List<int> _distribution = new();
    private readonly int _index;
    private readonly int _startDex;
    private double _fizzBuzzSlope;
    private double _fizzBuzzStandardDeviation;

    private double _successRate;

    public FuzzyNormalDistribution(List<int> data)
    {
        _distribution = data;
    }

    public FuzzyNormalDistribution(int startDex, int index)
    {
        _startDex = startDex;
        _index = index;
        //_fizzBuzzSlope = Slope(_distribution);
        //_fizzBuzzStandardDeviation = StandardDeviation(_distribution);
    }

    /// <summary>
    ///     This is one of the more efficient FizzBuzz algorithms on the internet
    /// </summary>
    /// this currently needs to be changed so that these are added directly to a list, and then sorted into a dataset, 0-9, for the amount of fizzbuzzes per digit
    /// Currently, it just creates a string of numbers and FizzBuzzies
    public void EfficientBuzz()
    {
        var x = 3;
        var y = 5;
        var x1 = _startDex % x;
        var y1 = _startDex % y;
        for (var i = _startDex; i <= _index; i++)
        {
            if (x1 == 0) //Fizz
                _distribution.Add(i);
            if (y1 == 0) //Buzz
                _distribution.Add(i);
            if (x1 != 0 && y1 != 0) //FizzBuzz
                _distribution.Add(i);
            x1 = x1 == x - 1 ? 0 : x1 + 1;
            y1 = y1 == y - 1 ? 0 : y1 + 1;
        }
    }

    public void SlowerBuzz()
    {
        for (var i = 1; i <= _index; i++)
        {
            if (i % 5 == 0 && i % 3 == 0)
                _distribution.Add(i);
            if (i % 3 == 0)
                _distribution.Add(i);
            else if (i % 5 == 0)
                _distribution.Add(i);
        }

    }

    public void Results()
    {
        Console.WriteLine(
            $"Standard Deviation of FizzBuzz: {StandardDeviation(_distribution)}\nSlope of Fizzbuzz: {Slope(_distribution)}");
    }

    public void Nuke()
    {
        _distribution.Clear();
    }

    /// <summary>
    /// Creates a dataset, then compares it to the slope calculated by the other functions in this class
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public void Solution()
    {
        List<int> values = new List<int>();
        Random rand = new Random();

        for (int i = 0; i < _index; i++)
            values.Add(rand.Next(_startDex, _index));

        //values.Sort();

        double _genericSlope = AverageSlope(values);
        _fizzBuzzSlope = AverageSlope(_distribution);
        double _percentageConfidence = (_genericSlope - _fizzBuzzSlope) / _fizzBuzzSlope;
        _percentageConfidence = Math.Abs(_percentageConfidence) * 100;
        double _fizzSubtraction = Math.Abs(_fizzBuzzSlope - _genericSlope);

        Console.WriteLine(
            $"Dataset's Slope: {_genericSlope}\n" +
            $"Dataset first and last: {values.First()}, {values.Last()} \n" +
            $"FizzBuzzSlope: {_fizzBuzzSlope}\n" +
            $"FizzBuzz's First and Last: {_distribution.First()}, {_distribution.Last()}\n" +
            $"FizzRelativeError: {_percentageConfidence}\n" +
            $"FizzSubtraction: {_fizzSubtraction}");


        if (_fizzSubtraction == 0)
            _successRate++;
    }
    /// <summary>
    /// as a percentage
    /// </summary>
    /// <returns></returns>
    public double ReturnSuccessRate()
    {

        return _successRate / _index * 100;
    }
    #region MathFunctions

    private double StandardDeviation(List<int> values)
    {
        var avg = values.Average();
        return Math.Sqrt(values.Average(v => Math.Pow(v - avg, 2)));
    }
    /// <summary>
    /// Used to calculate the slope of FizzBuzz at runtime
    /// </summary>
    /// <param name="values"></param>
    /// <returns></returns>
    private double Slope(List<int> values) //change this to use _startDex and _index for lower compile/runtime
    {
        var temp = values.Count() - 1;
        float numerator = values[values.Count() - 1] - values.First();
        float denominator = values.Count() - 2;


        return numerator / denominator;
    }

    private long AverageSlope(List<int> values)
    {
        long temp = (long)values.Sum();
        return temp / values.Count();
    }


    #endregion
}