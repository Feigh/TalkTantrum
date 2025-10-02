using TalkGame.GameObjects;

namespace TalkGame;

public class GameProgress
{
    // format the works selected and 
    public static string ChoisesCommited(List<PlayerAction> activwords)
    {
        var result = string.Join(" ", activwords.Select(x => x.Text));
        return result;
    }
    
    public static int CheckLevel(List<PlayerAction> activwords)
    {
        var newLevel = 0;
        foreach (var w in activwords)
        {
            var order = w.Levels.OrderByDescending(i => i).FirstOrDefault();
            if (order > newLevel)
                newLevel = order;
        }

        return newLevel;
    }
}