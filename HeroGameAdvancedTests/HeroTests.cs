using System;
using Xunit;
using HeroGameAdvancedLib;

namespace HeroGameAdvancedTests
{
    public class HeroTests
    {
        [Fact]
        public void Test1()
        {

        }
    }
}

// Hero is able to attack a given number of times.  Each time a hero attacks subtract 1 from Uses
        // timesToAttack is greater that the number of Uses should return -1 and not subtract from Uses.