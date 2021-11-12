using System;
using Xunit;
using HeroGameAdvancedLib;

namespace HeroGameAdvancedTests
{
    public class HeroTests
    {        
        Hero testHero = new Hero(1, "Test", new Dice(0,6), 2);

        [Theory]
        [InlineData(4, 7)]
        [InlineData(2, 6)]
        [InlineData(1, 1)]
        [InlineData(3, 3)]


        public void Test(int expected, int input)
        {
            this.testHero.Attack(input);
            Assert.Equal(expected, this.testHero.Uses);
        }
    }
}

// Hero is able to attack a given number of times.  Each time a hero attacks subtract 1 from Uses
 // timesToAttack is greater that the number of Uses should return -1 and not subtract from Uses.