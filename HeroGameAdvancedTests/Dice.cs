using System;
using Xunit;
using HeroGameAdvancedLib;

namespace HeroGameAdvancedTests
{
    public class DiceTests
    {
        

        [Theory]
        [InlineData(0, 6)]
        [InlineData(1, 0)]
        [InlineData(-7, 3)]
        [InlineData(5, 10)]
        public void TestRoll(int min, int max)
        {
            Dice Dice = new Dice(min, max);
            for (int i = 0; i < 5; i++)
            {
                int testroll = Dice.Roll();
                Assert.Equal(testroll < Dice.Min, false);
                Assert.Equal(testroll > Dice.Max, false);
            }              
        }
    }
}

// Roll returns an integer between Min and Max inclusive
