//This file calculates FizzBuzz efficiently and logs the distribution of fizzes and buzzes in base 10. 

namespace FizzBuzz.Data;
///<summary>
///Creates a dataset of a given size and returns the distribution of fizzies and buzzies up to the index
///</summary>
public class FuzzyNormalDistribution
{
    private int _index;
    private int _startDex;
    private List <int> _distribution;
    FuzzyNormalDistribution(int startDex, int index)
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

        List<int> _data = new List<int>();


        int x = 3;
        int y = 5;
        int x1 = _startDex % x;
        int y1 = _startDex % y;
        for (int i = _startDex; i <= _index; i++)
        {
            if (x1 == 0) //Fizz
                _data.Add(i);
            if (y1 == 0) //Buzz
                _data.Add(i);
            if (x1 != 0 && y1 != 0) //result += i.ToString();
                _data.Add(i);
            //result += ", ";
            x1 = (x1 == x - 1 ? 0 : x1 + 1);
            y1 = (y1 == y - 1 ? 0 : y1 + 1);
        }
    }

    private double StandardDeviation(IEnumerable<int> values)
    {
        double avg = values.Average();
        return Math.Sqrt(values.Average(v => Math.Pow(v - avg, 2)));
    }

    private double Slope(IEnumerable<int> values)
    {
        for (int i = 0; i < values.Length(); i++)
        {
            
        }
    }
}