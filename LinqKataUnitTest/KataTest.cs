using System.Collections.Generic;
using LinqKata;
using NFluent;
using Xunit;

namespace LinqKataUnitTest;

public class KataTest
{
    [Fact]
    public void Should_Pass_GetMaxAverage()
    {
        int[] input1 = [10, 20];
        int[] input2 = [9, 4, 9];
        int[] input3 = [12, 3, 6, 4];

        var result = Kata.GetMaxAverage(input1, input2, input3);

        Check.That(result).IsEqualTo(15);
    }

    [Fact]
    public void Should_Pass_Flat()
    {
        var input = new int[][]
        {
            [1, 2, 3],
            [4, 5, 6],
            [7, 8, 9]
        };

        var result = Kata.Flat(input);

        Check.That(result).ContainsExactly(1, 2, 3, 4, 5, 6, 7, 8, 9);
    }

    [Fact]
    public void Should_Pass_OrderByMarkAndPrice()
    {
        Car[] cars =
        [
            new Car
            {
                Mark = "Peugeot",
                Price = 1_500
            },
            new Car
            {
                Mark = "Citroen",
                Price = 1_000
            },
            new Car
            {
                Mark = "Peugeot",
                Price = 900
            }
        ];

        var result = Kata.OrderByMarkAndPrice(cars);

        Check.That(result.Extracting(r => r.Mark)).ContainsExactly("Citroen", "Peugeot", "Peugeot");
        Check.That(result.Extracting(r => r.Price)).ContainsExactly(1_000, 900, 1_500);
    }

    [Fact]
    public void Should_Pass_GetFrom4To6()
    {
        string[] input = ["A", "B", "C", "D", "E", "F", "G", "H", "I", "J"];

        var result = Kata.GetFrom4To6(input);

        Check.That(result).ContainsExactly("E", "F", "G");
    }

    [Fact]
    public void Should_Pass_Inverse()
    {
        int[] input = [1, 2, 3];

        var result = Kata.Inverse(input);

        Check.That(result).ContainsExactly(3, 2, 1);
    }

    [Fact]
    public void Should_Pass_GetMergeAnalyses()
    {
        Equity[] equities =
        [
            new Equity
            {
                Code = "GLE FP"
            },
            new Equity
            {
                Code = "BNP FP"
            }
        ];

        Bond[] bonds =
        [
            new Bond
            {
                Code = "GLE FP"
            }
        ];

        var result = Kata.GetAnalyses(equities, bonds);

        Check.That(result.Extracting(r => r.EquityCode)).Contains("GLE FP");
        Check.That(result.Extracting(r => r.BondCode)).Contains("GLE FP");
    }

    [Fact]
    public void Should_Pass_GetMaxPriceByMark()
    {
        Car[] cars =
        [
            new Car
            {
                Mark = "Peugeot",
                Price = 900
            },
            new Car
            {
                Mark = "Citroen",
                Price = 1_000
            },
            new Car
            {
                Mark = "Peugeot",
                Price = 1_500
            }
        ];

        var result = Kata.GetMaxPriceByMark(cars);

        Check.That(result.Extracting(r => r.Mark)).Contains("Peugeot", "Citroen");
        Check.That(result.Extracting(r => r.Price)).Contains(1_500, 1_000);
    }

    [Fact]
    public void Should_Pass_GetDictionary()
    {
        string[] input = ["Red", "Green", "Red", "Red", "Orange", "Blue", "Green", "Orange", "Pink"];

        var result = Kata.GetDictionary(input);

        Check.That(result).Contains(
            KeyValuePair.Create("Red", 3),
            KeyValuePair.Create("Green", 2),
            KeyValuePair.Create("Orange", 2),
            KeyValuePair.Create("Blue", 1),
            KeyValuePair.Create("Pink", 1));
    }
}