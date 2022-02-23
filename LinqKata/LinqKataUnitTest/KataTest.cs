using System.Collections.Generic;
using LinqKata;
using NFluent;
using Xunit;

namespace LinqKataUnitTest
{
    public class KataTest
    {
        [Fact]
        public void Should_Pass_GetMaxAverage()
        {
            var input1 = new[] { 10, 20 };
            var input2 = new[] { 9, 4, 9 };
            var input3 = new[] { 12, 3, 6, 4 };

            var result = Kata.GetMaxAverage(input1, input2, input3);

            Check.That(result).IsEqualTo(15);
        }

        [Fact]
        public void Should_Pass_Flat()
        {
            var input = new List<IEnumerable<int>>
            {
                new []{ 1, 2, 3 },
                new []{ 4, 5, 6 },
                new []{ 7, 8, 9 },
            };

            var result = Kata.Flat(input);

            Check.That(result).ContainsExactly(1, 2, 3, 4, 5, 6, 7, 8, 9);
        }

        [Fact]
        public void Should_Pass_OrderByMarkAndPrice()
        {
            var cars = new []
            {
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
            };

            var result = Kata.OrderByMarkAndPrice(cars);

            Check.That(result.Extracting(r => r.Mark)).ContainsExactly("Citroen", "Peugeot", "Peugeot");
            Check.That(result.Extracting(r => r.Price)).ContainsExactly(1_000, 900, 1_500);
        }

        [Fact]
        public void Should_Pass_GetFrom4To6()
        {
            var input = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var result = Kata.GetFrom4To6(input);

            Check.That(result).ContainsExactly(4, 5, 6);
        }

        [Fact]
        public void Should_Pass_Inverse()
        {
            var input = new[] { 1, 2, 3 };

            var result = Kata.Inverse(input);

            Check.That(result).ContainsExactly(3, 2, 1);
        }

        [Fact]
        public void Should_Pass_GetMaxPriceByMark_()
        {
            var equities = new List<Equity>
            {
                new Equity
                {
                    Code = "GLE FP"
                },
                new Equity
                {
                    Code = "BNP FP"
                }
            };
            
            var bonds = new List<Bond>
            {
                new Bond
                {
                    Code = "GLE FP"
                }
            };

            var result = Kata.GetAnalyses(equities, bonds);

            Check.That(result.Extracting(r => r.EquityCode)).Contains("GLE FP");
            Check.That(result.Extracting(r => r.BondCode)).Contains("GLE FP");
        }

        [Fact]
        public void Should_Pass_GetMaxPriceByMark()
        {
            var cars = new List<Car>
            {
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
            };

            var result = Kata.GetMaxPriceByMark(cars);

            Check.That(result.Extracting(r => r.Mark)).Contains("Peugeot", "Citroen");
            Check.That(result.Extracting(r => r.Price)).Contains(1_500, 900);
        }

        [Fact]
        public void Should_Pass_GetDictionary()
        {
            var input = new[] {"Red", "Green", "Red", "Red", "Orange", "Blue", "Green", "Orange", "Pink"};

            var result = Kata.GetDictionary(input);

            Check.That(result).Contains(("Red", 3), ("Green", 2), ("Orange", 2), ("Blue", 1), ("Pink", 1));
        }
    }
}