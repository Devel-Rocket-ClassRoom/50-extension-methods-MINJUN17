using System;
using System.Linq;

////1
//Console.WriteLine($"단어 개수: {StringHelper.CountWords("Hello World")}");
//static class StringHelper
//{
//    public static int CountWords(string text)
//    {
//        string[] wordsCount = text.Split(' ');
//        return wordsCount.Length;
//    }
//}

//2
Console.WriteLine($"단어 개수: {stringExtensions.CountWords("Hello World")}");
public static class stringExtensions
{
    public static int CountWords(this string text)
    {
        string[] wordsCount = text.Split(' ');
        return wordsCount.Length;
    }
}

////3
//Console.WriteLine($"10은(는) 짝수인가? {10.IsEven()}");
//Console.WriteLine($"7은(는) 홀수인가?  {7.IsOdd()}");
//Console.WriteLine($"3을 5번 반복: {3.Repeat(5)}"); 
//static class IntExtensions
//{
//    public static bool IsEven(this int number)
//    {
//        return number % 2 == 0;
//    }
//    public static bool IsOdd(this int number)
//    {
//        return number % 2 == 1;
//    }
//    public static string Repeat(this int number, int times)
//    {
//        return string.Concat(Enumerable.Repeat(number.ToString(), times));
//    }
//}

