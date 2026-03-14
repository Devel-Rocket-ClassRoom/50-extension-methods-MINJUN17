using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class Palindrome
{
    public static bool IsPalindrome(this string text)
    {
        if (string.IsNullOrEmpty(text))
        {
            return false;
        }
        string result = new string(text.Where(c => char.IsLetterOrDigit(c)).ToArray()).ToUpper();
        char[] chars = result.ToCharArray();
        Array.Reverse(chars);
        string reverse = new string(chars);
        return result == reverse;
    }
}