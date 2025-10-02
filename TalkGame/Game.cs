using TalkGame.GameObjects;

namespace TalkGame;

public class Game
{
    public void Run()
    {
        var selectWord = new List<PlayerAction>() 
        {
            new PlayerAction(id: 1, levels: new List<int> { 1 }, text: "Du"),
            new PlayerAction(id: 2, levels: new List<int> { 1 }, text: "Jag"),
            new PlayerAction(id: 3, levels: new List<int> { 1 }, text: "Har"),
            new PlayerAction(id: 4, levels: new List<int> { 1, 2 }, text: "Get"),
            new PlayerAction(id: 5, levels: new List<int> { 2 }, text: "Hus"),
            new PlayerAction(id: 6, levels: new List<int> { 2 }, text: "Vete"),
            new PlayerAction(id: 7, levels: new List<int> { 2 }, text: "Ägare"),
            new PlayerAction(id: 8, levels: new List<int> { 2 }, text: "Fru")
        };
        var loop = true;
        var game = new PlayerChoise();
        var activeChosies = new List<PlayerAction>();
        var currentLevel = 1;
        while (loop)
        {
            Console.WriteLine("Gör ett val:");
            var printedlist = game.FormatChoises(selectWord,currentLevel);
            printedlist.ToList().ForEach(Console.WriteLine);
            var key = Console.ReadKey();
            Console.WriteLine();

            if (key.Key == ConsoleKey.Q || key.Key == ConsoleKey.Escape)
            {
                loop = false;
            }
            
            activeChosies = game.ProcessKey(key, selectWord, activeChosies);
            
            if (key.Key == ConsoleKey.E)
            {
                currentLevel = GameProgress.CheckLevel(activeChosies);
                Console.WriteLine(GameProgress.ChoisesCommited(activeChosies));
                activeChosies = new List<PlayerAction>();
            }
        }
        activeChosies.ToList().ForEach(x => Console.WriteLine(x));
    }
}