using System;
using Xunit;
using HeroGameAdvancedLib;

namespace HeroGameAdvancedTests
{
    public class VillainTests
    {
                
        [Theory]
        [InlineData(0, 1)]
        [InlineData(3, 3)]
        [InlineData(2, 15)]
        
        public void Test(int expected, int input)
        {
            Villain testvillain = new Villain(1, "Test", 20);
            testvillain.Damage(input);
            Assert.Equal(expected, testvillain.Hitpoints);
        }
    }
}
// applies amount of damage to Hitpoints.
// if damage is greater that Hitpoints, Hitpoints should be set to 0 (zero)
