using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public static bool IsPalindrome(string word)
        {
            char[] chars = word.ToCharArray();

            Array.Reverse(chars);

            string reversWord = new string(chars);

            if (word == reversWord)
            {
                return true;
            }
            return false;
        }
    }
}
