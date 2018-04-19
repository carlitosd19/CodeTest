using System;

namespace BLL
{
    public class CodeTest
    {
        /// <summary>
        /// Is Palindrome
        /// </summary>
        /// <param name="inputText"></param>
        /// <returns></returns>
        public bool IsPalindrome(string inputText)
        {
            string reverseText = string.Empty;
            //return string reverse
            for (int i = inputText.Length - 1; i > -1; i--)
            {
                reverseText += inputText[i];
            }
            //compare the strings
            return inputText == reverseText;
        }

        public static bool IsPalindromeRecursive(string text)
        {
            if (text.Length <= 1)
                return true;
            if (text[0] != text[text.Length - 1])
                return false;
            else
                return IsPalindromeRecursive(text.Substring(1, text.Length - 2));
        }
    }
}
