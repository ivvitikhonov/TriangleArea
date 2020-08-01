using System;
using Xunit;

namespace TriangleArea.Test
{
    public class UnitTest
    {
        [Fact]
        public void PifagorTest()
        {
            Assert.Equal(6, TriangleArea.Calculation.Area(5, 3, 4));
        }

        [Fact]
        public void RandomTest()
        {
            Assert.Equal(10.5, TriangleArea.Calculation.Area(7.6, 7, 3));
        }

        [Fact]
        public void WrongRandomTest()
        {
            Assert.NotEqual(11, TriangleArea.Calculation.Area(7.6, 7, 3));
        }

        [Fact]
        public void RandomTestWithRound()
        {
            Assert.Equal(15.18, Math.Round(TriangleArea.Calculation.Area(9.2, 3.56, 8.53),2));
        }
    }
}
