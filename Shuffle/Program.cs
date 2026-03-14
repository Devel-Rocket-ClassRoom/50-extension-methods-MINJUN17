using System;
using System.Collections.Generic;

Console.WriteLine("=== 컬렉션 셔플 테스트 ===");

int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
Console.WriteLine("\n[숫자 리스트 셔플]");
Console.WriteLine("원본: " + string.Join(", ", numbers));
numbers.Shuffle();
Console.WriteLine("셔플: " + string.Join(", ", numbers));

Console.WriteLine("\n[카드 덱 셔플]");
string[] deck = { "♠A", "♥K", "♦Q", "♣J" };
Console.WriteLine("원본: " + string.Join(", ", deck));
deck.Shuffle();
Console.WriteLine("셔플: " + string.Join(", ", deck));

Console.WriteLine("\n[학생 순서 무작위 배치]");
string[] student = { "김철수", "이영희", "박민수", "최지연", "정우진" };
Console.WriteLine("원본: " + string.Join(", ", student));
student.Shuffle();
Console.WriteLine("셔플: " + string.Join(", ", student));

