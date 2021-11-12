using System;
using Xunit;
using HeroGameAdvancedLib;

namespace HeroGameAdvancedTests
{
    public class DiceTests
    {
        Dice Dice = new Dice(0, 6);

        [Theory]
        [InlineData(0, 6)]
        [InlineData(1, 0)]
        [InlineData(-7, 3)]
        [InlineData(5, 10)]
        public void TestRoll(int min, int max)
        {
            for (int i = 0; i < 5; i++)
            {
                int testroll = this.Dice.Roll();
                Assert.Equal(testroll < this.Dice.Min, false);
                Assert.Equal(testroll > this.Dice.Max, false);
            }  

            Assert.Equal(min <= max, true);
            Assert.Equal(max >= min, true);
            Assert.Equal(min >= this.Dice.Min, true);
            Assert.Equal(max <= this.Dice.Max, true);

            
        }
    }
}

// Roll returns an integer between Min and Max inclusive
