using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("tattarrattat", true)]
        [InlineData("rudolph", false)]
        [InlineData("madam", true)]
        [InlineData("malayalam", true)]
        [InlineData("ball", false)]
        public void PalindromeTester(string word, bool expected)
        {
            //Arrange
            //var wordSmith = new WordSmith();
            //Act
            bool actual = WordSmith.IsPalindrome(word);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
