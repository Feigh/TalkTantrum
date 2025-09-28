using TalkGame.GameObjects;

namespace TalkGame;

public class Game
{
    public void Run()
    {
        var selectWord = new List<PlayerAction>() 
        { 
            new PlayerAction() { Id=1, Text="Du"},
            new PlayerAction() { Id=2, Text="Jag"} 
        };
        var loop = true;
        var game = new PlayerChoise();
        var activeChosies = new List<int>();
        while (loop)
        {
            Console.WriteLine("Gör ett val:");
            var printedlist = game.FormatChoises(selectWord);
            printedlist.ToList().ForEach(x => Console.WriteLine(x.Text));
            var key = Console.ReadKey();
            Console.WriteLine();

            if (key.Key == ConsoleKey.Q || key.Key == ConsoleKey.Escape)
            {
                loop = false;
            }
            
            activeChosies = game.ProcessKey(key, selectWord, activeChosies);
        }
        activeChosies.ToList().ForEach(x => Console.WriteLine(x));
    }
}