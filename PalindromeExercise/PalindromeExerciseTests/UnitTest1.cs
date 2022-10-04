using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("madam", true)]
        [InlineData("panama", false)]

        public void PalindromeTester(string word, bool expected)
        {
            var wordsmith = new WordSmith();
            var actual = wordsmith.IsAPalindrome(word);
            Assert.Equal(expected, actual);
        }
    }
}
