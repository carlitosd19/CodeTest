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
    }
}
