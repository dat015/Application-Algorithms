// See https://aka.ms/new-console-template for more information
using Baitap02;

bai15.run15();
Rational.run16();
RationalWithBigInteger.run17();
Console.WriteLine("Bài 18");
Accumulator acc = new Accumulator();

double[] values = { 10.0, 20.0, 30.0, 40.0, 50.0 };

foreach (double value in values)
{
    acc.AddDataValue(value);
}

Console.WriteLine("Mean: " + acc.Mean());                 
Console.WriteLine("Variance: " + acc.Var());               
Console.WriteLine("Standard Deviation: " + acc.StdDev());
Console.WriteLine("Bài 19");

Date date = new Date("5/22/1939");
Console.WriteLine("Parsed Date: " + date);

Transaction transaction = new Transaction("Turing 5/22/1939 11.99");
Console.WriteLine("Parsed Transaction: " + transaction);