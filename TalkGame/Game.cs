using TalkGame.GameObjects;

namespace TalkGame;

public class Game
{
    public void Run()
    {
        var selectWord = new List<PlayerAction>() 
        { 
            new PlayerAction() { Id=1, Levels = new List<int>{1},Text="Du"},
            new PlayerAction() { Id=2, Levels = new List<int>{1},Text="Jag"}, 
            new PlayerAction() { Id=3, Levels = new List<int>{1,2},Text="Get"},
            new PlayerAction() { Id=4, Levels = new List<int>{2},Text="Hus"}, 
            new PlayerAction() { Id=5, Levels = new List<int>{2},Text="Vete"},
            new PlayerAction() { Id=6, Levels = new List<int>{2},Text="Ägare"}, 
            new PlayerAction() { Id=7, Levels = new List<int>{2},Text="Fru"}
        };
        var loop = true;
        var game = new PlayerChoise();
        var activeChosies = new List<int>();
        var currentLevel = 1;
        while (loop)
        {
            Console.WriteLine("Gör ett val:");
            var printedlist = game.FormatChoises(selectWord,currentLevel);
            printedlist.ToList().ForEach(x => Console.WriteLine(x.Text));
            var key = Console.ReadKey();
            Console.WriteLine();

            if (key.Key == ConsoleKey.Q || key.Key == ConsoleKey.Escape)
            {
                loop = false;
            }
            
            activeChosies = game.ProcessKey(key, selectWord, activeChosies, ref currentLevel);
        }
        activeChosies.ToList().ForEach(x => Console.WriteLine(x));
    }
}