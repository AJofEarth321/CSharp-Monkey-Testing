using System;
using Xunit;
using System.Linq;
using System.Collections.Generic;
using MonkeyTesting;

namespace MonkeyTesting.Tests
{
    public class MonkeyTest
    {
        MonkeyTrouble monkeyTrouble;

        public MonkeyTest()
        {
            monkeyTrouble = new MonkeyTrouble();
        }

        [Fact]
        public void MonkeyTroubleTrue()
        {
            bool aSmile = new bool();
            bool bSmile = new bool();
            var expected = aSmile == bSmile;
            var actual = monkeyTrouble.Trouble(aSmile, bSmile);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MonkeyTroubleFalse()
        {
            bool aSmile = new bool();
            bool bSmile = new bool();
            var expected = aSmile != bSmile;
            var actual = monkeyTrouble.Trouble(aSmile, bSmile);
            Assert.NotEqual(expected, actual);
        }

    }
}
