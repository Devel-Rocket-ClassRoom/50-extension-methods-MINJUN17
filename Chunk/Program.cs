using System;
using System.Collections.Generic;
using System.Linq;

Console.WriteLine("=== 컬렉션 청킹 테스트 ===");
Console.WriteLine();
Console.WriteLine("[숫자를 3개씩 그룹화]");
List<int> numbers = Enumerable.Range(1, 10).ToList();

foreach (var chunk in numbers.Chunk(3))
{
    Console.WriteLine($"[{string.Join(", ", chunk)}]");
}
Console.WriteLine();

Console.WriteLine("[학생들을 2명씩 팀 구성]");
List<string> students = new List<string>
{
    "김철수",
    "이영희",
    "박민수",
    "최지연",
    "정우진"
};
int team = 1;
foreach (var chunk in students.Chunk(2))
{
    Console.WriteLine($"팀 {team++}: {string.Join(", ", chunk)}");
}
Console.WriteLine();

Console.WriteLine("[페이지별로 5개씩 나누기]");
List<int> pages = Enumerable.Range(1, 25).ToList();
int page = 1;
foreach (var chunk in pages.Chunk(5))
{
    Console.WriteLine($"페이지 {page++}: {string.Join(", ", chunk)}");
}
