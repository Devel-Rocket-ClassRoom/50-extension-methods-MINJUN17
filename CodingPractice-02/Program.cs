using System;

////1
//string result = stringExtensions.First("안녕하세요", 3);
//Console.WriteLine(result);
//public static class stringExtensions
//{
//    public static string First(this string text, int count)
//    {
//        return text.Substring(0, count);
//    }
//}

//2
Player player = new Player() { Name = "용사", Level = 5, Experience = 150 };
Console.WriteLine(PlayerExtensions.GetInfo(player)); 
Console.WriteLine($"레벨업 가능: { PlayerExtensions.CanLevelUp(player)}");
if (PlayerExtensions.CanLevelUp(player))
{
    PlayerExtensions.LevelUp(player);
}
Console.WriteLine(PlayerExtensions.GetInfo(player));
class Player
{
    public string Name { get; set; }
    public int Level { get; set; }
    public int Experience { get; set; }

}

static class PlayerExtensions
{
    public static string GetInfo(this Player player)
    {
        return $"[{player.Name}] 레벨: {player.Level}, 경험치: {player.Experience}";
    }
    public static bool CanLevelUp(this Player player)
    {
        return player.Experience >= 100 ? true : false;
    }
    public static void LevelUp(this Player player)
    {
        player.Level++;
        player.Experience -= 100;
        Console.WriteLine($"{player.Name}이(가) 레벨업! 현재 레벨: {player.Level}");
    }
}
