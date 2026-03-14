using System;
using System.Linq;

Console.WriteLine("=== 회문 판별 테스트 ===");
string text = "토마토";
Console.WriteLine($"\"{text}\" -> {text.IsPalindrome()}");
text = "기러기";
Console.WriteLine($"\"{text}\" -> {text.IsPalindrome()}");
text = "level";
Console.WriteLine($"\"{text}\" -> {text.IsPalindrome()}");
text = "Level";
Console.WriteLine($"\"{text}\" -> {text.IsPalindrome()}");
text = "A man, a plan, a canal: Panama";
Console.WriteLine($"\"{text}\" -> {text.IsPalindrome()}");
text = "race a car";
Console.WriteLine($"\"{text}\" -> {text.IsPalindrome()}");
text = "hello";
Console.WriteLine($"\"{text}\" -> {text.IsPalindrome()}");
text = "가나다";
Console.WriteLine($"\"{text}\" -> {text.IsPalindrome()}");
text = "";
Console.WriteLine($"\"{text}\" -> {text.IsPalindrome()}");


