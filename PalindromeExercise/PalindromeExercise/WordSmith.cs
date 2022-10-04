using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PalindromeExercise;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            return word.ToLower().SequenceEqual(word.ToLower().Reverse());
        }
    }
}
