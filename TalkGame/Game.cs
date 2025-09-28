using TalkGame.GameObjects;

namespace TalkGame;

public class Game
{
    public void Run()
    {
        var selectWord = new List<PlayerAction>() 
        { 
            new PlayerAction() { Id=1, Text="Du"},
            new PlayerAction() { Id=1, Text="Jag"} 
        };
        var loop = true;
        var game = new PlayerChoise();
        var activeChosies = new List<string>();
        while (loop)
        {
            Console.WriteLine("Gör ett val:");
            game.PrintChoises(selectWord.Select(x => x.Text).ToList());
            var key = Console.ReadKey();
            Console.WriteLine();

            if (key.Key == ConsoleKey.Q || key.Key == ConsoleKey.Escape)
            {
                loop = false;
            }
            
            activeChosies = game.ProcessKey(key, selectWord, activeChosies);
        }

    }
}