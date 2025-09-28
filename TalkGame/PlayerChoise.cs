using TalkGame.GameObjects;

namespace TalkGame;

public class PlayerChoise
{
    public List<int> ProcessKey(ConsoleKeyInfo key, List<PlayerAction> toSelect, List<int> activwords, int currLevel)
    {
        if (int.TryParse(key.KeyChar.ToString(), out int rslt))
        {
            var result = toSelect.Where(x => x.Id == rslt).FirstOrDefault();
            var order = result.Levels.OrderByDescending(i => i).FirstOrDefault();
            if (order > currLevel)
                currLevel = order;
            activwords.Add(result.Id);         
        }

        return activwords;
    }

    public List<string> ListNewWords()
    {
        return null;
    }

    public List<PlayerAction> FormatChoises(List<PlayerAction> selectWord, int currlevel)
    {
        var result = selectWord.Where(x => x.Levels.Any(l => l <= currlevel)).Select((w) =>
        {
            return new PlayerAction() { Id = w.Id, Text = string.Format("{0}. {1}", w.Id.ToString(), w.Text) };
        });

        return result.ToList();
    }
}