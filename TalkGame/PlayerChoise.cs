using TalkGame.GameObjects;

namespace TalkGame;

public class PlayerChoise
{
    public List<PlayerAction> ProcessKey(ConsoleKeyInfo key, List<PlayerAction> toSelect, List<PlayerAction> activwords)
    {
        if (int.TryParse(key.KeyChar.ToString(), out int rslt))
        {
            var result = toSelect.Where(x => x.Id == rslt).FirstOrDefault();
            activwords.Add(result);         
        }
        return activwords;
    }

    public List<string> ListNewWords()
    {
        return null;
    }

    public List<string> FormatChoises(List<PlayerAction> selectWord, int currlevel)
    {
        var result = selectWord.Where(x => x.Levels.Any(l => l <= currlevel)).Select((w) =>
        {
            return string.Format("{0}. {1}", w.Id.ToString(), w.Text);
        });

        return result.ToList();
    }
}