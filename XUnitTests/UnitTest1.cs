using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using ConsoleFindGCD;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Utilities;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Xunit;

namespace XUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanGetSameResultFromGcdRecursiveAndNonRecursive()
        {
            int result = GCD.gcd(2, 8);
            int result2 = GCD.GcdNonRecursive(2, 8);
            Assert.Equal(result, result2);
        }

        [Theory]
        [InlineData(new int[]  { 48, 96, 16 } )]
        public void CanProcessArrayOfInteger(int[] data)
        {
            int result = GCD.FindGcd(data);
            int result2 = GCD.FindGcdNonRecursive(data);
            Assert.Equal(result, result2);
        }
    }
}
