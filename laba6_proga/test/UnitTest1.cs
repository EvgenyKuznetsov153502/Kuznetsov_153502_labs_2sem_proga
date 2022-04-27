using System;
using laba6_proga;
using Xunit;

namespace test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Computer comp = new Computer("Sumsung", 6500, "Redragon Lakshmi", "Benq");
            int sum = comp.Sum(1, 0);
            Assert.Equal(1, sum);
        }

        [Fact]
        public void Test2()
        {
            Computer comp = new Computer("Sumsung", 6500, "Redragon Lakshmi", "Benq");
            int sum = comp.Sum(5000, 90000);
            Assert.Equal(95000, sum);
        }

        [Fact]
        public void Test3()
        {
            Computer comp = new Computer("Sumsung", 6500, "Redragon Lakshmi", "Benq");
            int sum = comp.Sum(999999, 6666666);
            Assert.Equal(7666665, sum);
        }

        [Fact]
        public void Test4()
        {
            Computer comp = new Computer("Sumsung", 6500, "Redragon Lakshmi", "Benq");
            int sum = comp.Minus(1, 0);
            Assert.Equal(1, sum);
        }

        [Fact]
        public void Test5()
        {
            Computer comp = new Computer("Sumsung", 6500, "Redragon Lakshmi", "Benq");
            int sum = comp.Minus(100000, 50000);
            Assert.Equal(50000, sum);
        }

        [Fact]
        public void Test6()
        {
            Computer comp = new Computer("Sumsung", 6500, "Redragon Lakshmi", "Benq");
            int sum = comp.Minus(1500000, 500000);
            Assert.Equal(1000000, sum);
        }

        [Fact]
        public void Test7()
        {
            Computer comp = new Computer("Sumsung", 6500, "Redragon Lakshmi", "Benq");
            int sum = comp.GetPrice(100);
            Assert.Equal(650000, sum);
        }

        [Fact]
        public void Test8()
        {
            Computer comp = new Computer("Sumsung", 6500, "Redragon Lakshmi", "Benq");
            int sum = comp.GetPrice(1);
            Assert.Equal(6500, sum);
        }

        [Fact]
        public void Test9()
        {
            Computer comp = new Computer("Sumsung", 6500, "Redragon Lakshmi", "Benq");
            int sum = comp.GetPrice(10000);
            Assert.Equal(65000000, sum);
        }

    }
}
