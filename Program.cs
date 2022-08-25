using FizzBuzz.Data;
using FizzBuzz.Resources;

var N = 50000;



//var powerBuzz = new FuzzyNormalDistribution(1, N);
//powerBuzz.EfficientBuzz();
//powerBuzz.Results();

//Console.WriteLine("\nNoDupes:");
//var SecondBuzz = new FuzzyNormalDistribution(1, N);
//SecondBuzz.SlowerBuzz();
//SecondBuzz.Results();

var newBuzz = new FuzzyNormalDistribution(1,N);
for (int i = 0; i < 1000; i++)
{
    newBuzz.SlowerBuzz();
    newBuzz.Solution();
    newBuzz.Nuke();
    Console.WriteLine("\n");
}
Console.Write($"SuccessRate: {newBuzz.ReturnSuccessRate()}");

